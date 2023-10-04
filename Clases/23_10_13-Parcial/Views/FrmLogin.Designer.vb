<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnLogin = New Button()
        LblUsername = New Label()
        LblPassword = New Label()
        TxtUsername = New TextBox()
        TxtPassword = New TextBox()
        LblLoginTitle = New Label()
        SuspendLayout()
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(177, 177)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(75, 23)
        BtnLogin.TabIndex = 0
        BtnLogin.Text = "Ingresar"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.Location = New Point(89, 84)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(47, 15)
        LblUsername.TabIndex = 1
        LblUsername.Text = "Usuario"
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.Location = New Point(89, 135)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(67, 15)
        LblPassword.TabIndex = 2
        LblPassword.Text = "Contraseña"
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Location = New Point(164, 76)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(100, 23)
        TxtUsername.TabIndex = 3
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(164, 127)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(100, 23)
        TxtPassword.TabIndex = 4
        ' 
        ' LblLoginTitle
        ' 
        LblLoginTitle.AutoSize = True
        LblLoginTitle.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        LblLoginTitle.Location = New Point(162, 26)
        LblLoginTitle.Name = "LblLoginTitle"
        LblLoginTitle.Size = New Size(105, 25)
        LblLoginTitle.TabIndex = 5
        LblLoginTitle.Text = "Parcial LED"
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(429, 269)
        Controls.Add(LblLoginTitle)
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
    Friend WithEvents LblLoginTitle As Label
End Class
