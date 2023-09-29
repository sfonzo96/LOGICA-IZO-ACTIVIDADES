Public Class FrmLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim frmMain As New FrmMain

        If TxtUsername.Text = "izo" AndAlso TxtPassword.Text = "Izo2023" Then
            frmMain.Show()
            Me.Close()
        Else
            MessageBox.Show("Credenciales incorrectas")
        End If

    End Sub
End Class