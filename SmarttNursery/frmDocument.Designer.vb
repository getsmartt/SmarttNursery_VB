<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocument
    Inherits SmarttNursery.frmCopy

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
        Me.components = New System.ComponentModel.Container()
        Me.txtTitle = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.cboCategory = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.btnSelectFile = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.txtFile = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        CType(Me.txtTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.BeforeTouchSize = New System.Drawing.Size(352, 27)
        Me.txtTitle.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.txtTitle.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtTitle.Location = New System.Drawing.Point(4, 53)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTitle.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(352, 27)
        Me.txtTitle.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtTitle.TabIndex = 0
        Me.txtTitle.Text = "Title"
        '
        'cboCategory
        '
        Me.cboCategory.BackColor = System.Drawing.Color.White
        Me.cboCategory.BeforeTouchSize = New System.Drawing.Size(353, 28)
        Me.cboCategory.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.cboCategory.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCategory.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cboCategory.ForeColor = System.Drawing.Color.DimGray
        Me.cboCategory.Location = New System.Drawing.Point(4, 90)
        Me.cboCategory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(353, 28)
        Me.cboCategory.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.cboCategory.TabIndex = 2
        Me.cboCategory.Text = "Document Category"
        '
        'btnSelectFile
        '
        Me.btnSelectFile.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnSelectFile.BackColor = System.Drawing.Color.Gray
        Me.btnSelectFile.BeforeTouchSize = New System.Drawing.Size(100, 29)
        Me.btnSelectFile.FlatAppearance.BorderSize = 0
        Me.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectFile.ForeColor = System.Drawing.Color.White
        Me.btnSelectFile.IsBackStageButton = False
        Me.btnSelectFile.Location = New System.Drawing.Point(5, 126)
        Me.btnSelectFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSelectFile.MetroColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(100, 29)
        Me.btnSelectFile.TabIndex = 3
        Me.btnSelectFile.Text = "Select File"
        '
        'txtFile
        '
        Me.txtFile.BeforeTouchSize = New System.Drawing.Size(352, 27)
        Me.txtFile.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.txtFile.Enabled = False
        Me.txtFile.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtFile.Location = New System.Drawing.Point(113, 128)
        Me.txtFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFile.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(244, 27)
        Me.txtFile.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtFile.TabIndex = 0
        '
        'frmDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 158)
        Me.Controls.Add(Me.btnSelectFile)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.txtTitle)
        Me.Margin = New System.Windows.Forms.Padding(7, 12, 7, 12)
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Name = "frmDocument"
        Me.Text = "Attach Document"
        CType(Me.txtTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitle As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents cboCategory As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents btnSelectFile As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents txtFile As Syncfusion.Windows.Forms.Tools.TextBoxExt
End Class
