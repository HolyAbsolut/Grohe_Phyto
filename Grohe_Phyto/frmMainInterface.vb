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

    Sub ImportMaterial(ByVal xlsFile As String, ByVal xlsTable As String)
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
            If Row("Delivery").ToString() <> "" And Row("Material").ToString() <> "" Then
                DsMaterialBindingSource.Filter = "Container_ID = '" & getContainerID(Row("Delivery").ToString()) & "' AND Material_No = '" & Row("Material").ToString() & "'"
                If DsMaterialBindingSource.Count = 0 Then

                    'Neu Anlegen
                    Dim newRow As dsGrohe.dsMaterialRow
                    newRow = DsGrohe.dsMaterial.NewdsMaterialRow
                    newRow.Container_ID = getContainerID("")
                    newRow.Material_No = Row("Material").ToString()
                    newRow.Created = Date.Now
                    DsGrohe.dsMaterial.Rows.Add(newRow)
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
            End If
            countRecord += 1
            ProgressBar.Value = countRecord
        Next
        Me.Validate()
        Me.DsMaterialBindingSource.EndEdit()
        Me.DsMaterialTableAdapter.Update(Me.DsGrohe.dsMaterial)
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

    Sub pop_dsPhyto()
        'DsGrohe.Total.Rows
        For Each Row As dsGrohe.TotalRow In DsGrohe.Total.Rows
            DsPhytoBindingSource.Filter = "HS_Code = '" & Row.HS_Code & "' AND Origin = '" & Row.Origin & "'"
            If DsPhytoBindingSource.Count = 0 Then
                Dim newRow As dsGrohe.dsPhytoRow
                newRow = DsGrohe.dsPhyto.NewdsPhytoRow
                newRow.HS_Code = Row.HS_Code
                newRow.Created = Date.Now
                newRow.Origin = Row.Origin
                DsGrohe.dsPhyto.Rows.Add(newRow)
                Me.Validate()
                Me.DsPhytoBindingSource.EndEdit()
                Me.DsPhytoTableAdapter.Update(Me.DsGrohe.dsPhyto)
            End If
        Next
    End Sub

    Sub chkPhytoRequiered()
        DsGrohe.Total.DefaultView.RowFilter = "chkPhytoDone = False"
        For Each Row As DataRowView In DsGrohe.Total.DefaultView
            Dim editPO As dsGrohe.dsShipmentsRow
            editPO = DsGrohe.dsShipments.FindBySTT_NO(Convert.ToInt64(Row.Item("STT_NO").ToString))
            editPO.chkPhytoDone = True
            editPO.chkNL = chkPhytoNL(Convert.ToInt64(Row.Item("HS_Code").ToString), Row.Item("Origin").ToString)
            editPO.chkDE = chkPhytoDE(Convert.ToInt64(Row.Item("HS_Code").ToString), Row.Item("Origin").ToString)
            If editPO.reqNL = False And editPO.reqDE = False Then
                editPO.chkDE = True
                editPO.chkNL = True
            End If
        Next
        Me.Validate()
        Me.DsShipmentsBindingSource.EndEdit()
        Me.DsShipmentsTableAdapter.Update(Me.DsGrohe.dsShipments)
        DsGrohe.dsShipments.DefaultView.RowFilter = String.Empty
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

    Function getContainerID(ByVal searchString As String) As Integer
        Dim searchColumn = "Container_No"
        DsContainerBindingSource.Filter = searchColumn & " = '" & searchString & "'"
        If DsContainerBindingSource.Count = 1 Then
            'Dim unRow As DataRow = DsDemag_HUB.UNLOC.Rows(DsDemag_HUB.UNLOC.Rows.IndexOf(DirectCast(UNLOCBindingSource.Current, DataRowView).Row))
            Dim unRow As DataRow = DsGrohe.dsContainer.Rows(DsGrohe.dsContainer.Rows.IndexOf(DirectCast(DsContainerBindingSource.Current, DataRowView).Row))
            Return Convert.ToInt32(unRow.Item("Container_ID"))
        Else
            Return 0
        End If

    End Function

    Function chkPhytoDE(ByVal HS_Code As Long, ByVal Origin As String) As Boolean
        DsGrohe.dsPhyto.DefaultView.RowFilter = "HS_Code = '" & HS_Code & "' AND Origin = '" & Origin & "'"
        If DsGrohe.dsPhyto.DefaultView.Count = 1 Then
            For Each Row As DataRowView In DsGrohe.dsPhyto.DefaultView
                Return Convert.ToBoolean(Row.Item("reqPhytoDE").ToString)
            Next
        Else
            MsgBox("ZolltarifNr DE nicht gefunden")
            Return True
        End If

    End Function

    Function chkPhytoNL(ByVal HS_Code As Long, ByVal Origin As String) As Boolean
        DsGrohe.dsPhyto.DefaultView.RowFilter = "HS_Code = '" & HS_Code & "' AND Origin = '" & Origin & "'"
        If DsGrohe.dsPhyto.DefaultView.Count = 1 Then
            For Each Row As DataRowView In DsGrohe.dsPhyto.DefaultView
                Return Convert.ToBoolean(Row.Item("reqModel99").ToString)
            Next
        Else
            MsgBox("ZolltarifNr NL nicht gefunden")
            Return True
        End If

    End Function

    'Drag & Dropp https://www.codeproject.com/Articles/7140/Drag-and-Drop-Attached-File-From-Outlook-and-ab
    Private Sub frmMaininterface_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles btnTango.DragDrop, btnHSCodes.DragDrop, btnHSCodes.DragDrop, txtTango.DragDrop, txtHSCodes.DragDrop, txtGroheInfo.DragDrop
        Dim fileNames As String() = Nothing

        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
                fileNames = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
                ' handle each file passed as needed
                ' do what you are going to do with each filename
                For Each fileName As String In fileNames
                    Select Case CType(sender, TextBox).Name
                        Case "txtTango"
                            txtTango.Text = fileName
                        Case "txtHSCodes"
                            txtHSCodes.Text = fileName
                        Case "txtGroheInfo"
                            txtGroheInfo.Text = fileName
                        Case Else
                            MsgBox("KA wie du das geschaft hast....")
                    End Select


                    'docHandle(fileName)
                Next
            ElseIf e.Data.GetDataPresent("FileGroupDescriptor") Then
                '
                ' the first step here is to get the filename
                ' of the attachment and
                ' build a full-path name so we can store it
                ' in the temporary folder
                '

                ' set up to obtain the FileGroupDescriptor
                ' and extract the file name
                Dim theStream As Stream = DirectCast(e.Data.GetData("FileGroupDescriptor"), Stream)
                Dim fileGroupDescriptor As Byte() = New Byte(511) {}
                theStream.Read(fileGroupDescriptor, 0, 512)
                ' used to build the filename from the FileGroupDescriptor block
                Dim fileName As New StringBuilder
                ' this trick gets the filename of the passed attached file
                Dim i As Integer = 76
                While fileGroupDescriptor(i) <> 0
                    fileName.Append(Convert.ToChar(fileGroupDescriptor(i)))
                    i += 1
                End While
                theStream.Close()
                Dim path__1 As String = Path.GetTempPath()
                ' put the zip file into the temp directory
                Dim theFile As String = path__1 & fileName.ToString()
                ' create the full-path name

                '
                ' Second step:  we have the file name.
                ' Now we need to get the actual raw
                ' data for the attached file and copy it to disk so we work on it.
                '

                ' get the actual raw file into memory
                Dim ms As MemoryStream = DirectCast(e.Data.GetData("FileContents", True), MemoryStream)
                ' allocate enough bytes to hold the raw data
                Dim fileBytes As Byte() = New Byte(CInt(ms.Length - 1)) {}
                ' set starting position at first byte and read in the raw data
                ms.Position = 0
                ms.Read(fileBytes, 0, CInt(ms.Length))
                ' create a file and save the raw zip file to it
                Dim fs As New FileStream(theFile, FileMode.Create)
                fs.Write(fileBytes, 0, CInt(fileBytes.Length))
                fs.Close()
                ' close the file
                Dim tempFile As New FileInfo(theFile)
                ' always good to make sure we actually created the file
                If tempFile.Exists = True Then
                    ' for now, just delete what we created
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''docHandle(theFile)
                    tempFile.Delete()
                Else
                    Trace.WriteLine("File was not created!")
                End If

            End If

        Catch ex As Exception

            ' don't use MessageBox here - Outlook or Explorer is waiting !
            Trace.WriteLine("Error in DragDrop function: " + ex.Message)
        End Try

    End Sub

    Private Sub btnImport_DragEnter(sender As Object, e As DragEventArgs) Handles btnTango.DragEnter, btnHSCodes.DragEnter, btnHSCodes.DragEnter, txtTango.DragEnter, txtHSCodes.DragEnter, txtGroheInfo.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Or e.Data.GetDataPresent("FileGroupDescriptor") Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    'Buttons
    Private Sub btnTango_Click(sender As Object, e As EventArgs) Handles btnTango.Click
        If txtTango.Text <> "" And txtSheetTango.Text <> "" Then
            ImportShipments(txtTango.Text, txtSheetTango.Text)
        End If
    End Sub

    Private Sub btnHSCodes_Click(sender As Object, e As EventArgs) Handles btnHSCodes.Click
        If txtHSCodes.Text <> "" And txtSheetHsCodes.Text <> "" Then
            ImportMATCodes(txtHSCodes.Text, txtSheetHsCodes.Text)
        End If
    End Sub

    Private Sub btnGrohexls_Click(sender As Object, e As EventArgs) Handles btnGrohexls.Click
        If txtGroheInfo.Text <> "" Then
            If txtMaterial.Text <> "" Then ImportMaterial(txtGroheInfo.Text, txtMaterial.Text)
            'If txtSheetMaterial.Text <> "" Then ImportMaterliaNo(txtGroheInfo.Text, txtSheetMaterial.Text)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            DsShipmentsBindingSource.RemoveFilter()
            Exit Sub
        End If

        Dim intSearch As Int64
        If Int64.TryParse(txtSearch.Text, intSearch) = False Then
            intSearch = 0
        End If

        If intSearch <> 0 Then
            DsShipmentsBindingSource.Filter = "STT_NO ='" & txtSearch.Text & "' OR " &
                                           "Archive_No ='" & txtSearch.Text & "' OR " &
                                           "HBL ='" & txtSearch.Text & "' OR " &
                                           "MBL ='" & txtSearch.Text & "' OR " &
                                           "POL ='" & txtSearch.Text & "' OR " &
                                           "POD ='" & txtSearch.Text & "' OR " &
                                           "Shipper ='" & txtSearch.Text & "'"
        Else
            DsShipmentsBindingSource.Filter = "Archive_No ='" & txtSearch.Text & "' OR " &
                                            "HBL ='" & txtSearch.Text & "' OR " &
                                            "MBL ='" & txtSearch.Text & "' OR " &
                                            "POL ='" & txtSearch.Text & "' OR " &
                                            "POD ='" & txtSearch.Text & "' OR " &
                                            "Shipper ='" & txtSearch.Text & "'"
        End If


        If DsShipmentsBindingSource.Count = 1 Then tabControl.SelectedTab = tabShipment

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pop_dsPhyto()
    End Sub

    Private Sub dgvMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellDoubleClick
        Me.tabControl.SelectedTab = tabShipment
    End Sub

    Private Sub btnShipmentsSave_Click(sender As Object, e As EventArgs) Handles btnShipmentsSave.Click
        Me.Validate()
        Me.DsShipmentsBindingSource.EndEdit()
        Me.DsShipmentsTableAdapter.Update(Me.DsGrohe.dsShipments)
    End Sub

    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        Select Case cmbFilter.Text
            Case "Standard"
                DsShipmentsBindingSource.RemoveFilter()
            Case "Phyto benötigt"
                DsShipmentsBindingSource.Filter = "reqModel99 = True AND chkModel99Done = False or reqPhytoDE= True AND chkPhytoDe = False"
            Case Else
                DsShipmentsBindingSource.RemoveFilter()
        End Select
    End Sub


    'Accept Buttons
    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        Me.AcceptButton = btnSearch
    End Sub

    Private Sub tabShipment_Enter(sender As Object, e As EventArgs) Handles tabShipment.Enter
        Me.AcceptButton = btnShipmentsSave
    End Sub

    Private Sub btnImportxls_Click(sender As Object, e As EventArgs) Handles btnImportxls.Click
        If txtTango.Text <> "" And txtSheetTango.Text <> "" Then
            ImportShipments(txtTango.Text, txtSheetTango.Text)
        End If

        If txtHSCodes.Text <> "" And txtSheetHsCodes.Text <> "" Then
            ImportMATCodes(txtHSCodes.Text, txtSheetHsCodes.Text)
        End If

        If txtGroheInfo.Text <> "" Then
            If txtMaterial.Text <> "" Then ImportMaterial(txtGroheInfo.Text, txtMaterial.Text)
        End If

        chkPhytoRequiered()

        LoadDb()

        MsgBox("Loading completed")

    End Sub


    'Link Click
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.flaticon.com/free-icon/ecology_1638174")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://www.flaticon.com/free-icon/save_148730")
    End Sub

    Private Sub chkDelete_CheckedChanged(sender As Object, e As EventArgs) Handles chkDelete.CheckedChanged
        My.Settings.DeleteFile = chkDelete.Checked
        My.Settings.Save()
    End Sub


    Private Sub txtSignature_Leave(sender As Object, e As EventArgs) Handles txtSignature.Leave
        My.Settings.sttSignature = txtSignature.Text
        My.Settings.Save()
    End Sub

    Private Sub btnSignaturePath_Click(sender As Object, e As EventArgs) Handles btnSignaturePath.Click
        dlgFileDialog.Title = "Bitte Signatur auswählen"
        dlgFileDialog.Filter = "Html Files|*.htm"
        dlgFileDialog.InitialDirectory = GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Signatures\"
        dlgFileDialog.ShowDialog() 'Fileauswählen
        txtSignature.Text = dlgFileDialog.FileName
        My.Settings.sttSignature = txtSignature.Text
        My.Settings.Save()
    End Sub



    Private Sub btnWispexMail_Click(sender As Object, e As EventArgs) Handles btnWispexMail.Click
        Dim Subject As String
        Dim Body As String
        Dim bdyTable As String

        Subject = "Grohe: Model99 & // " & STT_NOTextBox.Text & " // " & Archive_NoTextBox.Text & " // " & HBLTextBox.Text & " // " & MBLTextBox.Text & " // ETA:" & ETADateTimePicker.Value.Date.ToShortDateString

        bdyTable = "<table style='border-collapse: collapse; width: 95.4861%;' border='1'>  
            <tbody><tr> 
            <td style='width: 6.91748%;'>Origin</td>
            <td style='width: 12.9854%;'>Material No</td>
            <td style='width: 14.3204%;'>HS Code</td>
            <td style='width: 37.8641%;'>Description</td>
            <td style='width: 16.1408%;'>Container No</td></tr>"

        For Each row As DataGridViewRow In TotalDataGridView.Rows
            bdyTable = bdyTable & "<tr> 
            <td style='width: 6.91748%;'>" & POLTextBox.Text.Substring(0, 2) & "</td>
            <td style='width: 12.9854%;'>" & row.Cells(2).Value.ToString & "</td>
            <td style ='width: 14.3204%;'>" & row.Cells(3).Value.ToString & "</td>
            <td style='width: 37.8641%;'>" & row.Cells(4).Value.ToString & "</td>
            <td style ='width: 16.1408%;'>" & row.Cells(0).Value.ToString & "</td></tr>"
        Next
        bdyTable = bdyTable & "</tbody></table>"
        Body = "<p>Dear Sir or Madam,</p>
                <p>please issue a Modell 99 for this shipment. Location of clearing:</p> " &
                bdyTable &
                "<p>Attached invoice, packinglist &amp; BL. Please send us the document by mail once issued.</p>
                <p>&nbsp;</p>"

        SendMailHTTP("transit-3@wispex.nl", Subject, Body)

        'Speichern  
        ChkModel99DoneCheckBox.Checked = True
        Me.Validate()
        Me.DsShipmentsBindingSource.EndEdit()
        Me.DsShipmentsTableAdapter.Update(Me.DsGrohe.dsShipments)
    End Sub

    Sub chkMailWispex()
        If ChkModel99DoneCheckBox.Checked = False And ReqModel99CheckBox.Checked = True Then
            btnWispexMail.Enabled = True
        Else
            btnWispexMail.Enabled = False
        End If
    End Sub

    Private Sub ReqModel99CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ReqModel99CheckBox.CheckedChanged
        chkMailWispex()
    End Sub

    Private Sub ChkModel99DoneCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ChkModel99DoneCheckBox.CheckedChanged
        chkMailWispex()
    End Sub



End Class
