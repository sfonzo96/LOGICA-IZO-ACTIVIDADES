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
        PanelMenu = New Panel()
        PicLogoIzo = New PictureBox()
        PanelControlBar = New Panel()
        BtnMinimizeForm = New Button()
        BtnCloseForm = New Button()
        PanelSubForms = New Panel()
        PanelMenu.SuspendLayout()
        CType(PicLogoIzo, ComponentModel.ISupportInitialize).BeginInit()
        PanelControlBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnSurfaceCalculator
        ' 
        BtnSurfaceCalculator.Anchor = AnchorStyles.None
        BtnSurfaceCalculator.Cursor = Cursors.Hand
        BtnSurfaceCalculator.FlatStyle = FlatStyle.System
        BtnSurfaceCalculator.Location = New Point(18, 190)
        BtnSurfaceCalculator.Name = "BtnSurfaceCalculator"
        BtnSurfaceCalculator.Size = New Size(105, 55)
        BtnSurfaceCalculator.TabIndex = 0
        BtnSurfaceCalculator.Text = "Calculadora de superficie"
        BtnSurfaceCalculator.UseVisualStyleBackColor = True
        ' 
        ' BtnExchange
        ' 
        BtnExchange.Anchor = AnchorStyles.None
        BtnExchange.AutoSize = True
        BtnExchange.Cursor = Cursors.Hand
        BtnExchange.FlatStyle = FlatStyle.System
        BtnExchange.Location = New Point(18, 126)
        BtnExchange.Name = "BtnExchange"
        BtnExchange.Size = New Size(105, 55)
        BtnExchange.TabIndex = 1
        BtnExchange.Text = "Casa de cambio"
        BtnExchange.UseVisualStyleBackColor = True
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(19), CByte(46), CByte(53))
        PanelMenu.Controls.Add(PicLogoIzo)
        PanelMenu.Controls.Add(BtnExchange)
        PanelMenu.Controls.Add(BtnSurfaceCalculator)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 31)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(141, 485)
        PanelMenu.TabIndex = 3
        ' 
        ' PicLogoIzo
        ' 
        PicLogoIzo.Image = My.Resources.Resources.izologo
        PicLogoIzo.Location = New Point(18, 10)
        PicLogoIzo.Name = "PicLogoIzo"
        PicLogoIzo.Size = New Size(105, 105)
        PicLogoIzo.SizeMode = PictureBoxSizeMode.Zoom
        PicLogoIzo.TabIndex = 2
        PicLogoIzo.TabStop = False
        ' 
        ' PanelControlBar
        ' 
        PanelControlBar.BackColor = Color.FromArgb(CByte(45), CByte(74), CByte(83))
        PanelControlBar.Controls.Add(BtnMinimizeForm)
        PanelControlBar.Controls.Add(BtnCloseForm)
        PanelControlBar.Dock = DockStyle.Top
        PanelControlBar.Location = New Point(0, 0)
        PanelControlBar.Name = "PanelControlBar"
        PanelControlBar.Size = New Size(933, 31)
        PanelControlBar.TabIndex = 4
        ' 
        ' BtnMinimizeForm
        ' 
        BtnMinimizeForm.BackColor = Color.FromArgb(CByte(45), CByte(74), CByte(83))
        BtnMinimizeForm.Dock = DockStyle.Right
        BtnMinimizeForm.FlatAppearance.BorderSize = 0
        BtnMinimizeForm.FlatStyle = FlatStyle.Flat
        BtnMinimizeForm.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMinimizeForm.ForeColor = Color.FromArgb(CByte(175), CByte(179), CByte(183))
        BtnMinimizeForm.Location = New Point(871, 0)
        BtnMinimizeForm.Name = "BtnMinimizeForm"
        BtnMinimizeForm.Size = New Size(31, 31)
        BtnMinimizeForm.TabIndex = 6
        BtnMinimizeForm.Text = "_"
        BtnMinimizeForm.UseVisualStyleBackColor = False
        ' 
        ' BtnCloseForm
        ' 
        BtnCloseForm.BackColor = Color.FromArgb(CByte(45), CByte(74), CByte(83))
        BtnCloseForm.Dock = DockStyle.Right
        BtnCloseForm.FlatAppearance.BorderSize = 0
        BtnCloseForm.FlatStyle = FlatStyle.Flat
        BtnCloseForm.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCloseForm.ForeColor = Color.FromArgb(CByte(175), CByte(179), CByte(183))
        BtnCloseForm.Location = New Point(902, 0)
        BtnCloseForm.Name = "BtnCloseForm"
        BtnCloseForm.Size = New Size(31, 31)
        BtnCloseForm.TabIndex = 5
        BtnCloseForm.Text = "X"
        BtnCloseForm.UseVisualStyleBackColor = False
        ' 
        ' PanelSubForms
        ' 
        PanelSubForms.Dock = DockStyle.Fill
        PanelSubForms.Location = New Point(141, 31)
        PanelSubForms.Name = "PanelSubForms"
        PanelSubForms.Size = New Size(792, 485)
        PanelSubForms.TabIndex = 5
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(175), CByte(179), CByte(183))
        ClientSize = New Size(933, 516)
        ControlBox = False
        Controls.Add(PanelSubForms)
        Controls.Add(PanelMenu)
        Controls.Add(PanelControlBar)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "FrmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Selección de programa"
        PanelMenu.ResumeLayout(False)
        PanelMenu.PerformLayout()
        CType(PicLogoIzo, ComponentModel.ISupportInitialize).EndInit()
        PanelControlBar.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnSurfaceCalculator As Button
    Friend WithEvents BtnExchange As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelControlBar As Panel
    Friend WithEvents PicLogoIzo As PictureBox
    Friend WithEvents BtnCloseForm As Button
    Friend WithEvents BtnMinimizeForm As Button
    Friend WithEvents PanelSubForms As Panel
End Class
