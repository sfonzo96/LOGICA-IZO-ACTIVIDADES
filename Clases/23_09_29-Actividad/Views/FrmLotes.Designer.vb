<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLotes
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
        Me.TxtAncho = New System.Windows.Forms.TextBox()
        Me.TxtLargo = New System.Windows.Forms.TextBox()
        Me.BtnCalcSuperf = New System.Windows.Forms.Button()
        Me.LblAncho = New System.Windows.Forms.Label()
        Me.LblLargo = New System.Windows.Forms.Label()
        Me.TxtSuperficie = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtAncho
        '
        Me.TxtAncho.Location = New System.Drawing.Point(180, 86)
        Me.TxtAncho.Name = "TxtAncho"
        Me.TxtAncho.Size = New System.Drawing.Size(133, 20)
        Me.TxtAncho.TabIndex = 0
        '
        'TxtLargo
        '
        Me.TxtLargo.Location = New System.Drawing.Point(180, 130)
        Me.TxtLargo.Name = "TxtLargo"
        Me.TxtLargo.Size = New System.Drawing.Size(133, 20)
        Me.TxtLargo.TabIndex = 1
        '
        'BtnCalcSuperf
        '
        Me.BtnCalcSuperf.Location = New System.Drawing.Point(192, 181)
        Me.BtnCalcSuperf.Name = "BtnCalcSuperf"
        Me.BtnCalcSuperf.Size = New System.Drawing.Size(108, 32)
        Me.BtnCalcSuperf.TabIndex = 2
        Me.BtnCalcSuperf.Text = "Calcular superficie"
        Me.BtnCalcSuperf.UseVisualStyleBackColor = True
        '
        'LblAncho
        '
        Me.LblAncho.AutoSize = True
        Me.LblAncho.Location = New System.Drawing.Point(115, 90)
        Me.LblAncho.Name = "LblAncho"
        Me.LblAncho.Size = New System.Drawing.Size(38, 13)
        Me.LblAncho.TabIndex = 3
        Me.LblAncho.Text = "Ancho"
        '
        'LblLargo
        '
        Me.LblLargo.AutoSize = True
        Me.LblLargo.Location = New System.Drawing.Point(115, 134)
        Me.LblLargo.Name = "LblLargo"
        Me.LblLargo.Size = New System.Drawing.Size(34, 13)
        Me.LblLargo.TabIndex = 4
        Me.LblLargo.Text = "Largo"
        '
        'TxtSuperficie
        '
        Me.TxtSuperficie.Location = New System.Drawing.Point(196, 230)
        Me.TxtSuperficie.Name = "TxtSuperficie"
        Me.TxtSuperficie.ReadOnly = True
        Me.TxtSuperficie.Size = New System.Drawing.Size(100, 20)
        Me.TxtSuperficie.TabIndex = 5
        '
        'FrmLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 292)
        Me.Controls.Add(Me.TxtSuperficie)
        Me.Controls.Add(Me.LblLargo)
        Me.Controls.Add(Me.LblAncho)
        Me.Controls.Add(Me.BtnCalcSuperf)
        Me.Controls.Add(Me.TxtLargo)
        Me.Controls.Add(Me.TxtAncho)
        Me.Name = "FrmLotes"
        Me.Text = "FrmLotes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtAncho As TextBox
    Friend WithEvents TxtLargo As TextBox
    Friend WithEvents BtnCalcSuperf As Button
    Friend WithEvents LblAncho As Label
    Friend WithEvents LblLargo As Label
    Friend WithEvents TxtSuperficie As TextBox
End Class
