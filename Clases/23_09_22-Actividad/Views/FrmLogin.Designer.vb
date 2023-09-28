<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnLogin = New Button()
        LblUsername = New Label()
        LblPassword = New Label()
        TxtUsername = New TextBox()
        TxtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(195, 224)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(94, 29)
        BtnLogin.TabIndex = 0
        BtnLogin.Text = "Ingresar"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.Location = New Point(105, 97)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(59, 20)
        LblUsername.TabIndex = 1
        LblUsername.Text = "Usuario"
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.Location = New Point(90, 176)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(83, 20)
        LblPassword.TabIndex = 2
        LblPassword.Text = "Contraseña"
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Location = New Point(179, 94)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(125, 27)
        TxtUsername.TabIndex = 3
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(179, 169)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(125, 27)
        TxtPassword.TabIndex = 4
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 347)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUsername)
        Controls.Add(LblPassword)
        Controls.Add(LblUsername)
        Controls.Add(BtnLogin)
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox

End Class
