Public Class FrmExchange
    Private usdValue As Decimal
    Private arsQuantity As Decimal
    Private usdQuantity As Decimal

    Private Sub FrmCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetExchangeRate()
    End Sub

    Private Sub BtnCalculateArsQuantity_Click(sender As Object, e As EventArgs) Handles BtnCalculateArsQuantity.Click
        Try
            usdQuantity = CDec(TxtUsdQuantity.Text)
            arsQuantity = usdValue * usdQuantity
            TxtArsQuantity.Text = arsQuantity

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnUpdateUsdValue_Click(sender As Object, e As EventArgs) Handles BtnUpdateUsdValue.Click
        SetExchangeRate()
    End Sub
    Private Sub SetExchangeRate()
        usdValue = CDec(InputBox("Ingresa la cotización del día:"))
        TxtUsdValue.Text = usdValue
    End Sub

    Private Sub BtnShowRecord_Click(sender As Object, e As EventArgs) Handles BtnShowRecord.Click
        Dim frmRecord As New FrmRecord()

        frmRecord.ShowDialog()

    End Sub

    Private Sub BtnConfirmOperation_Click(sender As Object, e As EventArgs) Handles BtnConfirmOperation.Click
        Try
            'Aplicar FACTORY
            Dim success As Boolean = DbExchangeService.AddOperation(usdValue, usdQuantity, arsQuantity)
            'Dim success As Boolean = FsExchangeService.AddOperation(usdValue, usdQuantity, arsQuantity)
            If Not success Then
                Throw New Exception("Error al registrar operación")
            Else
                MessageBox.Show("Operación registrada con éxito")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class