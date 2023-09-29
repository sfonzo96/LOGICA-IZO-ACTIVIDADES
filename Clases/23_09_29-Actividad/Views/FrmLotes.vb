Public Class FrmLotes
    Private Sub BtnCalcSuperf_Click(sender As Object, e As EventArgs) Handles BtnCalcSuperf.Click
        TxtSuperficie.Text = CDec(TxtAncho.Text) * CDec(TxtLargo.Text)
    End Sub
End Class