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
        SuspendLayout()
        ' 
        ' LblWidth
        ' 
        LblWidth.AutoSize = True
        LblWidth.Location = New Point(266, 124)
        LblWidth.Name = "LblWidth"
        LblWidth.Size = New Size(59, 15)
        LblWidth.TabIndex = 0
        LblWidth.Text = "Superficie"
        ' 
        ' LblLength
        ' 
        LblLength.AutoSize = True
        LblLength.Location = New Point(266, 205)
        LblLength.Name = "LblLength"
        LblLength.Size = New Size(59, 15)
        LblLength.TabIndex = 1
        LblLength.Text = "Superficie"
        ' 
        ' BtnCalculateSurface
        ' 
        BtnCalculateSurface.Location = New Point(342, 261)
        BtnCalculateSurface.Name = "BtnCalculateSurface"
        BtnCalculateSurface.Size = New Size(116, 27)
        BtnCalculateSurface.TabIndex = 2
        BtnCalculateSurface.Text = "Calcular superficie"
        BtnCalculateSurface.UseVisualStyleBackColor = True
        ' 
        ' TxtWidth
        ' 
        TxtWidth.Location = New Point(350, 116)
        TxtWidth.Name = "TxtWidth"
        TxtWidth.Size = New Size(100, 23)
        TxtWidth.TabIndex = 3
        ' 
        ' TxtLength
        ' 
        TxtLength.Location = New Point(350, 197)
        TxtLength.Name = "TxtLength"
        TxtLength.Size = New Size(100, 23)
        TxtLength.TabIndex = 4
        ' 
        ' LblSurface
        ' 
        LblSurface.AutoSize = True
        LblSurface.Location = New Point(266, 355)
        LblSurface.Name = "LblSurface"
        LblSurface.Size = New Size(59, 15)
        LblSurface.TabIndex = 5
        LblSurface.Text = "Superficie"
        ' 
        ' TxtSurface
        ' 
        TxtSurface.Location = New Point(350, 347)
        TxtSurface.Name = "TxtSurface"
        TxtSurface.ReadOnly = True
        TxtSurface.Size = New Size(100, 23)
        TxtSurface.TabIndex = 6
        ' 
        ' FrmSurfaceCalculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtSurface)
        Controls.Add(LblSurface)
        Controls.Add(TxtLength)
        Controls.Add(TxtWidth)
        Controls.Add(BtnCalculateSurface)
        Controls.Add(LblLength)
        Controls.Add(LblWidth)
        Name = "FrmSurfaceCalculator"
        Text = "FrmLandPlot"
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
End Class
