Public Class FrmMain
    Private Sub BtnSurfaceCalculator_Click(sender As Object, e As EventArgs) Handles BtnSurfaceCalculator.Click
        Dim frmSurfaceCalculator As New FrmSurfaceCalculator()
        SetPanel(frmSurfaceCalculator)
        SetWindowTitle("Calculo de superficies")
    End Sub
    Private Sub BtnExchange_Click(sender As Object, e As EventArgs) Handles BtnExchange.Click
        Dim frmExchange As New FrmExchange()
        SetPanel(frmExchange)
        SetWindowTitle("Casa de cambio")
    End Sub

    Private Sub BtnCloseForm_Click(sender As Object, e As EventArgs) Handles BtnCloseForm.Click
        Close()
    End Sub
    Private Sub BtnMinimizeForm_Click_1(sender As Object, e As EventArgs) Handles BtnMinimizeForm.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCloseForm_MouseEnter(sender As Object, e As EventArgs) Handles BtnCloseForm.MouseEnter
        BtnCloseForm.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub BtnCloseForm_MouseLeave(sender As Object, e As EventArgs) Handles BtnCloseForm.MouseLeave
        BtnCloseForm.ForeColor = ColorTranslator.FromHtml("#AFB3B7")
    End Sub

    Private Sub BtnMinimizeForm_MouseEnter(sender As Object, e As EventArgs) Handles BtnMinimizeForm.MouseEnter
        BtnMinimizeForm.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub BtnMinimizeForm_Click(sender As Object, e As EventArgs) Handles BtnMinimizeForm.MouseLeave
        BtnMinimizeForm.ForeColor = ColorTranslator.FromHtml("#AFB3B7")
    End Sub

    Private Sub SetPanel(ByRef form As Form)
        PanelSubForms.Controls.Clear()
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        PanelSubForms.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub SetWindowTitle(title As String)
        LblWindowTitle.Text = title
    End Sub
End Class