<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyMenu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyMenu))
        Dim MetroSplitButtonRenderer1 As Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer = New Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer()
        Dim MetroSplitButtonRenderer2 As Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer = New Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer()
        Me.pnlMenu = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.btnSave = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.sbtnAttachments = New Syncfusion.Windows.Forms.Tools.SplitButton()
        Me.sbtnNotes = New Syncfusion.Windows.Forms.Tools.SplitButton()
        CType(Me.pnlMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlMenu.Controls.Add(Me.btnSave)
        Me.pnlMenu.Controls.Add(Me.sbtnAttachments)
        Me.pnlMenu.Controls.Add(Me.sbtnNotes)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(883, 29)
        Me.pnlMenu.TabIndex = 39
        '
        'btnSave
        '
        Me.btnSave.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSave.BeforeTouchSize = New System.Drawing.Size(29, 23)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.IsBackStageButton = False
        Me.btnSave.Location = New System.Drawing.Point(0, 2)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(29, 23)
        Me.btnSave.TabIndex = 2
        '
        'sbtnAttachments
        '
        Me.sbtnAttachments.BackColor = System.Drawing.Color.DimGray
        Me.sbtnAttachments.BeforeTouchSize = New System.Drawing.Size(117, 23)
        Me.sbtnAttachments.DropDownIconColor = System.Drawing.Color.White
        Me.sbtnAttachments.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom
        Me.sbtnAttachments.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbtnAttachments.ForeColor = System.Drawing.Color.White
        Me.sbtnAttachments.Location = New System.Drawing.Point(145, 2)
        Me.sbtnAttachments.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sbtnAttachments.MinimumSize = New System.Drawing.Size(100, 23)
        Me.sbtnAttachments.Name = "sbtnAttachments"
        MetroSplitButtonRenderer1.SplitButton = Nothing
        Me.sbtnAttachments.Renderer = MetroSplitButtonRenderer1
        Me.sbtnAttachments.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.sbtnAttachments.ShowDropDownOnButtonClick = False
        Me.sbtnAttachments.Size = New System.Drawing.Size(117, 23)
        Me.sbtnAttachments.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro
        Me.sbtnAttachments.TabIndex = 1
        Me.sbtnAttachments.Text = "Attachments"
        '
        'sbtnNotes
        '
        Me.sbtnNotes.BackColor = System.Drawing.Color.DimGray
        Me.sbtnNotes.BeforeTouchSize = New System.Drawing.Size(100, 23)
        Me.sbtnNotes.DropDownIconColor = System.Drawing.Color.White
        Me.sbtnNotes.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom
        Me.sbtnNotes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbtnNotes.ForeColor = System.Drawing.Color.White
        Me.sbtnNotes.Location = New System.Drawing.Point(37, 2)
        Me.sbtnNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sbtnNotes.MinimumSize = New System.Drawing.Size(100, 23)
        Me.sbtnNotes.Name = "sbtnNotes"
        MetroSplitButtonRenderer2.SplitButton = Nothing
        Me.sbtnNotes.Renderer = MetroSplitButtonRenderer2
        Me.sbtnNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.sbtnNotes.ShowDropDownOnButtonClick = False
        Me.sbtnNotes.Size = New System.Drawing.Size(100, 23)
        Me.sbtnNotes.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro
        Me.sbtnNotes.TabIndex = 1
        Me.sbtnNotes.Text = "Notes"
        '
        'MyMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pnlMenu)
        Me.Name = "MyMenu"
        Me.Size = New System.Drawing.Size(883, 29)
        CType(Me.pnlMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents btnSave As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents sbtnAttachments As Syncfusion.Windows.Forms.Tools.SplitButton
    Friend WithEvents sbtnNotes As Syncfusion.Windows.Forms.Tools.SplitButton
End Class
