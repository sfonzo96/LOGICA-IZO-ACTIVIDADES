Public Class FrmSurfaceCalculator

    Private Sub BtnCalculateSurface_Click(sender As Object, e As EventArgs) Handles BtnCalculateSurface.Click
        TxtSurface.Text = CDec(TxtWidth.Text) * CDec(TxtLength.Text)
    End Sub
End Class