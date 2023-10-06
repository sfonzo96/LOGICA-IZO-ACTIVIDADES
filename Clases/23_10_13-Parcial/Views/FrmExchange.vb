Imports System.Data.SqlClient

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
            Dim dbOperationsService As New DbOperationsService()
            Dim success As Boolean = dbOperationsService.AddOperation(usdValue, usdQuantity, arsQuantity)
            'Dim fsOperationsService As New FsOperationsService()
            'Dim success As Boolean = fsOperationsService.AddOperation(usdValue, usdQuantity, arsQuantity)
            If Not success Then
                Throw New Exception("Error al registrar operación")
            Else
                MessageBox.Show("Operación registrada con éxito")
            End If
        Catch sqlEx As SqlException
            MessageBox.Show("DB error", sqlEx.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class