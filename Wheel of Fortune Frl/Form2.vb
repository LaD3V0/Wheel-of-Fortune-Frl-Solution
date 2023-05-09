Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Runtime.Remoting.Metadata.W3cXsd2001

Public Class Form2Wheel
    Dim randGen As New Random
    Dim randnum As Integer
    Dim strFileName As String

    Private Sub Form2Wheel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim readfile As String



        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("C:\temp\text.txt")
        MsgBox(fileReader)
        lblPhrase.Text = fileReader

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'If Label1.Text.Trim.ToUpper Like "[A-Z][A-Z][A-Z][A-Z][A-Z]" Then

        '    'grpWord.Enabled = False
        '    'grpLetter.Enabled = True
        '    'lblResult.Text = "-----"
        '    'txtLetter.Focus()
        'Else
        '    MessageBox.Show("Please enter 5 letters.", "Guess the Word Game",
        '                    MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub
    Private Sub LetterCheck(ByVal itsChecked As String)
        Dim strcLetter As String
        Dim strInW As String

        strcLetter = itsChecked.Trim.ToUpper
        strInW = lblPhrase.Text

    End Sub

    Private Sub openFd1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles openFd1.FileOk

    End Sub
End Class
'Ideas that did not work

'readfile = My.Computer.FileSystem.
'lblPhrase.Text = readfile
'Dim fileReader As String
'fileReader = My.Computer.FileSystem.ReadAllText("C:\temp.txt")
'MsgBox(fileReader)
'lblPhrase.Text = fileReader

'Dim reader As New System.IO.StreamReader("/text.txt")
'Dim firstline, otherphrase As String
'firstline = reader.ReadLine()
'otherphrase = reader.ReadLine()
'reader.Close()
'lblPhrase.Text = firstline'

'openFd1.InitialDirectory = "C:\"
'openFd1.Title = "Open a Text File"
'openFd1.Filter = "thelines.txt"
''openFd1.ShowDialog()
'Dim fileReader As String
'fileReader = My.Computer.FileSystem.ReadAllText("C:\test.txt")
'MsgBox(fileReader)
'lblPhrase.Text = fileReader