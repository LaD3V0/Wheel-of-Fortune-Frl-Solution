Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Runtime.Remoting.Metadata.W3cXsd2001

Public Class Form2Wheel
    Dim word As Integer
    Dim word1 As Integer
    Dim rand As New Random
    Dim strWord As String
    Dim TurnState As Double
    Dim countOne As Double
    Dim countTwo As Double
    Dim dblValue As Double
    Public strShareword As String
    Dim strWordR As String

    Private Sub Form2Wheel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnA.Visible = False
        btnB.Visible = False
        btnC.Visible = False
        btnD.Visible = False
        btnE.Visible = False
        btnF.Visible = False
        btnG.Visible = False
        btnH.Visible = False
        btnI.Visible = False
        btnJ.Visible = False
        btnK.Visible = False
        btnL.Visible = False
        btnM.Visible = False
        btnN.Visible = False
        btnO.Visible = False
        btnP.Visible = False
        btnQ.Visible = False
        btnR.Visible = False
        btnS.Visible = False
        btnT.Visible = False
        btnU.Visible = False
        btnV.Visible = False
        btnW.Visible = False
        btnX.Visible = False
        btnY.Visible = False
        btnZ.Visible = False
        btnSolve.Visible = True

    End Sub
    Private Sub NewGame()
        txtGuess.Text = String.Empty
        btnA.Enabled = True
        btnB.Enabled = True
        btnC.Enabled = True
        btnD.Enabled = True
        btnE.Enabled = True
        btnF.Enabled = True
        btnG.Enabled = True
        btnH.Enabled = True
        btnI.Enabled = True
        btnJ.Enabled = True
        btnK.Enabled = True
        btnL.Enabled = True
        btnM.Enabled = True
        btnN.Enabled = True
        btnO.Enabled = True
        btnP.Enabled = True
        btnQ.Enabled = True
        btnR.Enabled = True
        btnS.Enabled = True
        btnT.Enabled = True
        btnU.Enabled = True
        btnV.Enabled = True
        btnW.Enabled = True
        btnX.Enabled = True
        btnY.Enabled = True
        btnZ.Enabled = True

        If CDbl(txtD.Text) = 2 Then
            Dim intRandNum As Integer
            Dim Randgen As New Random
            Dim intUpper As Integer
            Dim randWord As String
            intUpper = IO.File.ReadAllLines("C:\Users\bjackson8833\Desktop
        \vb data files\7\Capstone 7\Capstone 7\txt.txt").Count
            If intUpper = 0 Then
                MsgBox("There are no words in this file")
            End If
            intRandNum = Randgen.Next(0, intUpper)
            randWord = IO.File.ReadAllLines("C:\Users\bjackson8833\Desktop
        \vb data files\7\Capstone 7\Capstone 7\txt.txt").ElementAt(intRandNum).ToString
            strWord = randWord
            strWordR = randWord
            For intIndex As Integer = 0 To randWord.Length - 1
                If randWord(intIndex) = Space(1) Then
                    txtGuess.Text = txtGuess.Text + " "
                Else
                    txtGuess.Text = txtGuess.Text + "_"
                End If
            Next
        End If
        TurnState = 1
    End Sub
    Private Sub CheckLetter(ByVal strinput As String)
        Dim strLetter As String
        Dim strResult As String
        strLetter = strinput.Trim.ToUpper
        strResult = txtGuess.Text
        If strWord.Contains(strLetter) Then
            ' Replace the hyphen(s) in strResult.
            For intIndex As Integer = 0 To strWord.Length - 1
                If strWord(intIndex) = strLetter Then
                    strResult = strResult.Remove(intIndex, 1)
                    strResult = strResult.Insert(intIndex, strLetter)
                End If
            Next
            ' Display the contents of strResult.
            txtGuess.Text = strResult
            ' Determine whether strResult contains any hyphens.
            If TurnState = 1 Then
                lblOneCount.Text = countOne.ToString
                lblOneCount.Text = (countOne + dblValue).ToString("C2")
                countOne = CDbl(lblOneCount.Text)
            ElseIf TurnState = 2 Then
                lblTwoCount.Text = countTwo.ToString
                lblTwoCount.Text = (countTwo + dblValue).ToString("C2")
                countTwo = CDbl(lblTwoCount.Text)
            End If
            If strResult.Contains("_") = False Then
                Winstate()
            End If
        Else
            If TurnState = 1 Then
                TurnState = 2
            ElseIf TurnState = 2 Then
                TurnState = 1
            End If
            changeTurn()
        End If

    End Sub
    Private Sub Winstate()
        If TurnState = 1 Then
            Dim dlgbutton As DialogResult
            dlgbutton = MessageBox.Show("Player 1 Won!The word/phrase was 
    " + strWordR + "! Start a New Round?", "Wheel Of 
    Fortune!",
MessageBoxButtons.YesNo,
MessageBoxIcon.Exclamation)
            If dlgbutton = DialogResult.Yes Then
                NewGameN()
                NewGame()
            ElseIf dlgbutton = DialogResult.No Then
                frmExtra.Close()
                Me.Close()
            End If
        ElseIf TurnState = 2 Then
            Dim dlgbutton As DialogResult
            dlgbutton = MessageBox.Show("Player 2 Won!The word/phrase was 
    " + strWordR + "! Start a New Round?", "Wheel Of 
    Fortune!",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation)
            If dlgbutton = DialogResult.Yes Then
                NewGameN()
                NewGame()
            ElseIf dlgbutton = DialogResult.No Then
                frmExtra.Close()
                Me.Close()
            End If
        End If
    End Sub
    Private Sub NewGameN()
        lblTotal.Text = ""
        lblRolled.Text = ""
        picArrow.Visible = True
        picWheel.Visible = True
        btnSpin.Visible = True
        btnGuess.Visible = True
        txtWord.Visible = False
        txtSolve.Visible = False
        btnA.Visible = False
        btnB.Visible = False
        btnC.Visible = False
        btnD.Visible = False
        btnE.Visible = False
        btnF.Visible = False
        btnG.Visible = False
        btnH.Visible = False
        btnI.Visible = False
        btnJ.Visible = False
        btnK.Visible = False
        btnL.Visible = False
        btnM.Visible = False
        btnN.Visible = False
        btnO.Visible = False
        btnP.Visible = False
        btnQ.Visible = False
        btnR.Visible = False
        btnS.Visible = False
        btnT.Visible = False
        btnU.Visible = False
        btnV.Visible = False
        btnW.Visible = False
        btnX.Visible = False
        btnY.Visible = False
        btnZ.Visible = False
        btnSolve.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnQ.Click
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
        'Dim strcLetter As String
        'Dim strInW As String

        'strcLetter = itsChecked.Trim.ToUpper
        'strInW = lblPhrase.Text

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