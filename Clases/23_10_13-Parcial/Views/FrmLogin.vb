Public Class FrmLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Login()
    End Sub
    Private Sub FrmLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress, BtnLogin.KeyPress, TxtUsername.KeyPress, TxtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Login()
            e.Handled = True
        End If
    End Sub
    Private Sub Login()
        ' Use DbUserService for authentication
        If TxtUsername.Text = "izo" AndAlso TxtPassword.Text = "Izo2023" Then
            Dim frmMain As New FrmMain()
            frmMain.Show()
            Close()
        Else
            MessageBox.Show("Credenciales incorrectas. Intenta nuevamente")
            TxtPassword.Clear()
            TxtUsername.Clear()
            TxtUsername.Focus()
        End If
    End Sub
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsername.Focus()
    End Sub
End Class