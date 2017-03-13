<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNote
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
        Me.wbNoites = New System.Windows.Forms.WebBrowser()
        Me.txtTitle = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.mnuNotes = New SmarttNursery.MyMenu()
        CType(Me.txtTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wbNoites
        '
        Me.wbNoites.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.wbNoites.Location = New System.Drawing.Point(0, 66)
        Me.wbNoites.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbNoites.Name = "wbNoites"
        Me.wbNoites.Size = New System.Drawing.Size(609, 367)
        Me.wbNoites.TabIndex = 0
        Me.wbNoites.Url = New System.Uri("C:\Users\james_000\Projects\SmarttNursery.VB\SmarttNursery\SmarttNursery\HTMLPage" &
        "1.html", System.UriKind.Absolute)
        '
        'txtTitle
        '
        Me.txtTitle.BeforeTouchSize = New System.Drawing.Size(585, 25)
        Me.txtTitle.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtTitle.Location = New System.Drawing.Point(12, 35)
        Me.txtTitle.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(585, 25)
        Me.txtTitle.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Text = "Title"
        '
        'mnuNotes
        '
        Me.mnuNotes.BackColor = System.Drawing.Color.Transparent
        Me.mnuNotes.Dock = System.Windows.Forms.DockStyle.Top
        Me.mnuNotes.Location = New System.Drawing.Point(0, 0)
        Me.mnuNotes.Name = "mnuNotes"
        Me.mnuNotes.Size = New System.Drawing.Size(609, 29)
        Me.mnuNotes.TabIndex = 2
        '
        'frmNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 433)
        Me.Controls.Add(Me.mnuNotes)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.wbNoites)
        Me.Name = "frmNote"
        Me.Text = "Add Note"
        CType(Me.txtTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents wbNoites As WebBrowser
    Friend WithEvents txtTitle As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents mnuNotes As MyMenu
End Class
