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
        Me.BtnLotes = New System.Windows.Forms.Button()
        Me.BtnCambio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnLotes
        '
        Me.BtnLotes.Location = New System.Drawing.Point(106, 120)
        Me.BtnLotes.Name = "BtnLotes"
        Me.BtnLotes.Size = New System.Drawing.Size(115, 54)
        Me.BtnLotes.TabIndex = 0
        Me.BtnLotes.Text = "Superficie Lotes"
        Me.BtnLotes.UseVisualStyleBackColor = True
        '
        'BtnCambio
        '
        Me.BtnCambio.Location = New System.Drawing.Point(298, 120)
        Me.BtnCambio.Name = "BtnCambio"
        Me.BtnCambio.Size = New System.Drawing.Size(115, 54)
        Me.BtnCambio.TabIndex = 1
        Me.BtnCambio.Text = "Cotización Cambio"
        Me.BtnCambio.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 295)
        Me.Controls.Add(Me.BtnCambio)
        Me.Controls.Add(Me.BtnLotes)
        Me.Name = "FrmMain"
        Me.Text = "FrmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLotes As Button
    Friend WithEvents BtnCambio As Button
End Class
