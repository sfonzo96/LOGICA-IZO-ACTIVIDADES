Imports System.Data.SqlClient

Public Class FrmNewOperation
    Private arsQuantity As Decimal
    Private usdQuantity As Decimal
    Private Sub BtnConfirmOperation_Click(sender As Object, e As EventArgs) Handles BtnConfirmOperation.Click
        Try
            Dim dbOperationsService As New DbOperationsDataService()
            Dim dbSuccess As Boolean = dbOperationsService.AddOperation(FrmExchange.UsdValue, usdQuantity, arsQuantity)
            Dim fsOperationsService As New FsOperationsDataService()
            Dim fsSuccess As Boolean = fsOperationsService.AddOperation(FrmExchange.UsdValue, usdQuantity, arsQuantity)
            If Not (dbSuccess AndAlso fsSuccess) Then
                Throw New Exception("Error al registrar operación")
            Else
                MessageBox.Show("Operación registrada con éxito")
            End If
            ClearForm()
        Catch sqlEx As SqlException
            MessageBox.Show("DB error", sqlEx.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnCalculateArsQuantity_Click(sender As Object, e As EventArgs) Handles BtnCalculateArsQuantity.Click
        Try
            usdQuantity = CDec(TxtUsdQuantity.Text)
            arsQuantity = FrmExchange.UsdValue * usdQuantity
            MessageBox.Show(FrmExchange.UsdValue)
            TxtArsQuantity.Text = arsQuantity
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ClearForm()
        TxtUsdQuantity.Clear()
        TxtUsdQuantity.Focus()
        TxtArsQuantity.Clear()
    End Sub

    Private Sub FrmNewOperation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class