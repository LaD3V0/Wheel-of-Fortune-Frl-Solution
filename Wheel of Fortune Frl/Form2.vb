Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Runtime.Remoting.Metadata.W3cXsd2001

Public Class Form2Wheel
    Dim randGen As New Random
    Dim randnum As Integer

    Private Sub Form2Wheel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class