Public Class frmMain
    Dim spinvalue As Integer
    Dim currentChoice As Integer
    Dim newnum As Integer
    Dim newspinvalue As Integer
    Dim newvalue As Integer
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spinvalue = 0
        currentChoice = 0
    End Sub

    Public Sub spinWheel(imageNum As Integer)
        If imageNum = 0 Then

            PictureBox1.Image = My.Resources.wheel_1

        ElseIf imageNum = 1 Then

            PictureBox1.Image = My.Resources.wheel_2

        ElseIf imageNum = 2 Then

            PictureBox1.Image = My.Resources.wheel_3

        ElseIf imageNum = 3 Then

            PictureBox1.Image = My.Resources.wheel_4

        ElseIf imageNum = 4 Then

            PictureBox1.Image = My.Resources.wheel_5

        ElseIf imageNum = 5 Then
            PictureBox1.Image = My.Resources.wheel_6


        ElseIf imageNum = 6 Then

            PictureBox1.Image = My.Resources.wheel_7

        ElseIf imageNum = 7 Then

            PictureBox1.Image = My.Resources.wheel_8

        ElseIf imageNum = 8 Then

            PictureBox1.Image = My.Resources.wheel_9

        ElseIf imageNum = 9 Then

            PictureBox1.Image = My.Resources.wheel_10

        ElseIf imageNum = 10 Then

            PictureBox1.Image = My.Resources.wheel_11

        ElseIf imageNum = 11 Then

            PictureBox1.Image = My.Resources.wheel_12
        ElseIf imageNum = 12 Then

            PictureBox1.Image = My.Resources.wheel_13
        ElseIf imageNum = 13 Then

            PictureBox1.Image = My.Resources.wheel_14
        ElseIf imageNum = 14 Then

            PictureBox1.Image = My.Resources.wheel_15
        ElseIf imageNum = 15 Then

            PictureBox1.Image = My.Resources.wheel_16
        ElseIf imageNum = 16 Then

            PictureBox1.Image = My.Resources.wheel_17
        ElseIf imageNum = 17 Then

            PictureBox1.Image = My.Resources.wheel_18
        ElseIf imageNum = 18 Then

            PictureBox1.Image = My.Resources.wheel_19
        ElseIf imageNum = 19 Then

            PictureBox1.Image = My.Resources.wheel_20
        ElseIf imageNum = 20 Then


            PictureBox1.Image = My.Resources.wheel_21
        ElseIf imageNum = 21 Then


            PictureBox1.Image = My.Resources.wheel_22
        ElseIf imageNum = 22 Then

            PictureBox1.Image = My.Resources.wheel_23
        ElseIf imageNum = 23 Then

            PictureBox1.Image = My.Resources.wheel_24
        ElseIf imageNum = 24 Then
            PictureBox1.Image = My.Resources.wheel_25

        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        spinWheel(currentChoice Mod 25)
        currentChoice += 1

        ' MsgBox(currentChoice & spinvalue)

        If currentChoice = spinvalue Then
            Timer1.Enabled = False
            Exit Sub
        End If

    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click

        spinvalue = Int(Rnd() * 26 + 50)
        Timer1.Enabled = True


    End Sub
    Private Sub slowthespin()
        'If num = Int(newvalue / 2) Then
        '    Timer1.Interval = 50
        'ElseIf num = Int(newvalue / 1.5) Then
        '    Timer1.Interval = 100
        'ElseIf num = Int(newvalue / 1.25) Then
        '    Timer1.Interval = 200
        'ElseIf num = Int(newvalue / 1.05) Then
        '    Timer1.Interval = 350
        'ElseIf num = newvalue / 1 Then
        '    Timer1.Interval = 1000
        'End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnotraForm_Click(sender As Object, e As EventArgs) Handles btnotraForm.Click
        Me.Visible = False
        Form2Wheel.Visible = True
    End Sub
End Class
