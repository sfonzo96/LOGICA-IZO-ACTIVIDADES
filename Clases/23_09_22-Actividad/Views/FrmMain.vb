Public Class FrmMain
    Private Sub BtnProg1_Click(sender As Object, e As EventArgs) Handles BtnProg1.Click
        Dim frmEdades As New FrmEdades

        frmEdades.ShowDialog()
    End Sub
End Class