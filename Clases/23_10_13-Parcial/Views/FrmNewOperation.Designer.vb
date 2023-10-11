<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewOperation
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
        BtnConfirmOperation = New Button()
        TxtArsQuantity = New TextBox()
        LblArsQuantity = New Label()
        LblUsdQuantity = New Label()
        TxtUsdQuantity = New TextBox()
        BtnCalculateArsQuantity = New Button()
        SuspendLayout()
        ' 
        ' BtnConfirmOperation
        ' 
        BtnConfirmOperation.Anchor = AnchorStyles.None
        BtnConfirmOperation.Location = New Point(378, 173)
        BtnConfirmOperation.Name = "BtnConfirmOperation"
        BtnConfirmOperation.Size = New Size(100, 40)
        BtnConfirmOperation.TabIndex = 22
        BtnConfirmOperation.Text = "Confirmar operación"
        BtnConfirmOperation.UseVisualStyleBackColor = True
        ' 
        ' TxtArsQuantity
        ' 
        TxtArsQuantity.Anchor = AnchorStyles.None
        TxtArsQuantity.Location = New Point(378, 132)
        TxtArsQuantity.Name = "TxtArsQuantity"
        TxtArsQuantity.ReadOnly = True
        TxtArsQuantity.Size = New Size(100, 23)
        TxtArsQuantity.TabIndex = 21
        ' 
        ' LblArsQuantity
        ' 
        LblArsQuantity.Anchor = AnchorStyles.None
        LblArsQuantity.AutoSize = True
        LblArsQuantity.Location = New Point(302, 135)
        LblArsQuantity.Name = "LblArsQuantity"
        LblArsQuantity.Size = New Size(70, 15)
        LblArsQuantity.TabIndex = 20
        LblArsQuantity.Text = "ARS a pagar"
        ' 
        ' LblUsdQuantity
        ' 
        LblUsdQuantity.Anchor = AnchorStyles.None
        LblUsdQuantity.AutoSize = True
        LblUsdQuantity.Location = New Point(78, 135)
        LblUsdQuantity.Name = "LblUsdQuantity"
        LblUsdQuantity.Size = New Size(80, 15)
        LblUsdQuantity.TabIndex = 19
        LblUsdQuantity.Text = "Cantidad USD"
        ' 
        ' TxtUsdQuantity
        ' 
        TxtUsdQuantity.Anchor = AnchorStyles.None
        TxtUsdQuantity.Location = New Point(164, 132)
        TxtUsdQuantity.Name = "TxtUsdQuantity"
        TxtUsdQuantity.Size = New Size(100, 23)
        TxtUsdQuantity.TabIndex = 18
        ' 
        ' BtnCalculateArsQuantity
        ' 
        BtnCalculateArsQuantity.Anchor = AnchorStyles.None
        BtnCalculateArsQuantity.Location = New Point(164, 173)
        BtnCalculateArsQuantity.Name = "BtnCalculateArsQuantity"
        BtnCalculateArsQuantity.Size = New Size(100, 40)
        BtnCalculateArsQuantity.TabIndex = 17
        BtnCalculateArsQuantity.Text = "Calcular pago"
        BtnCalculateArsQuantity.UseVisualStyleBackColor = True
        ' 
        ' FrmNewOperation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.FromArgb(CByte(175), CByte(179), CByte(183))
        ClientSize = New Size(642, 347)
        Controls.Add(BtnConfirmOperation)
        Controls.Add(TxtArsQuantity)
        Controls.Add(LblArsQuantity)
        Controls.Add(LblUsdQuantity)
        Controls.Add(TxtUsdQuantity)
        Controls.Add(BtnCalculateArsQuantity)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "FrmNewOperation"
        Text = "FrmNewOperation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnConfirmOperation As Button
    Friend WithEvents TxtArsQuantity As TextBox
    Friend WithEvents LblArsQuantity As Label
    Friend WithEvents LblUsdQuantity As Label
    Friend WithEvents TxtUsdQuantity As TextBox
    Friend WithEvents BtnCalculateArsQuantity As Button
End Class
