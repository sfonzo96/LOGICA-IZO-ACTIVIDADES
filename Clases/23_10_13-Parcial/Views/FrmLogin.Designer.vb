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
        Panel2 = New Panel()
        BtnMinimizeForm = New Button()
        BtnCloseForm = New Button()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(177, 200)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(75, 23)
        BtnLogin.TabIndex = 2
        BtnLogin.Text = "Ingresar"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.Location = New Point(91, 102)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(47, 15)
        LblUsername.TabIndex = 1
        LblUsername.Text = "Usuario"
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.Location = New Point(91, 153)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(67, 15)
        LblPassword.TabIndex = 2
        LblPassword.Text = "Contraseña"
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Location = New Point(164, 99)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(100, 23)
        TxtUsername.TabIndex = 0
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(164, 150)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(100, 23)
        TxtPassword.TabIndex = 1
        ' 
        ' LblLoginTitle
        ' 
        LblLoginTitle.AutoSize = True
        LblLoginTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        LblLoginTitle.Location = New Point(151, 45)
        LblLoginTitle.Name = "LblLoginTitle"
        LblLoginTitle.Size = New Size(127, 30)
        LblLoginTitle.TabIndex = 5
        LblLoginTitle.Text = "Parcial LED"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(45), CByte(74), CByte(83))
        Panel2.Controls.Add(BtnMinimizeForm)
        Panel2.Controls.Add(BtnCloseForm)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(429, 31)
        Panel2.TabIndex = 6
        ' 
        ' BtnMinimizeForm
        ' 
        BtnMinimizeForm.BackColor = Color.FromArgb(CByte(45), CByte(74), CByte(83))
        BtnMinimizeForm.Dock = DockStyle.Right
        BtnMinimizeForm.FlatAppearance.BorderSize = 0
        BtnMinimizeForm.FlatStyle = FlatStyle.Flat
        BtnMinimizeForm.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMinimizeForm.ForeColor = Color.FromArgb(CByte(175), CByte(179), CByte(183))
        BtnMinimizeForm.Location = New Point(367, 0)
        BtnMinimizeForm.Name = "BtnMinimizeForm"
        BtnMinimizeForm.Size = New Size(31, 31)
        BtnMinimizeForm.TabIndex = 6
        BtnMinimizeForm.TabStop = False
        BtnMinimizeForm.Text = "_"
        BtnMinimizeForm.UseVisualStyleBackColor = False
        ' 
        ' BtnCloseForm
        ' 
        BtnCloseForm.BackColor = Color.FromArgb(CByte(45), CByte(74), CByte(83))
        BtnCloseForm.Dock = DockStyle.Right
        BtnCloseForm.FlatAppearance.BorderSize = 0
        BtnCloseForm.FlatStyle = FlatStyle.Flat
        BtnCloseForm.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCloseForm.ForeColor = Color.FromArgb(CByte(175), CByte(179), CByte(183))
        BtnCloseForm.Location = New Point(398, 0)
        BtnCloseForm.Name = "BtnCloseForm"
        BtnCloseForm.Size = New Size(31, 31)
        BtnCloseForm.TabIndex = 5
        BtnCloseForm.TabStop = False
        BtnCloseForm.Text = "X"
        BtnCloseForm.UseVisualStyleBackColor = False
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(175), CByte(179), CByte(183))
        ClientSize = New Size(429, 269)
        Controls.Add(Panel2)
        Controls.Add(LblLoginTitle)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUsername)
        Controls.Add(LblPassword)
        Controls.Add(LblUsername)
        Controls.Add(BtnLogin)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmLogin"
        RightToLeft = RightToLeft.No
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ingreso"
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblLoginTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnMinimizeForm As Button
    Friend WithEvents BtnCloseForm As Button
End Class
