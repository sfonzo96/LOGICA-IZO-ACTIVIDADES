<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambio
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
        Me.TxtCotizacion = New System.Windows.Forms.TextBox()
        Me.LblCotizacion = New System.Windows.Forms.Label()
        Me.BtnCalcularCot = New System.Windows.Forms.Button()
        Me.TxtCantidadUsd = New System.Windows.Forms.TextBox()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.LblCantidadUSD = New System.Windows.Forms.Label()
        Me.TxtPago = New System.Windows.Forms.TextBox()
        Me.LblPago = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtCotizacion
        '
        Me.TxtCotizacion.Enabled = False
        Me.TxtCotizacion.Location = New System.Drawing.Point(283, 107)
        Me.TxtCotizacion.Name = "TxtCotizacion"
        Me.TxtCotizacion.ReadOnly = True
        Me.TxtCotizacion.Size = New System.Drawing.Size(100, 20)
        Me.TxtCotizacion.TabIndex = 0
        Me.TxtCotizacion.TabStop = False
        '
        'LblCotizacion
        '
        Me.LblCotizacion.AutoSize = True
        Me.LblCotizacion.Location = New System.Drawing.Point(190, 111)
        Me.LblCotizacion.Name = "LblCotizacion"
        Me.LblCotizacion.Size = New System.Drawing.Size(78, 13)
        Me.LblCotizacion.TabIndex = 1
        Me.LblCotizacion.Text = "Cotización día:"
        '
        'BtnCalcularCot
        '
        Me.BtnCalcularCot.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnCalcularCot.Location = New System.Drawing.Point(290, 245)
        Me.BtnCalcularCot.Name = "BtnCalcularCot"
        Me.BtnCalcularCot.Size = New System.Drawing.Size(87, 38)
        Me.BtnCalcularCot.TabIndex = 2
        Me.BtnCalcularCot.Text = "Calcular total a pagar"
        Me.BtnCalcularCot.UseVisualStyleBackColor = True
        '
        'TxtCantidadUsd
        '
        Me.TxtCantidadUsd.Location = New System.Drawing.Point(283, 203)
        Me.TxtCantidadUsd.Name = "TxtCantidadUsd"
        Me.TxtCantidadUsd.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidadUsd.TabIndex = 3
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(389, 106)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(63, 23)
        Me.BtnActualizar.TabIndex = 4
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'LblCantidadUSD
        '
        Me.LblCantidadUSD.AutoSize = True
        Me.LblCantidadUSD.Location = New System.Drawing.Point(184, 206)
        Me.LblCantidadUSD.Name = "LblCantidadUSD"
        Me.LblCantidadUSD.Size = New System.Drawing.Size(93, 13)
        Me.LblCantidadUSD.TabIndex = 5
        Me.LblCantidadUSD.Text = "Cantidad de USD:"
        '
        'TxtPago
        '
        Me.TxtPago.Location = New System.Drawing.Point(283, 309)
        Me.TxtPago.Name = "TxtPago"
        Me.TxtPago.ReadOnly = True
        Me.TxtPago.Size = New System.Drawing.Size(100, 20)
        Me.TxtPago.TabIndex = 6
        '
        'LblPago
        '
        Me.LblPago.AutoSize = True
        Me.LblPago.Location = New System.Drawing.Point(206, 313)
        Me.LblPago.Name = "LblPago"
        Me.LblPago.Size = New System.Drawing.Size(47, 13)
        Me.LblPago.TabIndex = 7
        Me.LblPago.Text = "A pagar:"
        '
        'FrmCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 435)
        Me.Controls.Add(Me.LblPago)
        Me.Controls.Add(Me.TxtPago)
        Me.Controls.Add(Me.LblCantidadUSD)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.TxtCantidadUsd)
        Me.Controls.Add(Me.BtnCalcularCot)
        Me.Controls.Add(Me.LblCotizacion)
        Me.Controls.Add(Me.TxtCotizacion)
        Me.Name = "FrmCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCambio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCotizacion As TextBox
    Friend WithEvents LblCotizacion As Label
    Friend WithEvents BtnCalcularCot As Button
    Friend WithEvents TxtCantidadUsd As TextBox
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents LblCantidadUSD As Label
    Friend WithEvents TxtPago As TextBox
    Friend WithEvents LblPago As Label
End Class
