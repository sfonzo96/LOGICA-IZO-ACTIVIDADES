Public Class FrmMain
    Private Sub BtnLotes_Click(sender As Object, e As EventArgs) Handles BtnLotes.Click
        Dim frmLotes As New FrmLotes

        frmLotes.ShowDialog()
    End Sub

    Private Sub BtnCambio_Click(sender As Object, e As EventArgs) Handles BtnCambio.Click
        Dim frmCambio As New FrmCambio

        frmCambio.ShowDialog()
    End Sub
End Class