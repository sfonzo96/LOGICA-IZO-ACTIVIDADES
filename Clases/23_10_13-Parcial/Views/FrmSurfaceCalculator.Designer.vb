<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSurfaceCalculator
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
        LblWidth = New Label()
        LblLength = New Label()
        BtnCalculateSurface = New Button()
        TxtWidth = New TextBox()
        TxtLength = New TextBox()
        LblSurface = New Label()
        TxtSurface = New TextBox()
        LblSurfaceCalcTitle = New Label()
        SuspendLayout()
        ' 
        ' LblWidth
        ' 
        LblWidth.AutoSize = True
        LblWidth.Location = New Point(164, 181)
        LblWidth.Name = "LblWidth"
        LblWidth.Size = New Size(42, 15)
        LblWidth.TabIndex = 0
        LblWidth.Text = "Ancho"
        ' 
        ' LblLength
        ' 
        LblLength.AutoSize = True
        LblLength.Location = New Point(164, 239)
        LblLength.Name = "LblLength"
        LblLength.Size = New Size(37, 15)
        LblLength.TabIndex = 1
        LblLength.Text = "Largo"
        ' 
        ' BtnCalculateSurface
        ' 
        BtnCalculateSurface.Location = New Point(238, 280)
        BtnCalculateSurface.Name = "BtnCalculateSurface"
        BtnCalculateSurface.Size = New Size(116, 27)
        BtnCalculateSurface.TabIndex = 2
        BtnCalculateSurface.Text = "Calcular superficie"
        BtnCalculateSurface.UseVisualStyleBackColor = True
        ' 
        ' TxtWidth
        ' 
        TxtWidth.Location = New Point(246, 178)
        TxtWidth.Name = "TxtWidth"
        TxtWidth.Size = New Size(100, 23)
        TxtWidth.TabIndex = 0
        ' 
        ' TxtLength
        ' 
        TxtLength.Location = New Point(246, 236)
        TxtLength.Name = "TxtLength"
        TxtLength.Size = New Size(100, 23)
        TxtLength.TabIndex = 1
        ' 
        ' LblSurface
        ' 
        LblSurface.AutoSize = True
        LblSurface.Location = New Point(424, 234)
        LblSurface.Name = "LblSurface"
        LblSurface.Size = New Size(86, 15)
        LblSurface.TabIndex = 5
        LblSurface.Text = "Superficie total"
        ' 
        ' TxtSurface
        ' 
        TxtSurface.Enabled = False
        TxtSurface.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TxtSurface.Location = New Point(529, 231)
        TxtSurface.Name = "TxtSurface"
        TxtSurface.ReadOnly = True
        TxtSurface.Size = New Size(100, 23)
        TxtSurface.TabIndex = 6
        TxtSurface.TabStop = False
        ' 
        ' LblSurfaceCalcTitle
        ' 
        LblSurfaceCalcTitle.AutoSize = True
        LblSurfaceCalcTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        LblSurfaceCalcTitle.Location = New Point(265, 64)
        LblSurfaceCalcTitle.Name = "LblSurfaceCalcTitle"
        LblSurfaceCalcTitle.Size = New Size(228, 30)
        LblSurfaceCalcTitle.TabIndex = 24
        LblSurfaceCalcTitle.Text = "Calculo de superficie"
        ' 
        ' FrmSurfaceCalculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(175), CByte(179), CByte(183))
        ClientSize = New Size(792, 485)
        Controls.Add(LblSurfaceCalcTitle)
        Controls.Add(TxtSurface)
        Controls.Add(LblSurface)
        Controls.Add(TxtLength)
        Controls.Add(TxtWidth)
        Controls.Add(BtnCalculateSurface)
        Controls.Add(LblLength)
        Controls.Add(LblWidth)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmSurfaceCalculator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculadora de superficie"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblWidth As Label
    Friend WithEvents LblLength As Label
    Friend WithEvents BtnCalculateSurface As Button
    Friend WithEvents TxtWidth As TextBox
    Friend WithEvents TxtLength As TextBox
    Friend WithEvents LblSurface As Label
    Friend WithEvents TxtSurface As TextBox
    Friend WithEvents LblSurfaceCalcTitle As Label
End Class
