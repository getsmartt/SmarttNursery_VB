Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.XPMenus
Imports System.Reflection
Imports System.IO

Public Class frmCopy
    Inherits MetroForm

    Friend WithEvents bmMain As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
    Friend WithEvents pbiNotes As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
    Friend WithEvents pbiDocs As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
    Friend WithEvents biSave As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Friend WithEvents biSaveClose As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Friend WithEvents biSaveNew As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Friend WithEvents bSave As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
    Friend WithEvents bNotesandDocs As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
    Friend WithEvents lbiNewNote As Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem
    Friend WithEvents lbiNewDoc As Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Dim newImage As Image = My.Resources.ic_note_black_24dp_1x
        Dim noteImage As New ImageExt(newImage)
        newImage = My.Resources.ic_attach_file_black_24dp_1x
        Dim attachImage As New ImageExt(newImage)
        newImage = My.Resources.ic_attachment_black_24dp_1x
        Dim attachmentImage As New ImageExt(newImage)
        newImage = My.Resources.ic_note_add_black_24dp_1x
        Dim noteaddImage As New ImageExt(newImage)
        newImage = My.Resources.ic_save_black_24dp_1x
        Dim saveImage As New ImageExt(newImage)
        newImage = My.Resources.ic_save_close_black_24dp_1x
        Dim savecloseImage As New ImageExt(newImage)
        newImage = My.Resources.ic_save_new_black_24dp_1x
        Dim savenewImage As New ImageExt(newImage)

        ' Add any initialization after the InitializeComponent() call.
        Me.bmMain = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me.components, Me)
        Me.biSave = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
        Me.biSaveNew = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
        Me.biSaveClose = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
        Me.bSave = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.bmMain, "Save")
        Me.bNotesandDocs = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.bmMain, "Notes and Attachments")
        Me.lbiNewNote = New Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem()
        Me.lbiNewDoc = New Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem()
        Me.pbiNotes = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
        Me.pbiDocs = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
        CType(Me.bmMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainFrameBarManager1
        '
        Me.bmMain.AutoScale = True
        'Me.bmMain.BarPositionInfo = CType(Resources.GetObject("MainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
        Me.bmMain.Bars.Add(Me.bSave)
        'Me.bmMain.Bars.Add(Me.bNotesandDocs)
        Me.bmMain.Categories.Add("Save")
        Me.bmMain.Categories.Add("Notes and Attachments")
        Me.bmMain.CurrentBaseFormType = ""
        Me.bmMain.EnableMenuMerge = True
        Me.bmMain.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bmMain.Form = Me
        Me.bmMain.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biSave, Me.biSaveClose, Me.biSaveNew, Me.lbiNewNote, Me.lbiNewDoc, Me.pbiNotes, Me.pbiDocs})
        Me.bmMain.MetroColor = System.Drawing.Color.DimGray
        Me.bmMain.ResetCustomization = False
        Me.bmMain.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.bmMain.UseBackwardCompatiblity = False
        '
        'BarItem1
        '
        Me.biSave.BarName = "Save"
        Me.biSave.CategoryIndex = 0
        Me.biSave.ID = "Save"
        Me.biSave.Image = saveImage
        Me.biSave.ImageSize = New System.Drawing.Size(24, 24)
        Me.biSave.ShowToolTipInPopUp = False
        Me.biSave.SizeToFit = True
        Me.biSave.Tag = "Save"
        Me.biSave.Text = "Save"
        Me.biSave.Tooltip = "Save (stays on this page after saving)"
        '
        'BarItem3
        '
        Me.biSaveNew.BarName = "SaveNew"
        Me.biSaveNew.CategoryIndex = 0
        Me.biSaveNew.ID = "Save and New"
        Me.biSaveNew.Image = savenewImage
        Me.biSaveNew.ImageSize = New System.Drawing.Size(24, 24)
        Me.biSaveNew.ShowToolTipInPopUp = False
        Me.biSaveNew.SizeToFit = True
        Me.biSaveNew.Tag = "Save and New"
        Me.biSaveNew.Text = "Save and New"
        Me.biSaveNew.Tooltip = "Save and New (opens a new form after saving)"
        '
        'BarItem2
        '
        Me.biSaveClose.BarName = "SaveClose"
        Me.biSaveClose.CategoryIndex = 0
        Me.biSaveClose.ID = "Save and Close"
        Me.biSaveClose.Image = savecloseImage
        Me.biSaveClose.ImageSize = New System.Drawing.Size(24, 24)
        Me.biSaveClose.ShowToolTipInPopUp = False
        Me.biSaveClose.SizeToFit = True
        Me.biSaveClose.Tag = "Save and Close"
        Me.biSaveClose.Text = "Save and Close"
        Me.biSaveClose.Tooltip = "Save and Close (returns to previous form after saving)"
        '
        'Bar1
        '
        Me.bSave.AllowCustomizing = False
        Me.bSave.AllowHiding = False
        Me.bSave.AllowItemsReorderOnShrunk = False
        Me.bSave.AllowResizing = False
        Me.bSave.BarName = "Save"
        Me.bSave.Caption = "Save"
        Me.bSave.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biSave, Me.biSaveClose, Me.biSaveNew})
        Me.bSave.Manager = Me.bmMain
        Me.bSave.BarStyle = Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible
        '
        'Bar2
        '
        Me.bNotesandDocs.AllowCustomizing = False
        Me.bNotesandDocs.AllowHiding = False
        Me.bNotesandDocs.AllowItemsReorderOnShrunk = False
        Me.bNotesandDocs.AllowResizing = False
        Me.bNotesandDocs.BarName = "Notes and Attachments"
        Me.bNotesandDocs.Caption = "Notes and Attachments"
        Me.bNotesandDocs.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.pbiNotes, Me.pbiDocs})
        Me.bNotesandDocs.Manager = Me.bmMain
        Me.bNotesandDocs.BarStyle = Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible
        '
        'ListBarItem1
        '
        Me.lbiNewNote.BarName = "Note"
        Me.lbiNewNote.CategoryIndex = 1
        Me.lbiNewNote.ChildCaptions.AddRange(New String() {"Add New Note"})
        Me.lbiNewNote.ID = "Note"
        Me.lbiNewNote.ShowToolTipInPopUp = False
        Me.lbiNewNote.SizeToFit = True
        Me.lbiNewNote.Text = "Note"
        '
        'lbiNewDoc
        '
        Me.lbiNewDoc.BarName = "Docs"
        Me.lbiNewDoc.CategoryIndex = 1
        Me.lbiNewDoc.ChildCaptions.AddRange(New String() {"Add Attachment"})
        Me.lbiNewDoc.ID = "Attachments"
        Me.lbiNewDoc.ShowToolTipInPopUp = False
        Me.lbiNewDoc.SizeToFit = True
        Me.lbiNewDoc.Text = "Attachment"
        '
        'ParentBarItem1
        '
        Me.pbiNotes.BarName = "NotesHolder"
        Me.pbiNotes.CategoryIndex = 1
        Me.pbiNotes.ID = "NotesHolder"
        Me.pbiNotes.Image = noteImage
        Me.pbiNotes.ImageSize = New System.Drawing.Size(24, 24)
        Me.pbiNotes.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.lbiNewNote})
        Me.pbiNotes.MetroColor = System.Drawing.Color.DimGray
        Me.pbiNotes.ShowToolTipInPopUp = False
        Me.pbiNotes.SizeToFit = True
        Me.pbiNotes.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.pbiNotes.Text = "Notes"
        Me.pbiNotes.WrapLength = 20
        '
        'ParentBarItem2
        '
        Me.pbiDocs.BarName = "AttachmentHolder"
        Me.pbiDocs.CategoryIndex = 1
        Me.pbiDocs.ID = "AttachmentHolder"
        Me.pbiDocs.Image = attachmentImage
        Me.pbiDocs.ImageSize = New System.Drawing.Size(24, 24)
        Me.pbiDocs.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.lbiNewDoc})
        Me.pbiDocs.MetroColor = System.Drawing.Color.DimGray
        Me.pbiDocs.ShowToolTipInPopUp = False
        Me.pbiDocs.SizeToFit = True
        Me.pbiDocs.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.pbiDocs.Text = "Attachments"
        Me.pbiDocs.WrapLength = 20
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 433)
        Me.Name = "test"
        Me.Text = "Form1"
        CType(Me.bmMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public Sub showBar(barNumber As Integer)
        If barNumber = 1 Then
            Me.bmMain.Bars.Add(bSave)
        Else
            Me.bmMain.Bars.Add(bNotesandDocs)
        End If
    End Sub

    Friend Sub listBarItem1_Click(sender As Object, e As EventArgs) Handles lbiNewNote.Click
        Dim x As ListBarItemClickedEventArgs
        Dim y As String
        x = e
        y = lbiNewNote.ChildCaptions(x.IndexClicked)
    End Sub



End Class
