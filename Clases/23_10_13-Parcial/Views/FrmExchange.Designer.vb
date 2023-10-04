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
        BtnCalculateArsQuantity = New Button()
        TxtUsdQuantity = New TextBox()
        LblUsdValue = New Label()
        TxtUsdValue = New TextBox()
        LblUsdQuantity = New Label()
        LblArsQuantity = New Label()
        TxtArsQuantity = New TextBox()
        BtnUpdateUsdValue = New Button()
        BtnShowRecord = New Button()
        BtnConfirmOperation = New Button()
        SuspendLayout()
        ' 
        ' BtnCalculateArsQuantity
        ' 
        BtnCalculateArsQuantity.Location = New Point(350, 237)
        BtnCalculateArsQuantity.Name = "BtnCalculateArsQuantity"
        BtnCalculateArsQuantity.Size = New Size(100, 40)
        BtnCalculateArsQuantity.TabIndex = 0
        BtnCalculateArsQuantity.Text = "Calcular pago"
        BtnCalculateArsQuantity.UseVisualStyleBackColor = True
        ' 
        ' TxtUsdQuantity
        ' 
        TxtUsdQuantity.Location = New Point(350, 196)
        TxtUsdQuantity.Name = "TxtUsdQuantity"
        TxtUsdQuantity.Size = New Size(100, 23)
        TxtUsdQuantity.TabIndex = 2
        ' 
        ' LblUsdValue
        ' 
        LblUsdValue.AutoSize = True
        LblUsdValue.Location = New Point(604, 39)
        LblUsdValue.Name = "LblUsdValue"
        LblUsdValue.Size = New Size(58, 15)
        LblUsdValue.TabIndex = 3
        LblUsdValue.Text = "Valor USD"
        ' 
        ' TxtUsdValue
        ' 
        TxtUsdValue.Location = New Point(678, 31)
        TxtUsdValue.Name = "TxtUsdValue"
        TxtUsdValue.ReadOnly = True
        TxtUsdValue.Size = New Size(100, 23)
        TxtUsdValue.TabIndex = 4
        TxtUsdValue.TabStop = False
        ' 
        ' LblUsdQuantity
        ' 
        LblUsdQuantity.AutoSize = True
        LblUsdQuantity.Location = New Point(264, 204)
        LblUsdQuantity.Name = "LblUsdQuantity"
        LblUsdQuantity.Size = New Size(80, 15)
        LblUsdQuantity.TabIndex = 5
        LblUsdQuantity.Text = "Cantidad USD"
        ' 
        ' LblArsQuantity
        ' 
        LblArsQuantity.AutoSize = True
        LblArsQuantity.Location = New Point(493, 204)
        LblArsQuantity.Name = "LblArsQuantity"
        LblArsQuantity.Size = New Size(70, 15)
        LblArsQuantity.TabIndex = 6
        LblArsQuantity.Text = "ARS a pagar"
        ' 
        ' TxtArsQuantity
        ' 
        TxtArsQuantity.Location = New Point(564, 196)
        TxtArsQuantity.Name = "TxtArsQuantity"
        TxtArsQuantity.ReadOnly = True
        TxtArsQuantity.Size = New Size(100, 23)
        TxtArsQuantity.TabIndex = 7
        ' 
        ' BtnUpdateUsdValue
        ' 
        BtnUpdateUsdValue.Location = New Point(690, 73)
        BtnUpdateUsdValue.Name = "BtnUpdateUsdValue"
        BtnUpdateUsdValue.Size = New Size(75, 23)
        BtnUpdateUsdValue.TabIndex = 8
        BtnUpdateUsdValue.Text = "Actualizar"
        BtnUpdateUsdValue.UseVisualStyleBackColor = True
        ' 
        ' BtnShowRecord
        ' 
        BtnShowRecord.Location = New Point(27, 73)
        BtnShowRecord.Name = "BtnShowRecord"
        BtnShowRecord.Size = New Size(96, 42)
        BtnShowRecord.TabIndex = 9
        BtnShowRecord.Text = "Ver historial"
        BtnShowRecord.UseVisualStyleBackColor = True
        ' 
        ' BtnConfirmOperation
        ' 
        BtnConfirmOperation.Location = New Point(350, 289)
        BtnConfirmOperation.Name = "BtnConfirmOperation"
        BtnConfirmOperation.Size = New Size(100, 40)
        BtnConfirmOperation.TabIndex = 10
        BtnConfirmOperation.Text = "Confirmar operación"
        BtnConfirmOperation.UseVisualStyleBackColor = True
        ' 
        ' FrmExchange
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnConfirmOperation)
        Controls.Add(BtnShowRecord)
        Controls.Add(BtnUpdateUsdValue)
        Controls.Add(TxtArsQuantity)
        Controls.Add(LblArsQuantity)
        Controls.Add(LblUsdQuantity)
        Controls.Add(TxtUsdValue)
        Controls.Add(LblUsdValue)
        Controls.Add(TxtUsdQuantity)
        Controls.Add(BtnCalculateArsQuantity)
        Name = "FrmExchange"
        Text = "FrmExchange"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnCalculateArsQuantity As Button
    Friend WithEvents TxtUsdQuantity As TextBox
    Friend WithEvents LblUsdValue As Label
    Friend WithEvents TxtUsdValue As TextBox
    Friend WithEvents LblUsdQuantity As Label
    Friend WithEvents LblArsQuantity As Label
    Friend WithEvents TxtArsQuantity As TextBox
    Friend WithEvents BtnUpdateUsdValue As Button
    Friend WithEvents BtnShowRecord As Button
    Friend WithEvents BtnConfirmOperation As Button
End Class
