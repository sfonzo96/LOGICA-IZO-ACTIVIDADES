<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOperations
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
        DGridOperations = New DataGridView()
        CType(DGridOperations, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGridOperations
        ' 
        DGridOperations.AllowUserToAddRows = False
        DGridOperations.AllowUserToDeleteRows = False
        DGridOperations.AllowUserToResizeColumns = False
        DGridOperations.AllowUserToResizeRows = False
        DGridOperations.Anchor = AnchorStyles.None
        DGridOperations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGridOperations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGridOperations.Location = New Point(0, 0)
        DGridOperations.Name = "DGridOperations"
        DGridOperations.ReadOnly = True
        DGridOperations.RowHeadersVisible = False
        DGridOperations.RowTemplate.Height = 25
        DGridOperations.ScrollBars = ScrollBars.Vertical
        DGridOperations.Size = New Size(642, 347)
        DGridOperations.TabIndex = 0
        DGridOperations.TabStop = False
        ' 
        ' FrmOperations
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.FromArgb(CByte(175), CByte(179), CByte(183))
        ClientSize = New Size(642, 347)
        Controls.Add(DGridOperations)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmOperations"
        Text = "FrmRecord"
        CType(DGridOperations, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DGridOperations As DataGridView
End Class
