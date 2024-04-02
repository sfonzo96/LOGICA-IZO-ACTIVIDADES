Public Class FrmLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        login()
    End Sub

    Private Sub FrmLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress, BtnLogin.KeyPress, TxtUsername.KeyPress, TxtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            login()
            e.Handled = True
        End If
    End Sub

    Private Sub login()
        Dim frmMain As New FrmMain

        If TxtUsername.Text = "izo" AndAlso TxtPassword.Text = "Izo2023" Then
            frmMain.Show()
            Close()
        Else
            MessageBox.Show("Credenciales incorrectas")
            TxtPassword.Clear()
            TxtUsername.Clear()
        End If
    End Sub
End Class