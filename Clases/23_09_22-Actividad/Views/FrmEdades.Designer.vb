<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEdades
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
        BtnVerifEdad = New Button()
        LblEdad = New Label()
        TxtEdad = New TextBox()
        TxtResult = New TextBox()
        SuspendLayout()
        ' 
        ' BtnVerifEdad
        ' 
        BtnVerifEdad.Location = New Point(263, 206)
        BtnVerifEdad.Name = "BtnVerifEdad"
        BtnVerifEdad.Size = New Size(113, 50)
        BtnVerifEdad.TabIndex = 0
        BtnVerifEdad.Text = "Verificar"
        BtnVerifEdad.UseVisualStyleBackColor = True
        ' 
        ' LblEdad
        ' 
        LblEdad.AutoSize = True
        LblEdad.Location = New Point(191, 159)
        LblEdad.Name = "LblEdad"
        LblEdad.Size = New Size(43, 20)
        LblEdad.TabIndex = 1
        LblEdad.Text = "Edad"
        ' 
        ' TxtEdad
        ' 
        TxtEdad.Location = New Point(257, 156)
        TxtEdad.Name = "TxtEdad"
        TxtEdad.Size = New Size(125, 27)
        TxtEdad.TabIndex = 2
        ' 
        ' TxtResult
        ' 
        TxtResult.BackColor = SystemColors.Info
        TxtResult.BorderStyle = BorderStyle.FixedSingle
        TxtResult.Location = New Point(407, 218)
        TxtResult.Name = "TxtResult"
        TxtResult.ReadOnly = True
        TxtResult.Size = New Size(125, 27)
        TxtResult.TabIndex = 3
        ' 
        ' FrmEdades
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(638, 411)
        Controls.Add(TxtResult)
        Controls.Add(TxtEdad)
        Controls.Add(LblEdad)
        Controls.Add(BtnVerifEdad)
        Name = "FrmEdades"
        Text = "FrmEdades"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnVerifEdad As Button
    Friend WithEvents LblEdad As Label
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents TxtResult As TextBox
End Class
