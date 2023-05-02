Public Class frmMain
    Dim spinvalue As Integer
    Dim num As Integer = 0
    Dim newnum As Integer
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        spinvalue = Int(Rnd() * 101 + 50)
        num += 1
        newnum += spinvalue
        If num = 0 Then
            PictureBox1.Image = My.Resources.wheel_1
        ElseIf num = 1 Then
            PictureBox1.Image = My.Resources.wheel_2
        ElseIf num = 2 Then
            PictureBox1.Image = My.Resources.wheel_3
        ElseIf num = 3 Then
            PictureBox1.Image = My.Resources.wheel_4
        ElseIf num = 4 Then
            PictureBox1.Image = My.Resources.wheel_5
        ElseIf num = 5 Then
            PictureBox1.Image = My.Resources.wheel_6
        ElseIf num = 6 Then
            PictureBox1.Image = My.Resources.wheel_7
        ElseIf num = 7 Then
            PictureBox1.Image = My.Resources.wheel_8
        ElseIf num = 8 Then
            PictureBox1.Image = My.Resources.wheel_9
        ElseIf num = 9 Then
            PictureBox1.Image = My.Resources.wheel_10
        ElseIf num = 10 Then
            PictureBox1.Image = My.Resources.wheel_11
        ElseIf num = 11 Then
            PictureBox1.Image = My.Resources.wheel_12
        ElseIf num = 12 Then
            PictureBox1.Image = My.Resources.wheel_13
        ElseIf num = 13 Then
            PictureBox1.Image = My.Resources.wheel_14
        ElseIf num = 14 Then
            PictureBox1.Image = My.Resources.wheel_15
        ElseIf num = 15 Then
            PictureBox1.Image = My.Resources.wheel_16
        ElseIf num = 16 Then
            PictureBox1.Image = My.Resources.wheel_17
        ElseIf num = 17 Then
            PictureBox1.Image = My.Resources.wheel_18
        ElseIf num = 18 Then
            PictureBox1.Image = My.Resources.wheel_19
        ElseIf num = 19 Then
            PictureBox1.Image = My.Resources.wheel_20
        ElseIf num = 20 Then
            PictureBox1.Image = My.Resources.wheel_21
        ElseIf num = 21 Then
            PictureBox1.Image = My.Resources.wheel_22
        ElseIf num = 22 Then
            PictureBox1.Image = My.Resources.wheel_23
        ElseIf num = 23 Then
            PictureBox1.Image = My.Resources.wheel_24
        ElseIf num = 24 Then
            PictureBox1.Image = My.Resources.wheel_25
        End If
        If num = 25 Then
            num = 0
        End If

    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        Timer1.Enabled = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
