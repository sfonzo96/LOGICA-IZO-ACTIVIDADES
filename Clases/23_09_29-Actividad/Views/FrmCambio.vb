Public Class FrmCambio
    Private Shared Cotizacion As Decimal

    Private Sub FrmCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setCotizacion()
    End Sub

    Private Sub BtnCalcularCot_Click(sender As Object, e As EventArgs) Handles BtnCalcularCot.Click
        Dim cantidadUsd = CDec(TxtCantidadUsd.Text)
        Dim totalAPagar As Decimal = CDec(TxtCotizacion.Text) * cantidadUsd
        TxtPago.Text = totalAPagar

        HistorialTxtService.RegistrarPago(cantidadUsd, totalAPagar)
    End Sub

    Private Sub setCotizacion()
        Cotizacion = CDec(InputBox("Ingresa la cotización del día:"))
        TxtCotizacion.Text = Cotizacion
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        setCotizacion()
    End Sub
End Class