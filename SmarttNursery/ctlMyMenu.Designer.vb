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
        Dim MetroSplitButtonRenderer1 As Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer = New Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer()
        Dim MetroSplitButtonRenderer2 As Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer = New Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyMenu))
        Me.pnlMenu = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.btnSave = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.sbtnAttachments = New Syncfusion.Windows.Forms.Tools.SplitButton()
        Me.sbtnNotes = New Syncfusion.Windows.Forms.Tools.SplitButton()
        Me.ToolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.tsbSaveClose = New System.Windows.Forms.ToolStripButton()
        Me.tsbNotes = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsAddNote = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbAttachments = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsAttachment = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbSaveNew = New System.Windows.Forms.ToolStripButton()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.pnlMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.ToolStripEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlMenu.Controls.Add(Me.ToolStripEx1)
        Me.pnlMenu.Controls.Add(Me.btnSave)
        Me.pnlMenu.Controls.Add(Me.sbtnAttachments)
        Me.pnlMenu.Controls.Add(Me.sbtnNotes)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(883, 42)
        Me.pnlMenu.TabIndex = 39
        '
        'btnSave
        '
        Me.btnSave.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSave.BeforeTouchSize = New System.Drawing.Size(29, 23)
        Me.btnSave.FlatAppearance.BorderSize = 0
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
        Me.sbtnAttachments.Font = New System.Drawing.Font("Segoe UI", 10.0!)
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
        Me.sbtnAttachments.Tag = "Attachments"
        Me.sbtnAttachments.Text = "Attachments"
        '
        'sbtnNotes
        '
        Me.sbtnNotes.BackColor = System.Drawing.Color.DimGray
        Me.sbtnNotes.BeforeTouchSize = New System.Drawing.Size(100, 23)
        Me.sbtnNotes.DropDownIconColor = System.Drawing.Color.White
        Me.sbtnNotes.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom
        Me.sbtnNotes.Font = New System.Drawing.Font("Segoe UI", 10.0!)
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
        Me.sbtnNotes.Tag = "Notes"
        Me.sbtnNotes.Text = "Notes"
        '
        'ToolStripEx1
        '
        Me.ToolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx1.Image = Nothing
        Me.ToolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSaveClose, Me.tsbSaveNew, Me.tsbNotes, Me.tsbAttachments, Me.HelpToolStripButton})
        Me.ToolStripEx1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripEx1.Name = "ToolStripEx1"
        Me.ToolStripEx1.Office12Mode = False
        Me.ToolStripEx1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStripEx1.Size = New System.Drawing.Size(883, 25)
        Me.ToolStripEx1.TabIndex = 3
        Me.ToolStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Metro
        '
        'tsbSaveClose
        '
        Me.tsbSaveClose.BackColor = System.Drawing.Color.DimGray
        Me.tsbSaveClose.ForeColor = System.Drawing.Color.White
        Me.tsbSaveClose.Image = CType(resources.GetObject("tsbSaveClose.Image"), System.Drawing.Image)
        Me.tsbSaveClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSaveClose.Name = "tsbSaveClose"
        Me.tsbSaveClose.Size = New System.Drawing.Size(106, 22)
        Me.tsbSaveClose.Text = "Save and Close"
        '
        'tsbNotes
        '
        Me.tsbNotes.BackColor = System.Drawing.Color.DimGray
        Me.tsbNotes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbNotes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAddNote})
        Me.tsbNotes.ForeColor = System.Drawing.Color.White
        Me.tsbNotes.Image = CType(resources.GetObject("tsbNotes.Image"), System.Drawing.Image)
        Me.tsbNotes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNotes.Name = "tsbNotes"
        Me.tsbNotes.ShowDropDownArrow = False
        Me.tsbNotes.Size = New System.Drawing.Size(42, 22)
        Me.tsbNotes.Text = "Notes"
        '
        'tsAddNote
        '
        Me.tsAddNote.Name = "tsAddNote"
        Me.tsAddNote.Size = New System.Drawing.Size(125, 22)
        Me.tsAddNote.Text = "Add Note"
        '
        'tsbAttachments
        '
        Me.tsbAttachments.BackColor = System.Drawing.Color.DimGray
        Me.tsbAttachments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAttachments.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAttachment})
        Me.tsbAttachments.ForeColor = System.Drawing.Color.White
        Me.tsbAttachments.Image = CType(resources.GetObject("tsbAttachments.Image"), System.Drawing.Image)
        Me.tsbAttachments.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAttachments.Name = "tsbAttachments"
        Me.tsbAttachments.ShowDropDownArrow = False
        Me.tsbAttachments.Size = New System.Drawing.Size(79, 22)
        Me.tsbAttachments.Text = "Attachments"
        '
        'tsAttachment
        '
        Me.tsAttachment.Name = "tsAttachment"
        Me.tsAttachment.Size = New System.Drawing.Size(162, 22)
        Me.tsAttachment.Text = "Add Attachment"
        '
        'tsbSaveNew
        '
        Me.tsbSaveNew.BackColor = System.Drawing.Color.DimGray
        Me.tsbSaveNew.ForeColor = System.Drawing.Color.White
        Me.tsbSaveNew.Image = CType(resources.GetObject("tsbSaveNew.Image"), System.Drawing.Image)
        Me.tsbSaveNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSaveNew.Name = "tsbSaveNew"
        Me.tsbSaveNew.Size = New System.Drawing.Size(101, 22)
        Me.tsbSaveNew.Text = "Save and New"
        Me.tsbSaveNew.ToolTipText = "Save and add a new $"
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'MyMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pnlMenu)
        Me.Name = "MyMenu"
        Me.Size = New System.Drawing.Size(883, 42)
        CType(Me.pnlMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.ToolStripEx1.ResumeLayout(False)
        Me.ToolStripEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents btnSave As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents sbtnAttachments As Syncfusion.Windows.Forms.Tools.SplitButton
    Friend WithEvents sbtnNotes As Syncfusion.Windows.Forms.Tools.SplitButton
    Friend WithEvents ToolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents tsbSaveClose As ToolStripButton
    Friend WithEvents tsbSaveNew As ToolStripButton
    Friend WithEvents tsbNotes As ToolStripDropDownButton
    Friend WithEvents tsAddNote As ToolStripMenuItem
    Friend WithEvents tsbAttachments As ToolStripDropDownButton
    Friend WithEvents tsAttachment As ToolStripMenuItem
    Friend WithEvents HelpToolStripButton As ToolStripButton
End Class
