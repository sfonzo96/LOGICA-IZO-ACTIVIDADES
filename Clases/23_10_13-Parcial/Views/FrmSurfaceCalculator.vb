Imports System.Globalization

Public Class FrmSurfaceCalculator
    Private Sub BtnCalculateSurface_Click(sender As Object, e As EventArgs) Handles BtnCalculateSurface.Click
        If Not IsNumeric(TxtWidth.Text) OrElse Not IsNumeric(TxtLength.Text) Then
            MessageBox.Show(MessageBox.Show("Alguno de los valores ingresados nos es válido.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error))
            Return
        End If

        TxtSurface.Text = Decimal.Parse(TxtWidth.Text.Replace(".", ",")) * Decimal.Parse(TxtLength.Text.Replace(".", ","))
    End Sub
End Class