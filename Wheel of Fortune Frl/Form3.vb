Public Class frmExtra
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        frmMain.Visible = True
        Form2Wheel.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        frmMain.Visible = False
        Form2Wheel.Visible = True
    End Sub
End Class