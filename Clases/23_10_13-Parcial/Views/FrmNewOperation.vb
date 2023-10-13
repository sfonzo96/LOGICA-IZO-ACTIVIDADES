Imports System.Data.SqlClient

Public Class FrmNewOperation
    Private ArsQuantity As Decimal
    Private UsdQuantity As Decimal
    Private Sub BtnConfirmOperation_Click(sender As Object, e As EventArgs) Handles BtnConfirmOperation.Click
        Try
            If (ArsQuantity = 0 OrElse UsdQuantity = 0 OrElse FrmExchange.UsdValue = 0) Then
                MessageBox.Show("Por favor revisa que ningún campo esté vacío.", "Estado de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim dbOperationsService As New DbOperationsDataService()
                Dim dbSuccess As Boolean = dbOperationsService.AddOperation(FrmExchange.UsdValue, UsdQuantity, ArsQuantity)
                Dim fsOperationsService As New FsOperationsDataService()
                Dim fsSuccess As Boolean = fsOperationsService.AddOperation(FrmExchange.UsdValue, UsdQuantity, ArsQuantity)

            If Not (dbSuccess AndAlso fsSuccess) Then
                MessageBox.Show("La operación no pudo ser registrada.", "Estado de registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Operación registrada con éxito.", "Estado de registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ArsQuantity = 0
                UsdQuantity = 0
            End If

            ClearForm()
        Catch sqlEx As SqlException
            MessageBox.Show(sqlEx.Message, "DB error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnCalculateArsQuantity_Click(sender As Object, e As EventArgs) Handles BtnCalculateArsQuantity.Click
        Try
            If Not IsNumeric(TxtUsdQuantity.Text) OrElse Decimal.Parse(TxtUsdQuantity.Text) <= 0 Then
                MessageBox.Show("El valor ingresado no es válido. Ingresa un valor numérico y positivo.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            UsdQuantity = Decimal.Parse(TxtUsdQuantity.Text.Replace(".", ","))
            ArsQuantity = FrmExchange.UsdValue * UsdQuantity
            TxtArsQuantity.Text = ArsQuantity
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ha ocurrido un error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ClearForm()
        TxtUsdQuantity.Clear()
        TxtUsdQuantity.Focus()
        TxtArsQuantity.Clear()
    End Sub
End Class