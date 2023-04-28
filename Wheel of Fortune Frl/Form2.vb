Imports System.Runtime.InteropServices.WindowsRuntime

Public Class Form2Wheel
    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim spinvalue As Integer
        Dim imageNum As Integer

        spinvalue = Int(Rnd() * 101 + 50)

        For intvalue As Integer = 0 To spinvalue
            imageNum = intvalue Mod 25
        Next
        If spinvalue = 0 Then
            pic1Start.Visible = True
        ElseIf spinvalue = 1 Then
            pic2.Visible = True
        End If

    End Sub

    Private Sub Form2Wheel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class