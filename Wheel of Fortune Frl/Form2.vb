Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Runtime.Remoting.Metadata.W3cXsd2001

Public Class Form2Wheel
    Dim spinvalue As Integer
    Dim randNum As Decimal
    Dim num As Integer
    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        Timer1.Enabled = True
        randNum = Int((Rnd() * 101) + 50)
        btnSpin.Text = randNum
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        spinvalue += 1

    End Sub

    Private Sub Form2Wheel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class