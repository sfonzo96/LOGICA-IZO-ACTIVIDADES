<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExchange
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
        LblUsdValue = New Label()
        TxtUsdValue = New TextBox()
        BtnUpdateUsdValue = New Button()
        BtnShowOperations = New Button()
        BtnNewOperation = New Button()
        PanelExchange = New Panel()
        SuspendLayout()
        ' 
        ' LblUsdValue
        ' 
        LblUsdValue.AutoSize = True
        LblUsdValue.Location = New Point(523, 26)
        LblUsdValue.Name = "LblUsdValue"
        LblUsdValue.Size = New Size(61, 15)
        LblUsdValue.TabIndex = 3
        LblUsdValue.Text = "Valor USD:"
        ' 
        ' TxtUsdValue
        ' 
        TxtUsdValue.Enabled = False
        TxtUsdValue.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TxtUsdValue.Location = New Point(590, 22)
        TxtUsdValue.Name = "TxtUsdValue"
        TxtUsdValue.ReadOnly = True
        TxtUsdValue.Size = New Size(100, 23)
        TxtUsdValue.TabIndex = 4
        TxtUsdValue.TabStop = False
        ' 
        ' BtnUpdateUsdValue
        ' 
        BtnUpdateUsdValue.Location = New Point(696, 22)
        BtnUpdateUsdValue.Name = "BtnUpdateUsdValue"
        BtnUpdateUsdValue.Size = New Size(75, 23)
        BtnUpdateUsdValue.TabIndex = 2
        BtnUpdateUsdValue.Text = "Actualizar"
        BtnUpdateUsdValue.UseVisualStyleBackColor = True
        ' 
        ' BtnShowOperations
        ' 
        BtnShowOperations.AutoSize = True
        BtnShowOperations.Location = New Point(27, 12)
        BtnShowOperations.Name = "BtnShowOperations"
        BtnShowOperations.Size = New Size(96, 42)
        BtnShowOperations.TabIndex = 0
        BtnShowOperations.Text = "Ver historial"
        BtnShowOperations.UseVisualStyleBackColor = True
        ' 
        ' BtnNewOperation
        ' 
        BtnNewOperation.Location = New Point(129, 12)
        BtnNewOperation.Name = "BtnNewOperation"
        BtnNewOperation.Size = New Size(96, 42)
        BtnNewOperation.TabIndex = 1
        BtnNewOperation.Text = "Nueva operación"
        BtnNewOperation.UseVisualStyleBackColor = True
        ' 
        ' PanelExchange
        ' 
        PanelExchange.Anchor = AnchorStyles.Left
        PanelExchange.AutoSize = True
        PanelExchange.Location = New Point(24, 85)
        PanelExchange.Name = "PanelExchange"
        PanelExchange.Size = New Size(744, 370)
        PanelExchange.TabIndex = 12
        ' 
        ' FrmExchange
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(175), CByte(179), CByte(183))
        ClientSize = New Size(792, 485)
        ControlBox = False
        Controls.Add(PanelExchange)
        Controls.Add(BtnNewOperation)
        Controls.Add(BtnShowOperations)
        Controls.Add(BtnUpdateUsdValue)
        Controls.Add(TxtUsdValue)
        Controls.Add(LblUsdValue)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmExchange"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Casa de cambio"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LblUsdValue As Label
    Friend WithEvents TxtUsdValue As TextBox
    Friend WithEvents BtnUpdateUsdValue As Button
    Friend WithEvents BtnShowOperations As Button
    Friend WithEvents BtnNewOperation As Button
    Friend WithEvents PanelExchange As Panel
End Class
