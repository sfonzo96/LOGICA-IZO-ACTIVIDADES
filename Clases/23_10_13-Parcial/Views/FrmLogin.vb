Public Class FrmLogin
    Private Username As String
    Private Password As String
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Username = TxtUsername.Text
        Password = TxtPassword.Text
        Login(Username, Password)
    End Sub
    Private Sub FrmLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress, BtnLogin.KeyPress, TxtUsername.KeyPress, TxtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Username = TxtUsername.Text
            Password = TxtPassword.Text
            Login(Username, Password)
            e.Handled = True
        End If
    End Sub
    Private Sub Login(username As String, password As String)

        Dim user As User = DbUserService.GetUser(username)

        If user.Username = username AndAlso user.Password = password Then
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