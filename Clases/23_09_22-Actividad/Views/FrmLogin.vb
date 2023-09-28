Public Class FrmLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If Me.TxtPassword.Text = "Izo2023" And Me.TxtUsername.Text = "izo" Then
            Dim frmMain As New FrmMain

            frmMain.Show()

            Me.Close()
        Else
            MessageBox.Show("Credenciales incorrectas. Intenta de nuevo")
        End If
    End Sub
End Class
