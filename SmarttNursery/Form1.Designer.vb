<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim HeaderCollection1 As Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection = New Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection()
        Me.Smartt_nurseryDataSet = New SmarttNursery.smartt_nurseryDataSet()
        Me.PlantmasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Plant_masterTableAdapter = New SmarttNursery.smartt_nurseryDataSetTableAdapters.plant_masterTableAdapter()
        Me.TreeNavigator1 = New Syncfusion.Windows.Forms.Tools.TreeNavigator()
        Me.TreeMenuItem1 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem2 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem3 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem4 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem5 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem6 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem7 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem8 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem9 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem10 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem11 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem12 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem13 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem14 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem15 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.TreeMenuItem16 = New Syncfusion.Windows.Forms.Tools.TreeMenuItem()
        Me.btnReceipt = New Syncfusion.Windows.Forms.ButtonAdv()
        CType(Me.Smartt_nurseryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlantmasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Smartt_nurseryDataSet
        '
        Me.Smartt_nurseryDataSet.DataSetName = "smartt_nurseryDataSet"
        Me.Smartt_nurseryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlantmasterBindingSource
        '
        Me.PlantmasterBindingSource.DataMember = "plant_master"
        Me.PlantmasterBindingSource.DataSource = Me.Smartt_nurseryDataSet
        '
        'Plant_masterTableAdapter
        '
        Me.Plant_masterTableAdapter.ClearBeforeFill = True
        '
        'TreeNavigator1
        '
        Me.TreeNavigator1.BackColor = System.Drawing.Color.White
        Me.TreeNavigator1.Dock = System.Windows.Forms.DockStyle.Left
        HeaderCollection1.Font = New System.Drawing.Font("Arial", 8.0!)
        HeaderCollection1.HeaderText = "Plants"
        HeaderCollection1.Height = 40
        Me.TreeNavigator1.Header = HeaderCollection1
        Me.TreeNavigator1.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeNavigator1.Items.Add(Me.TreeMenuItem1)
        Me.TreeNavigator1.Items.Add(Me.TreeMenuItem2)
        Me.TreeNavigator1.Items.Add(Me.TreeMenuItem3)
        Me.TreeNavigator1.Items.Add(Me.TreeMenuItem4)
        Me.TreeNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.TreeNavigator1.MinimumSize = New System.Drawing.Size(150, 150)
        Me.TreeNavigator1.Name = "TreeNavigator1"
        Me.TreeNavigator1.NavigationMode = Syncfusion.Windows.Forms.Tools.NavigationMode.[Default]
        Me.TreeNavigator1.Size = New System.Drawing.Size(219, 589)
        Me.TreeNavigator1.TabIndex = 0
        Me.TreeNavigator1.Text = "TreeNavigator1"
        '
        'TreeMenuItem1
        '
        Me.TreeMenuItem1.BackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem1.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem1.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem1.Items.Add(Me.TreeMenuItem5)
        Me.TreeMenuItem1.Items.Add(Me.TreeMenuItem6)
        Me.TreeMenuItem1.Items.Add(Me.TreeMenuItem7)
        Me.TreeMenuItem1.Items.Add(Me.TreeMenuItem8)
        Me.TreeMenuItem1.Location = New System.Drawing.Point(2, 0)
        Me.TreeMenuItem1.Name = "TreeMenuItem1"
        Me.TreeMenuItem1.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem1.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem1.Size = New System.Drawing.Size(217, 40)
        Me.TreeMenuItem1.TabIndex = 0
        Me.TreeMenuItem1.Text = "TreeMenuItem1"
        '
        'TreeMenuItem2
        '
        Me.TreeMenuItem2.BackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem2.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem2.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem2.Location = New System.Drawing.Point(2, 42)
        Me.TreeMenuItem2.Name = "TreeMenuItem2"
        Me.TreeMenuItem2.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem2.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem2.Size = New System.Drawing.Size(217, 40)
        Me.TreeMenuItem2.TabIndex = 0
        Me.TreeMenuItem2.Text = "TreeMenuItem2"
        '
        'TreeMenuItem3
        '
        Me.TreeMenuItem3.BackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem3.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem3.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem3.Location = New System.Drawing.Point(2, 84)
        Me.TreeMenuItem3.Name = "TreeMenuItem3"
        Me.TreeMenuItem3.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem3.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem3.Size = New System.Drawing.Size(217, 40)
        Me.TreeMenuItem3.TabIndex = 0
        Me.TreeMenuItem3.Text = "TreeMenuItem3"
        '
        'TreeMenuItem4
        '
        Me.TreeMenuItem4.BackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem4.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem4.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem4.Location = New System.Drawing.Point(2, 126)
        Me.TreeMenuItem4.Name = "TreeMenuItem4"
        Me.TreeMenuItem4.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem4.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem4.Size = New System.Drawing.Size(217, 40)
        Me.TreeMenuItem4.TabIndex = 0
        Me.TreeMenuItem4.Text = "TreeMenuItem4"
        '
        'TreeMenuItem5
        '
        Me.TreeMenuItem5.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem5.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem5.Items.Add(Me.TreeMenuItem9)
        Me.TreeMenuItem5.Items.Add(Me.TreeMenuItem10)
        Me.TreeMenuItem5.Items.Add(Me.TreeMenuItem11)
        Me.TreeMenuItem5.Items.Add(Me.TreeMenuItem12)
        Me.TreeMenuItem5.Location = New System.Drawing.Point(0, 0)
        Me.TreeMenuItem5.Name = "TreeMenuItem5"
        Me.TreeMenuItem5.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem5.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem5.Size = New System.Drawing.Size(0, 0)
        Me.TreeMenuItem5.TabIndex = 0
        Me.TreeMenuItem5.Text = "TreeMenuItem5"
        '
        'TreeMenuItem6
        '
        Me.TreeMenuItem6.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem6.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem6.Location = New System.Drawing.Point(0, 0)
        Me.TreeMenuItem6.Name = "TreeMenuItem6"
        Me.TreeMenuItem6.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem6.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem6.Size = New System.Drawing.Size(0, 0)
        Me.TreeMenuItem6.TabIndex = 0
        Me.TreeMenuItem6.Text = "TreeMenuItem6"
        '
        'TreeMenuItem7
        '
        Me.TreeMenuItem7.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem7.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem7.Location = New System.Drawing.Point(0, 0)
        Me.TreeMenuItem7.Name = "TreeMenuItem7"
        Me.TreeMenuItem7.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem7.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem7.Size = New System.Drawing.Size(0, 0)
        Me.TreeMenuItem7.TabIndex = 0
        Me.TreeMenuItem7.Text = "TreeMenuItem7"
        '
        'TreeMenuItem8
        '
        Me.TreeMenuItem8.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem8.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem8.Location = New System.Drawing.Point(0, 0)
        Me.TreeMenuItem8.Name = "TreeMenuItem8"
        Me.TreeMenuItem8.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem8.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem8.Size = New System.Drawing.Size(0, 0)
        Me.TreeMenuItem8.TabIndex = 0
        Me.TreeMenuItem8.Text = "TreeMenuItem8"
        '
        'TreeMenuItem9
        '
        Me.TreeMenuItem9.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem9.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem9.Items.Add(Me.TreeMenuItem13)
        Me.TreeMenuItem9.Items.Add(Me.TreeMenuItem14)
        Me.TreeMenuItem9.Items.Add(Me.TreeMenuItem15)
        Me.TreeMenuItem9.Items.Add(Me.TreeMenuItem16)
        Me.TreeMenuItem9.Location = New System.Drawing.Point(0, 0)
        Me.TreeMenuItem9.Name = "TreeMenuItem9"
        Me.TreeMenuItem9.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem9.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem9.Size = New System.Drawing.Size(0, 0)
        Me.TreeMenuItem9.TabIndex = 0
        Me.TreeMenuItem9.Text = "TreeMenuItem9"
        '
        'TreeMenuItem10
        '
        Me.TreeMenuItem10.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem10.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem10.Location = New System.Drawing.Point(0, 0)
        Me.TreeMenuItem10.Name = "TreeMenuItem10"
        Me.TreeMenuItem10.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem10.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem10.Size = New System.Drawing.Size(0, 0)
        Me.TreeMenuItem10.TabIndex = 0
        Me.TreeMenuItem10.Text = "TreeMenuItem10"
        '
        'TreeMenuItem11
        '
        Me.TreeMenuItem11.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem11.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem11.Location = New System.Drawing.Point(0, 0)
        Me.TreeMenuItem11.Name = "TreeMenuItem11"
        Me.TreeMenuItem11.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem11.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem11.Size = New System.Drawing.Size(0, 0)
        Me.TreeMenuItem11.TabIndex = 0
        Me.TreeMenuItem11.Text = "TreeMenuItem11"
        '
        'TreeMenuItem12
        '
        Me.TreeMenuItem12.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem12.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem12.Location = New System.Drawing.Point(0, 0)
        Me.TreeMenuItem12.Name = "TreeMenuItem12"
        Me.TreeMenuItem12.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem12.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem12.Size = New System.Drawing.Size(0, 0)
        Me.TreeMenuItem12.TabIndex = 0
        Me.TreeMenuItem12.Text = "TreeMenuItem12"
        '
        'TreeMenuItem13
        '
        Me.TreeMenuItem13.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem13.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem13.Location = New System.Drawing.Point(0, 0)
        Me.TreeMenuItem13.Name = "TreeMenuItem13"
        Me.TreeMenuItem13.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem13.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem13.Size = New System.Drawing.Size(0, 0)
        Me.TreeMenuItem13.TabIndex = 0
        Me.TreeMenuItem13.Text = "TreeMenuItem13"
        '
        'TreeMenuItem14
        '
        Me.TreeMenuItem14.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem14.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem14.Location = New System.Drawing.Point(0, 0)
        Me.TreeMenuItem14.Name = "TreeMenuItem14"
        Me.TreeMenuItem14.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem14.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem14.Size = New System.Drawing.Size(0, 0)
        Me.TreeMenuItem14.TabIndex = 0
        Me.TreeMenuItem14.Text = "TreeMenuItem14"
        '
        'TreeMenuItem15
        '
        Me.TreeMenuItem15.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem15.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem15.Location = New System.Drawing.Point(0, 0)
        Me.TreeMenuItem15.Name = "TreeMenuItem15"
        Me.TreeMenuItem15.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem15.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem15.Size = New System.Drawing.Size(0, 0)
        Me.TreeMenuItem15.TabIndex = 0
        Me.TreeMenuItem15.Text = "TreeMenuItem15"
        '
        'TreeMenuItem16
        '
        Me.TreeMenuItem16.ItemBackColor = System.Drawing.SystemColors.Control
        Me.TreeMenuItem16.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeMenuItem16.Location = New System.Drawing.Point(0, 0)
        Me.TreeMenuItem16.Name = "TreeMenuItem16"
        Me.TreeMenuItem16.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TreeMenuItem16.SelectedItemForeColor = System.Drawing.Color.Black
        Me.TreeMenuItem16.Size = New System.Drawing.Size(0, 0)
        Me.TreeMenuItem16.TabIndex = 0
        Me.TreeMenuItem16.Text = "TreeMenuItem16"
        '
        'btnReceipt
        '
        Me.btnReceipt.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.btnReceipt.IsBackStageButton = False
        Me.btnReceipt.Location = New System.Drawing.Point(226, 13)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(75, 23)
        Me.btnReceipt.TabIndex = 1
        Me.btnReceipt.Text = "Reciept"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 589)
        Me.Controls.Add(Me.btnReceipt)
        Me.Controls.Add(Me.TreeNavigator1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Smartt_nurseryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlantmasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Smartt_nurseryDataSet As smartt_nurseryDataSet
    Friend WithEvents PlantmasterBindingSource As BindingSource
    Friend WithEvents Plant_masterTableAdapter As smartt_nurseryDataSetTableAdapters.plant_masterTableAdapter
    Friend WithEvents TreeNavigator1 As Syncfusion.Windows.Forms.Tools.TreeNavigator
    Friend WithEvents TreeMenuItem1 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem5 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem9 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem13 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem14 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem15 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem16 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem10 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem11 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem12 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem6 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem7 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem8 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem2 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem3 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents TreeMenuItem4 As Syncfusion.Windows.Forms.Tools.TreeMenuItem
    Friend WithEvents btnReceipt As Syncfusion.Windows.Forms.ButtonAdv
End Class
