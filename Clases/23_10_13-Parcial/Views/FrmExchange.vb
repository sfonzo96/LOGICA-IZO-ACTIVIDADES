﻿Public Class FrmExchange
    Public Shared Property UsdValue As Decimal
    Private Sub BtnUpdateUsdRate_Click(sender As Object, e As EventArgs) Handles BtnUpdateUsdRate.Click
        SetUsdValueByPrompt()
    End Sub

    Private Sub BtnShowOperations_Click(sender As Object, e As EventArgs)
        Dim frmOperations As New FrmOperations()
        SetPanel(frmOperations)
    End Sub

    Private Sub BtnNewOperation_Click(sender As Object, e As EventArgs) Handles BtnNewOperation.Click
        Try
            If SetUsdValueByPrompt() Then
                Dim frmNewOperation As New FrmNewOperation()
                SetPanel(frmNewOperation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetPanel(ByRef form As Form)
        PanelExchange.Controls.Clear()
        form.TopLevel = False
        form.Size = PanelExchange.Size
        form.Dock = DockStyle.Fill
        PanelExchange.Controls.Add(form)
        form.Show()
    End Sub

    Private Function ValueIsValid(inputValue As String) As Boolean
        Try

            If Not IsNumeric(inputValue) AndAlso UsdValue.Equals(0) Then
                MessageBox.Show("Para acceder y registrar una nueva operación tenés que fijar un tipo de cambio.")
                Return False
            ElseIf Not IsNumeric(inputValue) Then
                MessageBox.Show("El valor ingresado debe ser numérico. Intenta actualizarlo nuevamente.")
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Function SetUsdValueByPrompt() As Boolean
        Try
            Dim inputValue As String = InputBox("Ingresa la cotización del día:", "Cotización USD")

            If Not ValueIsValid(inputValue) Then
                Return False
            End If

            UsdValue = CDec(inputValue)
            TxtUsdValue.Text = UsdValue
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class