Public Class frmMain
    Dim spinvalue As Integer
    Dim num As Integer = 0
    Dim newnum As Integer
    Dim newspinvalue As Integer
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        spinvalue = Int(Rnd() * 101 + 50)
        newspinvalue = Int(Rnd() * 101 + 50) Mod 25
        num += 1
        newnum += spinvalue
        If num = 0 Then
            PictureBox1.Image = My.Resources.wheel_1
            If newspinvalue = 0 Then
                Timer1.Enabled = False
            End If
        ElseIf num = 1 Then
            PictureBox1.Image = My.Resources.wheel_2
            If newspinvalue = 1 Then
                Timer1.Enabled = False
            End If
        ElseIf num = 2 Then
            PictureBox1.Image = My.Resources.wheel_3
            If newspinvalue = 2 Then
                Timer1.Enabled = False
            End If
        ElseIf num = 3 Then
            PictureBox1.Image = My.Resources.wheel_4
            If newspinvalue = 3 Then
                Timer1.Enabled = False
            End If
        ElseIf num = 4 Then
            PictureBox1.Image = My.Resources.wheel_5
            If newspinvalue = 4 Then
                Timer1.Enabled = False
            End If
        ElseIf num = 5 Then
            PictureBox1.Image = My.Resources.wheel_6
            If newspinvalue = 5 Then
                Timer1.Enabled = False
            End If
        ElseIf num = 6 Then
            PictureBox1.Image = My.Resources.wheel_7
            If newspinvalue = 6 Then
                Timer1.Enabled = False
            End If
        ElseIf num = 7 Then
            PictureBox1.Image = My.Resources.wheel_8
            If newspinvalue = 7 Then
                Timer1.Enabled = False
            End If
        ElseIf num = 8 Then
            PictureBox1.Image = My.Resources.wheel_9
            If newspinvalue = 8 Then
                Timer1.Enabled = False
            End If
        ElseIf num = 9 Then
            PictureBox1.Image = My.Resources.wheel_10
            If newspinvalue = 9 Then
                Timer1.Enabled = False
            End If
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
        Dim newpsinspeed As Integer = 10
        For newspinspeed As Integer = 100 To newspinspeed
            Timer1.Interval += newspinspeed
        Next


        Dim randnum As Integer
        Dim randnum2 As New Random
        randnum += 1
        randnum2.Next(0, 26)


    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        Timer1.Enabled = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
