Public Class FrmMain
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub BtnSurfaceCalculator_Click(sender As Object, e As EventArgs) Handles BtnSurfaceCalculator.Click
        Dim frmSurfaceCalculator As New FrmSurfaceCalculator

        frmSurfaceCalculator.ShowDialog()
    End Sub

    Private Sub BtnExchange_Click(sender As Object, e As EventArgs) Handles BtnExchange.Click
        Dim frmExchange As New FrmExchange

        frmExchange.ShowDialog()
    End Sub
End Class