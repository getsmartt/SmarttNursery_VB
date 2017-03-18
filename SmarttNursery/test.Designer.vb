<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
    Inherits Syncfusion.Windows.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(test))
        Me.MainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
        Me.Bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.MainFrameBarManager1, "Save")
        Me.BarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
        Me.BarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
        Me.BarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
        Me.Bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.MainFrameBarManager1, "Notes and Attachments")
        Me.ParentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
        Me.ListBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem()
        Me.ParentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
        Me.ListBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem()
        CType(Me.MainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainFrameBarManager1
        '
        Me.MainFrameBarManager1.AutoScale = True
        Me.MainFrameBarManager1.BarPositionInfo = CType(resources.GetObject("MainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
        Me.MainFrameBarManager1.Bars.Add(Me.Bar1)
        Me.MainFrameBarManager1.Bars.Add(Me.Bar2)
        Me.MainFrameBarManager1.Categories.Add("Save")
        Me.MainFrameBarManager1.Categories.Add("Notes and Attachments")
        Me.MainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm"
        Me.MainFrameBarManager1.EnableMenuMerge = True
        Me.MainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainFrameBarManager1.Form = Me
        Me.MainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem1, Me.BarItem2, Me.BarItem3, Me.ListBarItem1, Me.ListBarItem2, Me.ParentBarItem1, Me.ParentBarItem2})
        Me.MainFrameBarManager1.MetroColor = System.Drawing.Color.DimGray
        Me.MainFrameBarManager1.ResetCustomization = False
        Me.MainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.MainFrameBarManager1.UseBackwardCompatiblity = False
        '
        'Bar1
        '
        Me.Bar1.AllowCustomizing = False
        Me.Bar1.AllowHiding = False
        Me.Bar1.AllowItemsReorderOnShrunk = False
        Me.Bar1.AllowResizing = False
        Me.Bar1.BarName = "Save"
        Me.Bar1.BarStyle = Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible
        Me.Bar1.Caption = "Save"
        Me.Bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem1, Me.BarItem2, Me.BarItem3})
        Me.Bar1.Manager = Me.MainFrameBarManager1
        '
        'BarItem1
        '
        Me.BarItem1.BarName = "BarItem1"
        Me.BarItem1.CategoryIndex = 0
        Me.BarItem1.ID = "Save"
        Me.BarItem1.Image = CType(resources.GetObject("BarItem1.Image"), Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)
        Me.BarItem1.ImageSize = New System.Drawing.Size(24, 24)
        Me.BarItem1.ShowToolTipInPopUp = False
        Me.BarItem1.SizeToFit = True
        Me.BarItem1.Tag = "Save"
        Me.BarItem1.Text = "Save"
        Me.BarItem1.Tooltip = "Save (stays on this page after saving)"
        '
        'BarItem2
        '
        Me.BarItem2.BarName = "BarItem2"
        Me.BarItem2.CategoryIndex = 0
        Me.BarItem2.ID = "Save and Close"
        Me.BarItem2.Image = CType(resources.GetObject("BarItem2.Image"), Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)
        Me.BarItem2.ImageSize = New System.Drawing.Size(24, 24)
        Me.BarItem2.ShowToolTipInPopUp = False
        Me.BarItem2.SizeToFit = True
        Me.BarItem2.Tag = "Save and Close"
        Me.BarItem2.Text = "Save and Close"
        Me.BarItem2.Tooltip = "Save and Close (returns to previous form after saving)"
        '
        'BarItem3
        '
        Me.BarItem3.BarName = "BarItem3"
        Me.BarItem3.CategoryIndex = 0
        Me.BarItem3.ID = "Save and New"
        Me.BarItem3.Image = CType(resources.GetObject("BarItem3.Image"), Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)
        Me.BarItem3.ImageSize = New System.Drawing.Size(24, 24)
        Me.BarItem3.ShowToolTipInPopUp = False
        Me.BarItem3.SizeToFit = True
        Me.BarItem3.Tag = "Save and New"
        Me.BarItem3.Text = "Save and New"
        Me.BarItem3.Tooltip = "Save and New (opens a new form after saving)"
        '
        'Bar2
        '
        Me.Bar2.AllowCustomizing = False
        Me.Bar2.AllowHiding = False
        Me.Bar2.AllowItemsReorderOnShrunk = False
        Me.Bar2.AllowResizing = False
        Me.Bar2.BarName = "Notes and Attachments"
        Me.Bar2.BarStyle = Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible
        Me.Bar2.Caption = "Notes and Attachments"
        Me.Bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.ParentBarItem1, Me.ParentBarItem2})
        Me.Bar2.Manager = Me.MainFrameBarManager1
        '
        'ParentBarItem1
        '
        Me.ParentBarItem1.BarName = "ParentBarItem1"
        Me.ParentBarItem1.CategoryIndex = 1
        Me.ParentBarItem1.ID = "NotesHolder"
        Me.ParentBarItem1.Image = CType(resources.GetObject("ParentBarItem1.Image"), Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)
        Me.ParentBarItem1.ImageSize = New System.Drawing.Size(24, 24)
        Me.ParentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.ListBarItem1})
        Me.ParentBarItem1.MetroColor = System.Drawing.Color.DimGray
        Me.ParentBarItem1.ShowToolTipInPopUp = False
        Me.ParentBarItem1.SizeToFit = True
        Me.ParentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.ParentBarItem1.Text = "Notes"
        Me.ParentBarItem1.WrapLength = 20
        '
        'ListBarItem1
        '
        Me.ListBarItem1.BarName = "ListBarItem1"
        Me.ListBarItem1.CategoryIndex = 1
        Me.ListBarItem1.ChildCaptions.AddRange(New String() {"Add New Note"})
        Me.ListBarItem1.ID = "Note"
        Me.ListBarItem1.ShowToolTipInPopUp = False
        Me.ListBarItem1.SizeToFit = True
        Me.ListBarItem1.Text = "Note"
        '
        'ParentBarItem2
        '
        Me.ParentBarItem2.BarName = "ParentBarItem2"
        Me.ParentBarItem2.CategoryIndex = 1
        Me.ParentBarItem2.ID = "AttachmentHolder"
        Me.ParentBarItem2.Image = CType(resources.GetObject("ParentBarItem2.Image"), Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)
        Me.ParentBarItem2.ImageSize = New System.Drawing.Size(24, 24)
        Me.ParentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.ListBarItem2})
        Me.ParentBarItem2.MetroColor = System.Drawing.Color.DimGray
        Me.ParentBarItem2.ShowToolTipInPopUp = False
        Me.ParentBarItem2.SizeToFit = True
        Me.ParentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.ParentBarItem2.Text = "Attachments"
        Me.ParentBarItem2.WrapLength = 20
        '
        'lbiNewDoc
        '
        Me.ListBarItem2.BarName = "lbiNewDoc"
        Me.ListBarItem2.CategoryIndex = 1
        Me.ListBarItem2.ChildCaptions.AddRange(New String() {"Add Attachment"})
        Me.ListBarItem2.ID = "Attachments"
        Me.ListBarItem2.ShowToolTipInPopUp = False
        Me.ListBarItem2.SizeToFit = True
        Me.ListBarItem2.Text = "Attachment"
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 433)
        Me.Name = "test"
        Me.Text = "Form1"
        CType(Me.MainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
    Friend WithEvents BarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Friend WithEvents Bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
    Friend WithEvents BarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Friend WithEvents BarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Friend WithEvents Bar2 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
    Friend WithEvents ListBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem
    Friend WithEvents ListBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem
    Friend WithEvents ParentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
    Friend WithEvents ParentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
End Class
