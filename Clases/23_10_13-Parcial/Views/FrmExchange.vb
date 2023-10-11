Public Class FrmExchange
    Public Shared Property UsdValue As Decimal
    Private Sub FrmCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetExchangeRate()
        Dim frmNewOperation As New FrmNewOperation()
        SetPanel(frmNewOperation)
    End Sub

    Private Sub BtnUpdateUsdValue_Click(sender As Object, e As EventArgs) Handles BtnUpdateUsdValue.Click
        SetExchangeRate()
    End Sub

    Private Sub SetExchangeRate()
        'TODO API FOR DEFAULT VALUE!!!
        Dim inputValue As String
        Do
            inputValue = InputBox("Ingresa la cotización del día:", "Cotización USD")
            If String.IsNullOrWhiteSpace(inputValue) Then
                MessageBox.Show("Necesitas ingresar un valor para poder operar.")
                Continue Do
            End If
        Loop While Not IsNumeric(inputValue)

        UsdValue = CDec(inputValue)
        TxtUsdValue.Text = UsdValue
    End Sub

    Private Sub BtnShowRecord_Click(sender As Object, e As EventArgs) Handles BtnShowRecord.Click
        Dim frmRecords As New FrmOperations()
        SetPanel(frmRecords)
    End Sub

    Private Sub BtnNewOperation_Click(sender As Object, e As EventArgs) Handles BtnNewOperation.Click
        Dim frmNewOperation As New FrmNewOperation()
        SetPanel(frmNewOperation)
    End Sub

    Private Sub SetPanel(ByRef form As Form)
        PanelExchange.Controls.Clear()
        form.TopLevel = False
        form.Size = PanelExchange.Size
        form.Dock = DockStyle.Fill
        PanelExchange.Controls.Add(form)
        form.Show()
    End Sub
End Class