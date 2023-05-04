Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Runtime.Remoting.Metadata.W3cXsd2001

Public Class Form2Wheel
    Dim spinvalue As Integer
    Dim randNum As Decimal
    Dim num As Integer
    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        Timer1.Enabled = True
        randNum = Int((Rnd() * 7) + 1)
        btnSpin.Text = randNum
        pic1Start.Visible = False
        pic2.Visible = False
        pic3.Visible = False
        pic4.Visible = False
        pic5.Visible = False
        pic6.Visible = False
        pic7.Visible = False
        pic8.Visible = False
        pic9.Visible = False
        pic10.Visible = False
        pic11.Visible = False
        pic12.Visible = False
        pic13.Visible = False
        pic14.Visible = False
        pic15.Visible = False
        pic16.Visible = False
        pic17.Visible = False
        pic18.Visible = False
        pic19.Visible = False
        pic20.Visible = False
        pic21.Visible = False
        pic22.Visible = False
        pic23.Visible = False
        pic24.Visible = False
        pic25.Visible = False

        picSel1.Visible = False
        picSel2.Visible = False
        picSel3.Visible = False
        picSel4.Visible = False
        picSel5.Visible = False
        picSel6.Visible = False
        picSel7.Visible = False
        picSel8.Visible = False
        picSel9.Visible = False
        picSel10.Visible = False
        picSel11.Visible = False
        picSel12.Visible = False
        picSel13.Visible = False
        picSel14.Visible = False
        picSel15.Visible = False
        picSel16.Visible = False
        picSel17.Visible = False
        picSel18.Visible = False
        picSel19.Visible = False
        picSel20.Visible = False
        picSel21.Visible = False
        picSel22.Visible = False '
        picSel23.Visible = False
        picSel24.Visible = False
        picSel25.Visible = False


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) 
        spinvalue += 1
        num += 1
        If spinvalue = 5 Then
            pic1Start.BackColor = Color.Blue
        ElseIf spinvalue = 10 Then
            pic1Start.BackColor = Color.Orange
            pic2.BackColor = Color.Blue
        ElseIf spinvalue = 15 Then
            pic2.BackColor = Color.Orange
            pic3.BackColor = Color.Blue
        ElseIf spinvalue = 20 Then
            pic3.BackColor = Color.Orange
            pic4.BackColor = Color.Blue
        ElseIf spinvalue = 25 Then
            pic4.BackColor = Color.Orange
            pic5.BackColor = Color.Blue
        ElseIf spinvalue = 30 Then
            pic5.BackColor = Color.Orange
            pic6.BackColor = Color.Blue
        ElseIf spinvalue = 35 Then
            pic6.BackColor = Color.Orange
            pic7.BackColor = Color.Blue
        End If
    End Sub

    Private Sub Form2Wheel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
    End Sub
End Class