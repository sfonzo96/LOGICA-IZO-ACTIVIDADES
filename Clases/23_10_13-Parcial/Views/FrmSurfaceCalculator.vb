Imports System.Globalization

Public Class FrmSurfaceCalculator
    Private Sub BtnCalculateSurface_Click(sender As Object, e As EventArgs) Handles BtnCalculateSurface.Click
        Try
            If Not IsNumeric(TxtWidth.Text) OrElse Not IsNumeric(TxtLength.Text) Then
                MessageBox.Show(MessageBox.Show("Alguno de los valores ingresados nos es válido.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning))
                Return
            End If

            TxtSurface.Text = Decimal.Parse(TxtWidth.Text.Replace(".", ",")) * Decimal.Parse(TxtLength.Text.Replace(".", ","))
        Catch ex As Exception
            MessageBox.Show("Algo no está bien, revisa que los valores sean correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class