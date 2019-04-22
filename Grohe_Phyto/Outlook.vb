'http://support.microsoft.com/kb/313803/de
'https://www.emailarchitect.net/easendmail/kb/vbnet.aspx?cat=6

Option Strict Off ' Leider notwendig
Imports Outlook = Microsoft.Office.Interop.Outlook

Module SendMailOutlook


    Sub SendMail(ByVal adrTO As String,
                 ByVal Subject As String,
                    ByVal Body As String,
                    Optional ByVal Attachment As String = "",
                    Optional ByVal adrCC As String = "",
                    Optional ByVal adrBCC As String = "")

        ' Create an Outlook application.
        Dim oApp As Outlook._Application
        oApp = New Outlook.Application()

        ' Create a new MailItem.
        Dim oMsg As Outlook._MailItem
        oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
        oMsg.Subject = Subject
        oMsg.Body = Body

        ' TODO: Replace with a valid e-mail address.
        oMsg.To = adrTO
        oMsg.CC = adrCC
        oMsg.BCC = adrBCC

        ' Add an attachment
        Dim oAttachs As Outlook.Attachments = oMsg.Attachments
        Dim oAttach As Outlook.Attachment


        If Attachment <> "" Then
            ' TODO: Replace with a valid attachment path.
            'Dim sSource As String = "C:\Temp\Hello.txt"
            ' TODO: Replace with attachment name
            Dim sDisplayName As String = "Hellweg.xlsx"

            Dim sBodyLen As String = oMsg.Body.Length
            oAttach = oAttachs.Add(Attachment, , sBodyLen + 1, sDisplayName)
        End If

        ' Send
        'If My.Settings.Sent_Display.ToString = True Then
        '    oMsg.Send()
        'Else
        '    oMsg.Display()
        'End If
        oMsg.Display()

        ' Clean up
        oApp = Nothing
        oMsg = Nothing
        oAttach = Nothing
        oAttachs = Nothing

    End Sub


    Sub SendMailHTTP(ByVal adrTO As String,
                 ByVal Subject As String,
                    ByVal Body As String,
                    Optional ByVal Attachment As String = "",
                    Optional ByVal adrCC As String = "",
                    Optional ByVal adrBCC As String = "",
                     Optional ByVal sentHidden As Boolean = False)

        ' Create an Outlook application.
        Dim oApp As Outlook._Application
        oApp = New Outlook.Application()

        Dim Signature As String = String.Empty

        If My.Computer.FileSystem.FileExists(My.Settings.sttSignature) = True Then
            Dim sr As New IO.StreamReader(My.Settings.sttSignature)
            Signature = sr.ReadToEnd()
        End If


        ' Create a new MailItem.
        Dim oMsg As Outlook._MailItem
        oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
        oMsg.Subject = Subject
        oMsg.HTMLBody = Body & "<br>" & Signature 'Signature



        ' TODO: Replace with a valid e-mail address.
        oMsg.To = adrTO
        oMsg.CC = adrCC
        oMsg.BCC = adrBCC

        ' Add an attachment
        Dim oAttachs As Outlook.Attachments = oMsg.Attachments
        Dim oAttach As Outlook.Attachment


        If Attachment <> "" Then
            ' TODO: Replace with a valid attachment path.
            'Dim sSource As String = "C:\Temp\Hello.txt"
            ' TODO: Replace with attachment name
            Dim sDisplayName As String = "Hellweg.xlsx"

            Dim sBodyLen As String = oMsg.Body.Length
            oAttach = oAttachs.Add(Attachment, , sBodyLen + 1, sDisplayName)
        End If

        'Send
        If sentHidden = True Then
            oMsg.Send()
        Else
            oMsg.Display()
        End If


        ' Clean up
        oApp = Nothing
        oMsg = Nothing
        oAttach = Nothing
        oAttachs = Nothing

    End Sub


    Sub OutlookAddTask(ByVal Subject As String,
                       ByVal Body As String,
                       ByVal StartDate As Date,
                       ByVal DueDate As Date,
                       ByVal ReminderTime As Date,
                       ByVal ReminderSet As Boolean)


        ' Create an Outlook application.
        Dim oApp As Outlook._Application
        oApp = New Outlook.Application()

        ' Create a new MailItem.
        Dim oTask As Outlook.TaskItem
        oTask = oApp.CreateItem(Outlook.OlItemType.olTaskItem)
        oTask.Subject = Subject
        oTask.Body = Body
        oTask.DueDate = DueDate
        oTask.StartDate = StartDate
        oTask.ReminderSet = ReminderSet
        oTask.ReminderTime = ReminderTime

        oTask.Save()
        oApp = Nothing
        oTask = Nothing


    End Sub



    'Function GetBoiler(ByVal sFile As String) As String
    '    'Dick Kusleika
    '    Dim fso As Object
    '    Dim ts As Object
    '    fso = CreateObject("Scripting.FileSystemObject")
    '    ts = fso.GetFile(sFile).OpenAsTextStream(1, -2)
    '    GetBoiler = ts.readall
    '    ts.Close
    'End Function

End Module