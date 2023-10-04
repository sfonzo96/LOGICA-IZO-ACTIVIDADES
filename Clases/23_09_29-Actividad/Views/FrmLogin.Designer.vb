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
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(185, 181)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 0
        Me.BtnLogin.Text = "Ingresar"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(109, 90)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(43, 13)
        Me.LblUsername.TabIndex = 1
        Me.LblUsername.Text = "Usuario"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(109, 140)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(61, 13)
        Me.LblPassword.TabIndex = 2
        Me.LblPassword.Text = "Contraseña"
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(173, 86)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(100, 20)
        Me.TxtUsername.TabIndex = 3
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(173, 136)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(100, 20)
        Me.TxtPassword.TabIndex = 4
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 263)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.BtnLogin)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
End Class
