Public Class FrmSurfaceCalculator

    Private Sub BtnCalculateSurface_Click(sender As Object, e As EventArgs) Handles BtnCalculateSurface.Click
        If Not IsNumeric(TxtWidth.Text) OrElse Not IsNumeric(TxtLength.Text) Then
            MessageBox.Show(MessageBox.Show("Alguno de los valores ingresados nos es válido.", "Entrada invalida", MessageBoxButtons.OK, MessageBoxIcon.Error))
            Return
        End If

        TxtSurface.Text = CDec(TxtWidth.Text) * CDec(TxtLength.Text)
    End Sub
End Class