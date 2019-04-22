Option Strict On
Imports System.Data.SQLite
Imports System.Text
Imports System.IO
Imports System.ComponentModel
Imports System.Environment

Imports System.Data
Imports System.Collections.Generic
Imports ClosedXML.Excel

Public Class frmMainInterface


    'SUBS Load
    Private Sub frmMainInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkDelete.Checked = My.Settings.DeleteFile
        txtSignature.Text = My.Settings.sttSignature
        LoadDb()



    End Sub

    Sub LoadDb(Optional ByVal Database As String = "ALL")
        If My.Settings.sttDBPath = "" Then
            dlgFileDialog.Title = "Bitte Datenbank auswählen"
            dlgFileDialog.ShowDialog() 'Fileauswählen
            My.Settings.sttDBPath = dlgFileDialog.FileName
        End If

        DsMaterialTableAdapter.Connection.ConnectionString = "Data Source=" & My.Settings.sttDBPath
        DtMatCodeTableAdapter.Connection.ConnectionString = "Data Source=" & My.Settings.sttDBPath
        DsContainerTableAdapter.Connection.ConnectionString = "Data Source=" & My.Settings.sttDBPath
        TotalTableAdapter.Connection.ConnectionString = "Data Source=" & My.Settings.sttDBPath
        DsShipmentsTableAdapter.Connection.ConnectionString = "Data Source=" & My.Settings.sttDBPath
        DtHSCodeTableAdapter.Connection.ConnectionString = "Data Source=" & My.Settings.sttDBPath
        DsPhytoTableAdapter.Connection.ConnectionString = "Data Source=" & My.Settings.sttDBPath


        Select Case Database
            Case "dsMaterial"
                Me.DsMaterialTableAdapter.Fill(Me.DsGrohe.dsMaterial)
            Case "dsHSCode"
                Me.DtMatCodeTableAdapter.Fill(Me.DsGrohe.dtMatCode)
            Case "dsContainer"
                Me.DsContainerTableAdapter.Fill(Me.DsGrohe.dsContainer)
            Case "dsPhyto"
                Me.DsPhytoTableAdapter.Fill(Me.DsGrohe.dsPhyto)
            Case "dtHSCode"
                Me.DtHSCodeTableAdapter.Fill(Me.DsGrohe.dtHSCode)
            Case "dsShipments"
                Me.DsShipmentsTableAdapter.Fill(Me.DsGrohe.dsShipments)
            Case "Total"
                Me.TotalTableAdapter.Fill(Me.DsGrohe.Total)
            Case Else
                Me.DsMaterialTableAdapter.Fill(Me.DsGrohe.dsMaterial)
                Me.DtMatCodeTableAdapter.Fill(Me.DsGrohe.dtMatCode)
                Me.DsContainerTableAdapter.Fill(Me.DsGrohe.dsContainer)
                Me.TotalTableAdapter.Fill(Me.DsGrohe.Total)
                Me.DsShipmentsTableAdapter.Fill(Me.DsGrohe.dsShipments)
                Me.DtHSCodeTableAdapter.Fill(Me.DsGrohe.dtHSCode)
                Me.DsPhytoTableAdapter.Fill(Me.DsGrohe.dsPhyto)
        End Select
    End Sub

    'SUBS Import

    Sub ImportShipments(ByVal xlsFile As String, ByVal xlsTable As String)
        'Prüfen ob Datei vorhanden
        If My.Computer.FileSystem.FileExists(xlsFile) = False Then
            MsgBox("Keine Datei gefungen")
            Exit Sub
        End If


        Dim tblImport As DataTable = xls_To_Datatable(xlsFile, xlsTable)


        Dim countRecord As Integer = 0
        ProgressBar.Maximum = tblImport.Rows.Count
        ProgressBar.Value = countRecord

        'Import Zeile für Zeile bearbeiten
        For Each Row As DataRow In tblImport.Rows

            'Prüfen ob Record bereits vorhanden

            DsShipmentsBindingSource.Filter = "STT_NO = '" & Row("STT No.").ToString() & "'"
            If DsShipmentsBindingSource.Count = 0 Then

                'Neu Anlegen
                Dim newRow As dsGrohe.dsShipmentsRow
                newRow = DsGrohe.dsShipments.NewdsShipmentsRow
                newRow.STT_NO = Convert.ToInt64(Row("STT No.").ToString())
                newRow.Created = Date.Now
                newRow.Archive_No = Row("Archive No.").ToString()
                newRow.HBL = Row("HB/L No.").ToString()
                newRow.MBL = Row("B/L No.").ToString()
                newRow.POL = Row("Departure").ToString()
                newRow.POD = Row("Destination").ToString()
                newRow.Origin = Row("Departure").ToString().Substring(0, 2)
                newRow.ETD = Convert.ToDateTime(Row("ETD (Date)").ToString())
                newRow.ETA = Convert.ToDateTime(Row("ETA (Date)").ToString())
                newRow.Pieces = Convert.ToInt32(Row("No. of Pieces").ToString())
                newRow.Weight = Convert.ToDouble(Row("Gross Weight (weight)").ToString())
                newRow.Volume = Convert.ToDouble(Row("Volume (volume)").ToString())
                newRow.Principal = Row("Principal Name").ToString()
                newRow.Shipper = Row("Shipper Name").ToString()
                newRow.Consignee = Row("Consignee Name").ToString()
                newRow.chkPhytoDone = False
                newRow.reqNL = True
                newRow.reqDE = True
                newRow.chkNL = False
                newRow.chkDE = False



                DsGrohe.dsShipments.Rows.Add(newRow)




                'Container Nr Hinzufügen
                Dim ContArray As String() = Row("Container No.").ToString().Split(New Char() {","c})
                For Each Cont In ContArray
                    'Prüfen ob Record bereits vorhanden
                    DsContainerBindingSource.Filter = "Container_No = '" & Cont.Trim & "'"
                    If DsContainerBindingSource.Count = 0 Then
                        Dim dsNewCont As dsGrohe.dsContainerRow
                        dsNewCont = DsGrohe.dsContainer.NewdsContainerRow
                        dsNewCont.Container_No = Cont.Trim
                        dsNewCont.Created = Date.Now
                        dsNewCont.STT_No = Convert.ToInt64(Row("STT No.").ToString())
                        DsGrohe.dsContainer.Rows.Add(dsNewCont)
                    Else 'Update
                        'Dim editPO As dsGrohe.dsContainerRow
                        'editPO = DsGrohe.dsContainer.FindByContainer_ID(getContainerID(Cont.Trim))
                        'If editPO.IsSTT_NoNull Then
                        '    'ToDO wir haben hier eine Paralitäzverletzung
                        '    editPO.STT_No = Convert.ToInt64(Row("STT No.").ToString())
                        'End If

                    End If
                Next





            Else

                'If Row("Purchase Order").ToString().Length <= 14 Then
                '    Dim chkLatestETD As Date
                '    Select Case Row("Latest ETD").ToString().Length
                '        Case 8
                '            chkLatestETD = DateTime.ParseExact(Row("Latest ETD").ToString(), "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                '        Case 10
                '            chkLatestETD = DateTime.ParseExact(Row("Latest ETD").ToString(), "dd.MM.yyyy", Globalization.CultureInfo.InvariantCulture)
                '        Case Else
                '            chkLatestETD = Date.Today
                '            MsgBox("Bitte Latest ETD für " & Row("Latest ETD").ToString() & " prüfen")
                '    End Select


                '    Dim editPO As HellwegDataSet.dsPurchaseOrderRow
                '    editPO = HellwegDataSet.dsPurchaseOrder.FindByPONo(Row("Purchase Order").ToString())
                '    If editPO.LatestETD <> chkLatestETD Then
                '        'Update
                '        editPO.EditDate = Date.Now
                '        editPO.Comment = "Last Latested ETD was: " & editPO.LatestETD.ToShortDateString
                '        editPO.LatestETD = chkLatestETD
                '        MsgBox("Latest ETD hat sich geändert. Bitte prüfen!")
                '    End If
                'End If
            End If

            countRecord += 1
            ProgressBar.Value = countRecord
        Next

        Me.DsShipmentsBindingSource.EndEdit()
        Me.DsShipmentsTableAdapter.Update(Me.DsGrohe.dsShipments)
        Me.Validate()
        Me.DsContainerBindingSource.EndEdit()
        Me.DsContainerTableAdapter.Update(Me.DsGrohe.dsContainer)
        'Hellweg_BookingDataSet.AcceptChanges()
        If chkDelete.Checked = True Then My.Computer.FileSystem.DeleteFile(xlsFile)
        MsgBox("Update successful")
    End Sub

    Sub ImportMATCodes(ByVal xlsFile As String, ByVal xlsTable As String)
        'Prüfen ob Datei vorhanden
        If My.Computer.FileSystem.FileExists(xlsFile) = False Then
            MsgBox("Keine Datei gefungen")
            Exit Sub
        End If

        Dim tblImport As DataTable = xls_To_Datatable(xlsFile, xlsTable)

        Dim countRecord As Integer = 0
        ProgressBar.Maximum = tblImport.Rows.Count
        ProgressBar.Value = countRecord

        'Import Zeile für Zeile bearbeiten
        For Each Row As DataRow In tblImport.Rows

            'Prüfen ob Record bereits vorhanden
            DtMatCodeBindingSource.Filter = "Material_ID = '" & Row("Produktnummer").ToString() & "'"
            If DtMatCodeBindingSource.Count = 0 Then
                'MsgBox(Row("Produktnummer").ToString())
                'Neu Anlegen
                Dim newRow As dsGrohe.dtMatCodeRow
                newRow = DsGrohe.dtMatCode.NewdtMatCodeRow
                newRow.Material_ID = Row("Produktnummer").ToString()
                newRow.Created = Date.Now
                newRow.Description = Row("Zollrechtl. Warenbeschreibung").ToString()
                chkHSCode(Convert.ToInt64(Row("Nummer").ToString()))
                newRow.HS_Code = Convert.ToInt64(Row("Nummer").ToString())
                DsGrohe.dtMatCode.Rows.Add(newRow)
            Else

                'If Row("Purchase Order").ToString().Length <= 14 Then
                '    Dim chkLatestETD As Date
                '    Select Case Row("Latest ETD").ToString().Length
                '        Case 8
                '            chkLatestETD = DateTime.ParseExact(Row("Latest ETD").ToString(), "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                '        Case 10
                '            chkLatestETD = DateTime.ParseExact(Row("Latest ETD").ToString(), "dd.MM.yyyy", Globalization.CultureInfo.InvariantCulture)
                '        Case Else
                '            chkLatestETD = Date.Today
                '            MsgBox("Bitte Latest ETD für " & Row("Latest ETD").ToString() & " prüfen")
                '    End Select


                '    Dim editPO As HellwegDataSet.dsPurchaseOrderRow
                '    editPO = HellwegDataSet.dsPurchaseOrder.FindByPONo(Row("Purchase Order").ToString())
                '    If editPO.LatestETD <> chkLatestETD Then
                '        'Update
                '        editPO.EditDate = Date.Now
                '        editPO.Comment = "Last Latested ETD was: " & editPO.LatestETD.ToShortDateString
                '        editPO.LatestETD = chkLatestETD
                '        MsgBox("Latest ETD hat sich geändert. Bitte prüfen!")
                '    End If
                'End If
            End If
            countRecord += 1
            ProgressBar.Value = countRecord
        Next
        Me.Validate()
        Me.DtMatCodeBindingSource.EndEdit()
        Me.DtMatCodeTableAdapter.Update(Me.DsGrohe.dtMatCode)
        'Hellweg_BookingDataSet.AcceptChanges()
        If chkDelete.Checked = True Then My.Computer.FileSystem.DeleteFile(xlsFile)
        MsgBox("Update successful")
    End Sub


    'Subs
    Sub chkHSCode(ByVal HSCode As Long)
        DtHSCodeBindingSource.Filter = "HS_Code = '" & HSCode & "'"
        If DtHSCodeBindingSource.Count = 0 Then
            Dim newRow As dsGrohe.dtHSCodeRow
            newRow = DsGrohe.dtHSCode.NewdtHSCodeRow
            newRow.HS_Code = HSCode
            newRow.Created = Date.Now
            DsGrohe.dtHSCode.Rows.Add(newRow)
            Me.Validate()
            Me.DtHSCodeBindingSource.EndEdit()
            Me.DtHSCodeTableAdapter.Update(Me.DsGrohe.dtHSCode)
        End If
    End Sub

    'Function
    Function xls_To_Datatable(ByVal dirExcel As String, ByVal xlsTable As String) As DataTable
        'Open the Excel file using ClosedXML.
        Using workBook As New XLWorkbook(dirExcel)
            'Read the first Sheet from Excel file.
            Dim workSheet As IXLWorksheet = workBook.Worksheet(xlsTable)
            Dim cntColumn As Integer = -1
            'Create a new DataTable.
            Dim dt As New DataTable()

            'Loop through the Worksheet rows.
            Dim firstRow As Boolean = True
            For Each row As IXLRow In workSheet.Rows()
                'Use the first row to add columns to DataTable.

                If firstRow Then
                    For Each cell As IXLCell In row.Cells()
                        dt.Columns.Add(cell.Value.ToString())
                        cntColumn += 1
                    Next
                    firstRow = False
                Else
                    'Add rows to DataTable.
                    dt.Rows.Add()
                    Dim i As Integer = 0
                    For col As Integer = 1 To cntColumn
                        Dim cell As IXLCell = row.Cell(col)
                        dt.Rows(dt.Rows.Count - 1)(i) = cell.Value.ToString()
                        i += 1
                    Next

                End If

                'GridView1.DataSource = dt
            Next
            Return dt
        End Using

        'xls_To_Datatable = dt
    End Function


End Class
