Public Class FrmLogin
    Private Sub BntLogin_Click(sender As Object, e As RoutedEventArgs) Handles bntLogin.Click
        If Me.PwbPassword.Password = "Izo2023" And Me.TxtUsername.Text = "izo" Then
            Dim frmMain As New FrmMain

            frmMain.Show()
            Me.Close()
        Else
            MessageBox.Show("Credenciales incorrectas. Intenta de nuevo")
        End If
    End Sub
End Class
