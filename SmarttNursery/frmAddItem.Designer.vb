<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddItem
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddItem))
        Me.mnuAddItem = New SmarttNursery.MyMenu()
        Me.tabAddItems = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
        Me.tpPlantsBought = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.tpPlantsSold = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.tpItemBought = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.tpItemSold = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.txtLatinName = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.cbCommonName = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.cbCultivar = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.txtTradeName = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.pnlCultivar = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.lblCultivar = New System.Windows.Forms.Label()
        Me.rbtnRegistered = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
        Me.txtPatent = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.ceCost = New Syncfusion.Windows.Forms.Tools.CurrencyEdit()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.itxtCount = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.cboFormat = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.itxtCount2 = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.lblCount2 = New System.Windows.Forms.Label()
        Me.lblCost2 = New System.Windows.Forms.Label()
        Me.ceCost2 = New Syncfusion.Windows.Forms.Tools.CurrencyEdit()
        Me.pnlCultivar2 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.rbtnRegistered2 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
        Me.lblCultivar2 = New System.Windows.Forms.Label()
        Me.cboCultivar2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.txtPatent2 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtTradeName2 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.cboFormat2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.cboCommonName2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.txtLatinName2 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.cboSource2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        CType(Me.tabAddItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAddItems.SuspendLayout()
        Me.tpPlantsBought.SuspendLayout()
        Me.tpPlantsSold.SuspendLayout()
        CType(Me.txtLatinName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCommonName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCultivar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTradeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlCultivar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCultivar.SuspendLayout()
        CType(Me.rbtnRegistered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPatent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCost.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itxtCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itxtCount2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCost2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCost2.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlCultivar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCultivar2.SuspendLayout()
        CType(Me.rbtnRegistered2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCultivar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPatent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTradeName2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFormat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCommonName2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLatinName2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuAddItem
        '
        Me.mnuAddItem.BackColor = System.Drawing.Color.Transparent
        Me.mnuAddItem.Dock = System.Windows.Forms.DockStyle.Top
        Me.mnuAddItem.Location = New System.Drawing.Point(0, 0)
        Me.mnuAddItem.Name = "mnuAddItem"
        Me.mnuAddItem.Size = New System.Drawing.Size(297, 29)
        Me.mnuAddItem.TabIndex = 0
        '
        'tabAddItems
        '
        Me.tabAddItems.ActiveTabColor = System.Drawing.Color.DimGray
        Me.tabAddItems.ActiveTabForeColor = System.Drawing.Color.Empty
        Me.tabAddItems.BeforeTouchSize = New System.Drawing.Size(297, 297)
        Me.tabAddItems.CloseButtonForeColor = System.Drawing.Color.Empty
        Me.tabAddItems.CloseButtonHoverForeColor = System.Drawing.Color.Empty
        Me.tabAddItems.CloseButtonPressedForeColor = System.Drawing.Color.Empty
        Me.tabAddItems.Controls.Add(Me.tpPlantsBought)
        Me.tabAddItems.Controls.Add(Me.tpPlantsSold)
        Me.tabAddItems.Controls.Add(Me.tpItemBought)
        Me.tabAddItems.Controls.Add(Me.tpItemSold)
        Me.tabAddItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAddItems.FixedSingleBorderColor = System.Drawing.Color.DimGray
        Me.tabAddItems.FocusOnTabClick = False
        Me.tabAddItems.InActiveTabForeColor = System.Drawing.Color.Empty
        Me.tabAddItems.Location = New System.Drawing.Point(0, 29)
        Me.tabAddItems.Multiline = True
        Me.tabAddItems.Name = "tabAddItems"
        Me.tabAddItems.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver
        Me.tabAddItems.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Silver
        Me.tabAddItems.SeparatorColor = System.Drawing.SystemColors.ControlDark
        Me.tabAddItems.ShowSeparator = False
        Me.tabAddItems.Size = New System.Drawing.Size(297, 297)
        Me.tabAddItems.TabIndex = 1
        Me.tabAddItems.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererMetro)
        Me.tabAddItems.ThemesEnabled = True
        '
        'tpPlantsBought
        '
        Me.tpPlantsBought.Controls.Add(Me.itxtCount)
        Me.tpPlantsBought.Controls.Add(Me.lblCount)
        Me.tpPlantsBought.Controls.Add(Me.lblCost)
        Me.tpPlantsBought.Controls.Add(Me.ceCost)
        Me.tpPlantsBought.Controls.Add(Me.pnlCultivar)
        Me.tpPlantsBought.Controls.Add(Me.cboFormat)
        Me.tpPlantsBought.Controls.Add(Me.cbCommonName)
        Me.tpPlantsBought.Controls.Add(Me.txtLatinName)
        Me.tpPlantsBought.Image = Nothing
        Me.tpPlantsBought.ImageSize = New System.Drawing.Size(16, 16)
        Me.tpPlantsBought.Location = New System.Drawing.Point(3, 24)
        Me.tpPlantsBought.Name = "tpPlantsBought"
        Me.tpPlantsBought.ShowCloseButton = True
        Me.tpPlantsBought.Size = New System.Drawing.Size(290, 269)
        Me.tpPlantsBought.TabIndex = 1
        Me.tpPlantsBought.TabVisible = False
        Me.tpPlantsBought.Text = "PlantBought"
        Me.tpPlantsBought.ThemesEnabled = True
        '
        'tpPlantsSold
        '
        Me.tpPlantsSold.Controls.Add(Me.itxtCount2)
        Me.tpPlantsSold.Controls.Add(Me.lblCount2)
        Me.tpPlantsSold.Controls.Add(Me.lblCost2)
        Me.tpPlantsSold.Controls.Add(Me.ceCost2)
        Me.tpPlantsSold.Controls.Add(Me.pnlCultivar2)
        Me.tpPlantsSold.Controls.Add(Me.cboSource2)
        Me.tpPlantsSold.Controls.Add(Me.cboFormat2)
        Me.tpPlantsSold.Controls.Add(Me.cboCommonName2)
        Me.tpPlantsSold.Controls.Add(Me.txtLatinName2)
        Me.tpPlantsSold.Image = Nothing
        Me.tpPlantsSold.ImageSize = New System.Drawing.Size(16, 16)
        Me.tpPlantsSold.Location = New System.Drawing.Point(3, 24)
        Me.tpPlantsSold.Name = "tpPlantsSold"
        Me.tpPlantsSold.ShowCloseButton = True
        Me.tpPlantsSold.Size = New System.Drawing.Size(290, 269)
        Me.tpPlantsSold.TabIndex = 2
        Me.tpPlantsSold.Text = "PlantSold"
        Me.tpPlantsSold.ThemesEnabled = True
        '
        'tpItemBought
        '
        Me.tpItemBought.Image = Nothing
        Me.tpItemBought.ImageSize = New System.Drawing.Size(16, 16)
        Me.tpItemBought.Location = New System.Drawing.Point(3, 24)
        Me.tpItemBought.Name = "tpItemBought"
        Me.tpItemBought.ShowCloseButton = True
        Me.tpItemBought.Size = New System.Drawing.Size(290, 269)
        Me.tpItemBought.TabIndex = 3
        Me.tpItemBought.Text = "ItemBought"
        Me.tpItemBought.ThemesEnabled = True
        '
        'tpItemSold
        '
        Me.tpItemSold.Image = Nothing
        Me.tpItemSold.ImageSize = New System.Drawing.Size(16, 16)
        Me.tpItemSold.Location = New System.Drawing.Point(3, 24)
        Me.tpItemSold.Name = "tpItemSold"
        Me.tpItemSold.ShowCloseButton = True
        Me.tpItemSold.Size = New System.Drawing.Size(290, 269)
        Me.tpItemSold.TabIndex = 4
        Me.tpItemSold.Text = "ItemSold"
        Me.tpItemSold.ThemesEnabled = True
        '
        'txtLatinName
        '
        Me.txtLatinName.BeforeTouchSize = New System.Drawing.Size(269, 22)
        Me.txtLatinName.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.txtLatinName.BorderColor = System.Drawing.Color.DimGray
        Me.txtLatinName.ForeColor = System.Drawing.Color.DimGray
        Me.txtLatinName.Location = New System.Drawing.Point(9, 9)
        Me.txtLatinName.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtLatinName.Name = "txtLatinName"
        Me.txtLatinName.Size = New System.Drawing.Size(269, 22)
        Me.txtLatinName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtLatinName.TabIndex = 0
        Me.txtLatinName.Text = "Latin name"
        '
        'cbCommonName
        '
        Me.cbCommonName.BackColor = System.Drawing.Color.White
        Me.cbCommonName.BeforeTouchSize = New System.Drawing.Size(269, 21)
        Me.cbCommonName.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.cbCommonName.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cbCommonName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCommonName.ForeColor = System.Drawing.Color.DimGray
        Me.cbCommonName.Location = New System.Drawing.Point(9, 37)
        Me.cbCommonName.MetroBorderColor = System.Drawing.Color.DarkGray
        Me.cbCommonName.Name = "cbCommonName"
        Me.cbCommonName.Size = New System.Drawing.Size(269, 21)
        Me.cbCommonName.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.cbCommonName.TabIndex = 1
        Me.cbCommonName.Text = "Common name"
        '
        'cbCultivar
        '
        Me.cbCultivar.BackColor = System.Drawing.Color.White
        Me.cbCultivar.BeforeTouchSize = New System.Drawing.Size(255, 21)
        Me.cbCultivar.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.cbCultivar.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cbCultivar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCultivar.ForeColor = System.Drawing.Color.DimGray
        Me.cbCultivar.Location = New System.Drawing.Point(7, 17)
        Me.cbCultivar.MetroBorderColor = System.Drawing.Color.DarkGray
        Me.cbCultivar.Name = "cbCultivar"
        Me.cbCultivar.Size = New System.Drawing.Size(255, 21)
        Me.cbCultivar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.cbCultivar.TabIndex = 1
        Me.cbCultivar.Text = "Cultivar name"
        '
        'txtTradeName
        '
        Me.txtTradeName.BeforeTouchSize = New System.Drawing.Size(269, 22)
        Me.txtTradeName.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.txtTradeName.BorderColor = System.Drawing.Color.DimGray
        Me.txtTradeName.ForeColor = System.Drawing.Color.DimGray
        Me.txtTradeName.Location = New System.Drawing.Point(7, 44)
        Me.txtTradeName.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtTradeName.Name = "txtTradeName"
        Me.txtTradeName.Size = New System.Drawing.Size(166, 22)
        Me.txtTradeName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtTradeName.TabIndex = 0
        Me.txtTradeName.Text = "Trade name"
        '
        'pnlCultivar
        '
        Me.pnlCultivar.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.pnlCultivar.Controls.Add(Me.rbtnRegistered)
        Me.pnlCultivar.Controls.Add(Me.lblCultivar)
        Me.pnlCultivar.Controls.Add(Me.cbCultivar)
        Me.pnlCultivar.Controls.Add(Me.txtPatent)
        Me.pnlCultivar.Controls.Add(Me.txtTradeName)
        Me.pnlCultivar.Location = New System.Drawing.Point(9, 95)
        Me.pnlCultivar.Name = "pnlCultivar"
        Me.pnlCultivar.Size = New System.Drawing.Size(269, 105)
        Me.pnlCultivar.TabIndex = 2
        '
        'lblCultivar
        '
        Me.lblCultivar.AutoSize = True
        Me.lblCultivar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCultivar.ForeColor = System.Drawing.Color.DimGray
        Me.lblCultivar.Location = New System.Drawing.Point(-3, 0)
        Me.lblCultivar.Name = "lblCultivar"
        Me.lblCultivar.Size = New System.Drawing.Size(107, 13)
        Me.lblCultivar.TabIndex = 0
        Me.lblCultivar.Text = "Cultivar Information"
        '
        'rbtnRegistered
        '
        Me.rbtnRegistered.BeforeTouchSize = New System.Drawing.Size(83, 21)
        Me.rbtnRegistered.Location = New System.Drawing.Point(179, 44)
        Me.rbtnRegistered.MetroColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.rbtnRegistered.Name = "rbtnRegistered"
        Me.rbtnRegistered.Size = New System.Drawing.Size(83, 21)
        Me.rbtnRegistered.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
        Me.rbtnRegistered.TabIndex = 2
        Me.rbtnRegistered.Text = "Registered?"
        Me.rbtnRegistered.ThemesEnabled = False
        '
        'txtPatent
        '
        Me.txtPatent.BeforeTouchSize = New System.Drawing.Size(269, 22)
        Me.txtPatent.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.txtPatent.BorderColor = System.Drawing.Color.DimGray
        Me.txtPatent.ForeColor = System.Drawing.Color.DimGray
        Me.txtPatent.Location = New System.Drawing.Point(7, 72)
        Me.txtPatent.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtPatent.Name = "txtPatent"
        Me.txtPatent.Size = New System.Drawing.Size(255, 22)
        Me.txtPatent.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtPatent.TabIndex = 0
        Me.txtPatent.Text = "Patent Number"
        '
        'ceCost
        '
        Me.ceCost.BeforeTouchSize = New System.Drawing.Size(179, 23)
        Me.ceCost.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.ceCost.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        '
        '
        '
        Me.ceCost.CalculatorButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ceCost.CalculatorButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.ceCost.CalculatorButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat
        Me.ceCost.CalculatorButton.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Calculator
        Me.ceCost.CalculatorButton.ComboEditBackColor = System.Drawing.SystemColors.Window
        Me.ceCost.CalculatorButton.ForeColor = System.Drawing.Color.White
        Me.ceCost.CalculatorButton.Image = CType(resources.GetObject("CurrencyEdit1.CalculatorButton.Image"), System.Drawing.Image)
        Me.ceCost.CalculatorButton.IsBackStageButton = False
        Me.ceCost.CalculatorButton.Name = ""
        Me.ceCost.CalculatorButton.PreferredWidth = 24
        Me.ceCost.CalculatorButton.TabIndex = 0
        Me.ceCost.FlatBorderColor = System.Drawing.Color.LightGray
        Me.ceCost.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceCost.Location = New System.Drawing.Point(98, 207)
        Me.ceCost.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ceCost.Name = "ceCost"
        Me.ceCost.PopupCalculatorAlignment = Syncfusion.Windows.Forms.Tools.CalculatorPopupAlignment.Left
        Me.ceCost.SelectionStart = 2
        Me.ceCost.ShowTextBox = False
        Me.ceCost.Size = New System.Drawing.Size(179, 23)
        Me.ceCost.TabIndex = 3
        '
        '
        '
        Me.ceCost.TextBox.BackGroundColor = System.Drawing.SystemColors.Window
        Me.ceCost.TextBox.BeforeTouchSize = New System.Drawing.Size(269, 22)
        Me.ceCost.TextBox.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.ceCost.TextBox.BorderColor = System.Drawing.Color.DimGray
        Me.ceCost.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ceCost.TextBox.DecimalValue = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.ceCost.TextBox.ForeColor = System.Drawing.Color.DimGray
        Me.ceCost.TextBox.Location = New System.Drawing.Point(3, 4)
        Me.ceCost.TextBox.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ceCost.TextBox.Name = ""
        Me.ceCost.TextBox.NullString = ""
        Me.ceCost.TextBox.Size = New System.Drawing.Size(149, 15)
        Me.ceCost.TextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.ceCost.TextBox.TabIndex = 0
        Me.ceCost.TextBox.Text = "$1.00"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.DimGray
        Me.lblCost.Location = New System.Drawing.Point(11, 211)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(81, 15)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Cost per Plant"
        '
        'itxtCount
        '
        Me.itxtCount.BackGroundColor = System.Drawing.SystemColors.Window
        Me.itxtCount.BeforeTouchSize = New System.Drawing.Size(269, 22)
        Me.itxtCount.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.itxtCount.BorderColor = System.Drawing.Color.DimGray
        Me.itxtCount.ForeColor = System.Drawing.Color.DimGray
        Me.itxtCount.IntegerValue = CType(1, Long)
        Me.itxtCount.Location = New System.Drawing.Point(98, 237)
        Me.itxtCount.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.itxtCount.Name = "itxtCount"
        Me.itxtCount.NullString = ""
        Me.itxtCount.PositiveColor = System.Drawing.Color.DimGray
        Me.itxtCount.Size = New System.Drawing.Size(179, 22)
        Me.itxtCount.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.itxtCount.TabIndex = 5
        Me.itxtCount.Text = "1"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.DimGray
        Me.lblCount.Location = New System.Drawing.Point(11, 240)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(70, 15)
        Me.lblCount.TabIndex = 4
        Me.lblCount.Text = "Plant Count"
        '
        'cboFormat
        '
        Me.cboFormat.BackColor = System.Drawing.Color.White
        Me.cboFormat.BeforeTouchSize = New System.Drawing.Size(269, 21)
        Me.cboFormat.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.cboFormat.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cboFormat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormat.ForeColor = System.Drawing.Color.DimGray
        Me.cboFormat.Location = New System.Drawing.Point(9, 64)
        Me.cboFormat.MetroBorderColor = System.Drawing.Color.DarkGray
        Me.cboFormat.Name = "cboFormat"
        Me.cboFormat.Size = New System.Drawing.Size(269, 21)
        Me.cboFormat.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.cboFormat.TabIndex = 1
        Me.cboFormat.Text = "Plant Format"
        '
        'itxtCount2
        '
        Me.itxtCount2.BackGroundColor = System.Drawing.SystemColors.Window
        Me.itxtCount2.BeforeTouchSize = New System.Drawing.Size(269, 22)
        Me.itxtCount2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.itxtCount2.BorderColor = System.Drawing.Color.DimGray
        Me.itxtCount2.ForeColor = System.Drawing.Color.DimGray
        Me.itxtCount2.IntegerValue = CType(1, Long)
        Me.itxtCount2.Location = New System.Drawing.Point(98, 237)
        Me.itxtCount2.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.itxtCount2.Name = "itxtCount2"
        Me.itxtCount2.NullString = ""
        Me.itxtCount2.PositiveColor = System.Drawing.Color.DimGray
        Me.itxtCount2.Size = New System.Drawing.Size(179, 22)
        Me.itxtCount2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.itxtCount2.TabIndex = 13
        Me.itxtCount2.Text = "1"
        '
        'lblCount2
        '
        Me.lblCount2.AutoSize = True
        Me.lblCount2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount2.ForeColor = System.Drawing.Color.DimGray
        Me.lblCount2.Location = New System.Drawing.Point(11, 240)
        Me.lblCount2.Name = "lblCount2"
        Me.lblCount2.Size = New System.Drawing.Size(70, 15)
        Me.lblCount2.TabIndex = 11
        Me.lblCount2.Text = "Plant Count"
        '
        'lblCost2
        '
        Me.lblCost2.AutoSize = True
        Me.lblCost2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost2.ForeColor = System.Drawing.Color.DimGray
        Me.lblCost2.Location = New System.Drawing.Point(11, 211)
        Me.lblCost2.Name = "lblCost2"
        Me.lblCost2.Size = New System.Drawing.Size(81, 15)
        Me.lblCost2.TabIndex = 12
        Me.lblCost2.Text = "Cost per Plant"
        '
        'ceCost2
        '
        Me.ceCost2.BeforeTouchSize = New System.Drawing.Size(179, 23)
        Me.ceCost2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.ceCost2.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        '
        '
        '
        Me.ceCost2.CalculatorButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ceCost2.CalculatorButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.ceCost2.CalculatorButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat
        Me.ceCost2.CalculatorButton.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Calculator
        Me.ceCost2.CalculatorButton.ComboEditBackColor = System.Drawing.SystemColors.Window
        Me.ceCost2.CalculatorButton.ForeColor = System.Drawing.Color.White
        Me.ceCost2.CalculatorButton.Image = CType(resources.GetObject("CurrencyEdit1.CalculatorButton.Image1"), System.Drawing.Image)
        Me.ceCost2.CalculatorButton.IsBackStageButton = False
        Me.ceCost2.CalculatorButton.Name = ""
        Me.ceCost2.CalculatorButton.PreferredWidth = 24
        Me.ceCost2.CalculatorButton.TabIndex = 0
        Me.ceCost2.FlatBorderColor = System.Drawing.Color.LightGray
        Me.ceCost2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceCost2.Location = New System.Drawing.Point(98, 207)
        Me.ceCost2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ceCost2.Name = "ceCost2"
        Me.ceCost2.PopupCalculatorAlignment = Syncfusion.Windows.Forms.Tools.CalculatorPopupAlignment.Left
        Me.ceCost2.Size = New System.Drawing.Size(179, 23)
        Me.ceCost2.TabIndex = 10
        '
        '
        '
        Me.ceCost2.TextBox.BackGroundColor = System.Drawing.SystemColors.Window
        Me.ceCost2.TextBox.BeforeTouchSize = New System.Drawing.Size(269, 22)
        Me.ceCost2.TextBox.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.ceCost2.TextBox.BorderColor = System.Drawing.Color.DimGray
        Me.ceCost2.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ceCost2.TextBox.DecimalValue = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.ceCost2.TextBox.Location = New System.Drawing.Point(3, 4)
        Me.ceCost2.TextBox.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ceCost2.TextBox.Name = ""
        Me.ceCost2.TextBox.NullString = ""
        Me.ceCost2.TextBox.Size = New System.Drawing.Size(149, 15)
        Me.ceCost2.TextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.ceCost2.TextBox.TabIndex = 0
        Me.ceCost2.TextBox.Text = "$1.00"
        '
        'pnlCultivar2
        '
        Me.pnlCultivar2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.pnlCultivar2.Controls.Add(Me.rbtnRegistered2)
        Me.pnlCultivar2.Controls.Add(Me.lblCultivar2)
        Me.pnlCultivar2.Controls.Add(Me.cboCultivar2)
        Me.pnlCultivar2.Controls.Add(Me.txtPatent2)
        Me.pnlCultivar2.Controls.Add(Me.txtTradeName2)
        Me.pnlCultivar2.Location = New System.Drawing.Point(9, 95)
        Me.pnlCultivar2.Name = "pnlCultivar2"
        Me.pnlCultivar2.Size = New System.Drawing.Size(269, 105)
        Me.pnlCultivar2.TabIndex = 9
        '
        'rbtnRegistered2
        '
        Me.rbtnRegistered2.BeforeTouchSize = New System.Drawing.Size(83, 21)
        Me.rbtnRegistered2.Location = New System.Drawing.Point(179, 44)
        Me.rbtnRegistered2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.rbtnRegistered2.Name = "rbtnRegistered2"
        Me.rbtnRegistered2.Size = New System.Drawing.Size(83, 21)
        Me.rbtnRegistered2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
        Me.rbtnRegistered2.TabIndex = 2
        Me.rbtnRegistered2.Text = "Registered?"
        Me.rbtnRegistered2.ThemesEnabled = False
        '
        'lblCultivar2
        '
        Me.lblCultivar2.AutoSize = True
        Me.lblCultivar2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCultivar2.ForeColor = System.Drawing.Color.DimGray
        Me.lblCultivar2.Location = New System.Drawing.Point(-3, 0)
        Me.lblCultivar2.Name = "lblCultivar2"
        Me.lblCultivar2.Size = New System.Drawing.Size(107, 13)
        Me.lblCultivar2.TabIndex = 0
        Me.lblCultivar2.Text = "Cultivar Information"
        '
        'cboCultivar2
        '
        Me.cboCultivar2.BackColor = System.Drawing.Color.White
        Me.cboCultivar2.BeforeTouchSize = New System.Drawing.Size(255, 21)
        Me.cboCultivar2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.cboCultivar2.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cboCultivar2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCultivar2.ForeColor = System.Drawing.Color.DimGray
        Me.cboCultivar2.Location = New System.Drawing.Point(7, 17)
        Me.cboCultivar2.MetroBorderColor = System.Drawing.Color.DarkGray
        Me.cboCultivar2.Name = "cboCultivar2"
        Me.cboCultivar2.Size = New System.Drawing.Size(255, 21)
        Me.cboCultivar2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.cboCultivar2.TabIndex = 1
        Me.cboCultivar2.Text = "Cultivar name"
        '
        'txtPatent2
        '
        Me.txtPatent2.BeforeTouchSize = New System.Drawing.Size(269, 22)
        Me.txtPatent2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.txtPatent2.BorderColor = System.Drawing.Color.DimGray
        Me.txtPatent2.ForeColor = System.Drawing.Color.DimGray
        Me.txtPatent2.Location = New System.Drawing.Point(7, 72)
        Me.txtPatent2.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtPatent2.Name = "txtPatent2"
        Me.txtPatent2.Size = New System.Drawing.Size(255, 22)
        Me.txtPatent2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtPatent2.TabIndex = 0
        Me.txtPatent2.Text = "Patent Number"
        '
        'txtTradeName2
        '
        Me.txtTradeName2.BeforeTouchSize = New System.Drawing.Size(269, 22)
        Me.txtTradeName2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.txtTradeName2.BorderColor = System.Drawing.Color.DimGray
        Me.txtTradeName2.ForeColor = System.Drawing.Color.DimGray
        Me.txtTradeName2.Location = New System.Drawing.Point(7, 44)
        Me.txtTradeName2.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtTradeName2.Name = "txtTradeName2"
        Me.txtTradeName2.Size = New System.Drawing.Size(166, 22)
        Me.txtTradeName2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtTradeName2.TabIndex = 0
        Me.txtTradeName2.Text = "Trade name"
        '
        'cboFormat2
        '
        Me.cboFormat2.BackColor = System.Drawing.Color.White
        Me.cboFormat2.BeforeTouchSize = New System.Drawing.Size(128, 21)
        Me.cboFormat2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.cboFormat2.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cboFormat2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormat2.ForeColor = System.Drawing.Color.DimGray
        Me.cboFormat2.Location = New System.Drawing.Point(9, 64)
        Me.cboFormat2.MetroBorderColor = System.Drawing.Color.DarkGray
        Me.cboFormat2.Name = "cboFormat2"
        Me.cboFormat2.Size = New System.Drawing.Size(128, 21)
        Me.cboFormat2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.cboFormat2.TabIndex = 7
        Me.cboFormat2.Text = "Plant Format"
        '
        'cboCommonName2
        '
        Me.cboCommonName2.BackColor = System.Drawing.Color.White
        Me.cboCommonName2.BeforeTouchSize = New System.Drawing.Size(269, 21)
        Me.cboCommonName2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.cboCommonName2.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cboCommonName2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCommonName2.ForeColor = System.Drawing.Color.DimGray
        Me.cboCommonName2.Location = New System.Drawing.Point(9, 37)
        Me.cboCommonName2.MetroBorderColor = System.Drawing.Color.DarkGray
        Me.cboCommonName2.Name = "cboCommonName2"
        Me.cboCommonName2.Size = New System.Drawing.Size(269, 21)
        Me.cboCommonName2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.cboCommonName2.TabIndex = 8
        Me.cboCommonName2.Text = "Common name"
        '
        'txtLatinName2
        '
        Me.txtLatinName2.BeforeTouchSize = New System.Drawing.Size(269, 22)
        Me.txtLatinName2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.txtLatinName2.BorderColor = System.Drawing.Color.DimGray
        Me.txtLatinName2.ForeColor = System.Drawing.Color.DimGray
        Me.txtLatinName2.Location = New System.Drawing.Point(9, 9)
        Me.txtLatinName2.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtLatinName2.Name = "txtLatinName2"
        Me.txtLatinName2.Size = New System.Drawing.Size(269, 22)
        Me.txtLatinName2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtLatinName2.TabIndex = 6
        Me.txtLatinName2.Text = "Latin name"
        '
        'cboSource2
        '
        Me.cboSource2.BackColor = System.Drawing.Color.White
        Me.cboSource2.BeforeTouchSize = New System.Drawing.Size(128, 21)
        Me.cboSource2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.cboSource2.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cboSource2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSource2.ForeColor = System.Drawing.Color.DimGray
        Me.cboSource2.Location = New System.Drawing.Point(150, 64)
        Me.cboSource2.MetroBorderColor = System.Drawing.Color.DarkGray
        Me.cboSource2.Name = "cboSource2"
        Me.cboSource2.Size = New System.Drawing.Size(128, 21)
        Me.cboSource2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.cboSource2.TabIndex = 7
        Me.cboSource2.Text = "Plant Source"
        '
        'frmAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientSize = New System.Drawing.Size(297, 326)
        Me.Controls.Add(Me.tabAddItems)
        Me.Controls.Add(Me.mnuAddItem)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroColor = System.Drawing.Color.DimGray
        Me.Name = "frmAddItem"
        Me.Text = "Add Item"
        CType(Me.tabAddItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAddItems.ResumeLayout(False)
        Me.tpPlantsBought.ResumeLayout(False)
        Me.tpPlantsBought.PerformLayout()
        Me.tpPlantsSold.ResumeLayout(False)
        Me.tpPlantsSold.PerformLayout()
        CType(Me.txtLatinName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCommonName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCultivar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTradeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlCultivar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCultivar.ResumeLayout(False)
        Me.pnlCultivar.PerformLayout()
        CType(Me.rbtnRegistered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPatent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCost.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itxtCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFormat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itxtCount2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCost2.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCost2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlCultivar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCultivar2.ResumeLayout(False)
        Me.pnlCultivar2.PerformLayout()
        CType(Me.rbtnRegistered2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCultivar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPatent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTradeName2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFormat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCommonName2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLatinName2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mnuAddItem As MyMenu
    Friend WithEvents tabAddItems As Syncfusion.Windows.Forms.Tools.TabControlAdv
    Friend WithEvents tpPlantsBought As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents tpPlantsSold As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents tpItemBought As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents tpItemSold As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents itxtCount As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents lblCount As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents ceCost As Syncfusion.Windows.Forms.Tools.CurrencyEdit
    Friend WithEvents pnlCultivar As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents rbtnRegistered As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
    Friend WithEvents lblCultivar As Label
    Friend WithEvents cbCultivar As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents txtPatent As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtTradeName As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents cboFormat As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents cbCommonName As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents txtLatinName As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents itxtCount2 As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents lblCount2 As Label
    Friend WithEvents lblCost2 As Label
    Friend WithEvents ceCost2 As Syncfusion.Windows.Forms.Tools.CurrencyEdit
    Friend WithEvents pnlCultivar2 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents rbtnRegistered2 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
    Friend WithEvents lblCultivar2 As Label
    Friend WithEvents cboCultivar2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents txtPatent2 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtTradeName2 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents cboSource2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents cboFormat2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents cboCommonName2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents txtLatinName2 As Syncfusion.Windows.Forms.Tools.TextBoxExt
End Class
