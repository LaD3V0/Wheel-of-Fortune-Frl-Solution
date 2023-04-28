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

    End Sub
End Class