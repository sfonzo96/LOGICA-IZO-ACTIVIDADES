Public Class FrmExchange
    Public Shared Property UsdValue As Decimal
    Private Property NewOperationIsAllowed As Boolean = False
    Private Sub BtnUpdateUsdRate_Click(sender As Object, e As EventArgs) Handles BtnUpdateUsdRate.Click
        SetUsdValueByPrompt()
    End Sub

    Private Sub BtnShowOperations_Click(sender As Object, e As EventArgs) Handles BtnShowOperations.Click
        Dim frmOperations As New FrmOperations()
        SetPanel(frmOperations)
    End Sub

    Private Sub BtnNewOperation_Click(sender As Object, e As EventArgs) Handles BtnNewOperation.Click
        Try
            If Not NewOperationIsAllowed Then
                SetUsdValueByPrompt()
            End If

            If NewOperationIsAllowed Then
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

    Private Sub ShowInputErrorMessage(inputValue As String)
        Try
            If Not IsNumeric(inputValue) AndAlso UsdValue.Equals(0) Then
                MessageBox.Show("Para acceder y registrar una nueva operación tenés que fijar un tipo de cambio válido.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf Not IsNumeric(inputValue) Then
                MessageBox.Show("El valor ingresado debe ser numérico y positivo. Intenta actualizarlo nuevamente.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf Decimal.Parse(inputValue) <= 0 Then
                MessageBox.Show("El valor ingresado debe ser positivo. Intenta actualizarlo nuevamente.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SetUsdValueByPrompt()
        Try
            Dim inputValue As String = InputBox("Ingresa la cotización del día:", "Cotización USD")

            If Not IsNumeric(inputValue) OrElse Decimal.Parse(inputValue) <= 0 Then
                ShowInputErrorMessage(inputValue)
                Return
            End If

            UsdValue = Decimal.Parse(inputValue.Replace(".", ","))
            TxtUsdValue.Text = UsdValue
            NewOperationIsAllowed = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NewOperationIsAllowed = False
        End Try
    End Sub
End Class