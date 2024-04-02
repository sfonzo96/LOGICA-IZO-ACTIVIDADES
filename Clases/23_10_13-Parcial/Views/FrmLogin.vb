﻿Imports System.Data.SqlClient
Public Class FrmLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Login(TxtUsername.Text, TxtPassword.Text)
    End Sub
    Private Sub FrmLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress, BtnLogin.KeyPress, TxtUsername.KeyPress, TxtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Login(TxtUsername.Text, TxtPassword.Text)
            e.Handled = True
        End If
    End Sub
    Private Sub Login(username As String, password As String)
        Try
            Dim userService As IUsersService = DataAccessFactory.CreateUserDataService()

            Dim user As User = userService.GetUser(username)
            If user.Username = username AndAlso user.Password = password Then
                Dim frmMain As New FrmMain()
                frmMain.Show()
                Close()
            Else
                MessageBox.Show("El usuario y/o contraseña son incorrectos. Intenta nuevamente", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtPassword.Clear()
                TxtUsername.Clear()
                TxtUsername.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsername.Focus()
        DatabaseService.InitDatabase()
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
End Class