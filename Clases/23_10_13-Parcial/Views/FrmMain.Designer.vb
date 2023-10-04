<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        BtnSurfaceCalculator = New Button()
        BtnExchange = New Button()
        SuspendLayout()
        ' 
        ' BtnSurfaceCalculator
        ' 
        BtnSurfaceCalculator.Location = New Point(470, 198)
        BtnSurfaceCalculator.Name = "BtnSurfaceCalculator"
        BtnSurfaceCalculator.Size = New Size(100, 55)
        BtnSurfaceCalculator.TabIndex = 0
        BtnSurfaceCalculator.Text = "Calculadora de superficie"
        BtnSurfaceCalculator.UseVisualStyleBackColor = True
        ' 
        ' BtnExchange
        ' 
        BtnExchange.Location = New Point(231, 198)
        BtnExchange.Name = "BtnExchange"
        BtnExchange.Size = New Size(100, 55)
        BtnExchange.TabIndex = 1
        BtnExchange.Text = "Casa de cambio"
        BtnExchange.UseVisualStyleBackColor = True
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnExchange)
        Controls.Add(BtnSurfaceCalculator)
        Name = "FrmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmMain"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnSurfaceCalculator As Button
    Friend WithEvents BtnExchange As Button
End Class
