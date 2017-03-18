<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReciept
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciept))
        Dim MetroSplitButtonRenderer1 As Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer = New Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer()
        Dim MetroSplitButtonRenderer2 As Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer = New Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer()
        Me.cbCompany = New Syncfusion.Windows.Forms.Tools.ComboBoxAutoComplete()
        Me.txtAddress1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtAddress2 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtCity = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtState = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtZip = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.grdItems = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlOrder = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.btnBillTo = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.dtReceived = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        Me.txtInvoiceNo = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.dtPaid = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        Me.dtOrdered = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        Me.lblDateReceived = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblDatePaid = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblInvoice = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblDateOrdered = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtShipping = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtHandling = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtTax = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtTotal = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.btnDeleteItem = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnAddItem = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.txtCountry = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.btnAddCompany = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.pnlMenu = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.btnSave = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.SplitButton1 = New Syncfusion.Windows.Forms.Tools.SplitButton()
        Me.sbtnNotes = New Syncfusion.Windows.Forms.Tools.SplitButton()
        CType(Me.cbCompany.AutoCompleteControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtZip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOrder.SuspendLayout()
        CType(Me.dtReceived, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPaid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrdered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShipping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHandling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCompany
        '
        '
        '
        '
        Me.cbCompany.AutoCompleteControl.ChangeDataManagerPosition = True
        Me.cbCompany.AutoCompleteControl.HeaderFont = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.cbCompany.AutoCompleteControl.ItemFont = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cbCompany.AutoCompleteControl.MetroColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.cbCompany.AutoCompleteControl.OverrideCombo = True
        Me.cbCompany.AutoCompleteControl.ParentForm = Me
        Me.cbCompany.AutoCompleteControl.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.[Default]
        Me.cbCompany.DropDownWidth = 121
        Me.cbCompany.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCompany.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cbCompany.Location = New System.Drawing.Point(14, 43)
        Me.cbCompany.Name = "cbCompany"
        Me.cbCompany.ParentForm = Me
        Me.cbCompany.Size = New System.Drawing.Size(306, 28)
        Me.cbCompany.TabIndex = 0
        Me.cbCompany.Tag = "Company"
        Me.cbCompany.Text = "Company"
        '
        'txtAddress1
        '
        Me.txtAddress1.BackColor = System.Drawing.Color.White
        Me.txtAddress1.BeforeTouchSize = New System.Drawing.Size(445, 27)
        Me.txtAddress1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtAddress1.Location = New System.Drawing.Point(13, 81)
        Me.txtAddress1.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(445, 27)
        Me.txtAddress1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtAddress1.TabIndex = 1
        Me.txtAddress1.Tag = "Address 1"
        Me.txtAddress1.Text = "Address 1"
        '
        'txtAddress2
        '
        Me.txtAddress2.BackColor = System.Drawing.Color.White
        Me.txtAddress2.BeforeTouchSize = New System.Drawing.Size(445, 27)
        Me.txtAddress2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtAddress2.Location = New System.Drawing.Point(13, 118)
        Me.txtAddress2.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(446, 27)
        Me.txtAddress2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtAddress2.TabIndex = 1
        Me.txtAddress2.Tag = "Address 2"
        Me.txtAddress2.Text = "Address 2"
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.BeforeTouchSize = New System.Drawing.Size(445, 27)
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCity.Location = New System.Drawing.Point(13, 156)
        Me.txtCity.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(90, 27)
        Me.txtCity.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtCity.TabIndex = 2
        Me.txtCity.Tag = "City"
        Me.txtCity.Text = "City"
        '
        'txtState
        '
        Me.txtState.BackColor = System.Drawing.Color.White
        Me.txtState.BeforeTouchSize = New System.Drawing.Size(445, 27)
        Me.txtState.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtState.Location = New System.Drawing.Point(111, 156)
        Me.txtState.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(45, 27)
        Me.txtState.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtState.TabIndex = 2
        Me.txtState.Tag = "State"
        Me.txtState.Text = "State"
        '
        'txtZip
        '
        Me.txtZip.BackColor = System.Drawing.Color.White
        Me.txtZip.BeforeTouchSize = New System.Drawing.Size(445, 27)
        Me.txtZip.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtZip.Location = New System.Drawing.Point(163, 156)
        Me.txtZip.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(76, 27)
        Me.txtZip.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtZip.TabIndex = 2
        Me.txtZip.Tag = "Zip Code"
        Me.txtZip.Text = "Zip Code"
        '
        'grdItems
        '
        Me.grdItems.AllowUserToAddRows = False
        Me.grdItems.AllowUserToDeleteRows = False
        Me.grdItems.AllowUserToResizeColumns = False
        Me.grdItems.AllowUserToResizeRows = False
        Me.grdItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdItems.BackgroundColor = System.Drawing.Color.White
        Me.grdItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdItems.CausesValidation = False
        Me.grdItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdItems.ColumnHeadersHeight = 25
        Me.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.Quantity, Me.Rate, Me.Amount})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdItems.DefaultCellStyle = DataGridViewCellStyle6
        Me.grdItems.Location = New System.Drawing.Point(13, 213)
        Me.grdItems.Margin = New System.Windows.Forms.Padding(0)
        Me.grdItems.MultiSelect = False
        Me.grdItems.Name = "grdItems"
        Me.grdItems.ReadOnly = True
        Me.grdItems.RowHeadersVisible = False
        Me.grdItems.RowTemplate.Height = 27
        Me.grdItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdItems.ShowEditingIcon = False
        Me.grdItems.Size = New System.Drawing.Size(1002, 261)
        Me.grdItems.TabIndex = 24
        '
        'Item
        '
        Me.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Item.DefaultCellStyle = DataGridViewCellStyle2
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        '
        'Quantity
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle3
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 150
        '
        'Rate
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Rate.DefaultCellStyle = DataGridViewCellStyle4
        Me.Rate.HeaderText = "Cost"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        Me.Rate.Width = 150
        '
        'Amount
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0"
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle5
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 150
        '
        'pnlOrder
        '
        Me.pnlOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOrder.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None
        Me.pnlOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOrder.Controls.Add(Me.btnBillTo)
        Me.pnlOrder.Controls.Add(Me.dtReceived)
        Me.pnlOrder.Controls.Add(Me.txtInvoiceNo)
        Me.pnlOrder.Controls.Add(Me.dtPaid)
        Me.pnlOrder.Controls.Add(Me.dtOrdered)
        Me.pnlOrder.Controls.Add(Me.lblDateReceived)
        Me.pnlOrder.Controls.Add(Me.lblDatePaid)
        Me.pnlOrder.Controls.Add(Me.lblInvoice)
        Me.pnlOrder.Controls.Add(Me.lblDateOrdered)
        Me.pnlOrder.Location = New System.Drawing.Point(632, 39)
        Me.pnlOrder.Name = "pnlOrder"
        Me.pnlOrder.Size = New System.Drawing.Size(385, 154)
        Me.pnlOrder.TabIndex = 25
        '
        'btnBillTo
        '
        Me.btnBillTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBillTo.BeforeTouchSize = New System.Drawing.Size(35, 35)
        Me.btnBillTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBillTo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillTo.IsBackStageButton = False
        Me.btnBillTo.Location = New System.Drawing.Point(598, -1)
        Me.btnBillTo.Name = "btnBillTo"
        Me.btnBillTo.Size = New System.Drawing.Size(35, 35)
        Me.btnBillTo.TabIndex = 2
        '
        'dtReceived
        '
        Me.dtReceived.AllowDrop = True
        Me.dtReceived.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtReceived.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
        Me.dtReceived.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.dtReceived.BorderColor = System.Drawing.Color.DarkGray
        Me.dtReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtReceived.CalendarForeColor = System.Drawing.SystemColors.ControlText
        Me.dtReceived.CalendarSize = New System.Drawing.Size(189, 176)
        Me.dtReceived.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.dtReceived.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText
        Me.dtReceived.DropDownImage = Nothing
        Me.dtReceived.DropDownNormalColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dtReceived.DropDownPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtReceived.DropDownSelectedColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.dtReceived.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtReceived.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.dtReceived.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtReceived.Location = New System.Drawing.Point(224, 115)
        Me.dtReceived.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtReceived.MinValue = New Date(CType(0, Long))
        Me.dtReceived.Name = "dtReceived"
        Me.dtReceived.ShowCheckBox = False
        Me.dtReceived.Size = New System.Drawing.Size(157, 31)
        Me.dtReceived.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        Me.dtReceived.TabIndex = 28
        Me.dtReceived.TabStop = False
        Me.dtReceived.Value = New Date(2013, 8, 14, 5, 21, 6, 502)
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.AllowDrop = True
        Me.txtInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInvoiceNo.BackColor = System.Drawing.Color.White
        Me.txtInvoiceNo.BeforeTouchSize = New System.Drawing.Size(445, 27)
        Me.txtInvoiceNo.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.txtInvoiceNo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtInvoiceNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtInvoiceNo.Location = New System.Drawing.Point(224, 77)
        Me.txtInvoiceNo.Metrocolor = System.Drawing.Color.Empty
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(157, 27)
        Me.txtInvoiceNo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtInvoiceNo.TabIndex = 27
        Me.txtInvoiceNo.TabStop = False
        Me.txtInvoiceNo.Text = "1234567890"
        '
        'dtPaid
        '
        Me.dtPaid.AllowDrop = True
        Me.dtPaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtPaid.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
        Me.dtPaid.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.dtPaid.BorderColor = System.Drawing.Color.DarkGray
        Me.dtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtPaid.CalendarForeColor = System.Drawing.SystemColors.ControlText
        Me.dtPaid.CalendarSize = New System.Drawing.Size(189, 176)
        Me.dtPaid.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.dtPaid.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText
        Me.dtPaid.DropDownImage = Nothing
        Me.dtPaid.DropDownNormalColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dtPaid.DropDownPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtPaid.DropDownSelectedColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.dtPaid.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPaid.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.dtPaid.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPaid.Location = New System.Drawing.Point(224, 40)
        Me.dtPaid.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtPaid.MinValue = New Date(CType(0, Long))
        Me.dtPaid.Name = "dtPaid"
        Me.dtPaid.ShowCheckBox = False
        Me.dtPaid.Size = New System.Drawing.Size(157, 31)
        Me.dtPaid.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        Me.dtPaid.TabIndex = 26
        Me.dtPaid.TabStop = False
        Me.dtPaid.Value = New Date(2013, 8, 14, 5, 21, 6, 502)
        '
        'dtOrdered
        '
        Me.dtOrdered.AllowDrop = True
        Me.dtOrdered.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtOrdered.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
        Me.dtOrdered.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.dtOrdered.BorderColor = System.Drawing.Color.DarkGray
        Me.dtOrdered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtOrdered.CalendarForeColor = System.Drawing.SystemColors.ControlText
        Me.dtOrdered.CalendarSize = New System.Drawing.Size(189, 176)
        Me.dtOrdered.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.dtOrdered.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText
        Me.dtOrdered.DropDownImage = Nothing
        Me.dtOrdered.DropDownNormalColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dtOrdered.DropDownPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtOrdered.DropDownSelectedColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.dtOrdered.FlatDropButton = True
        Me.dtOrdered.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtOrdered.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.dtOrdered.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtOrdered.Location = New System.Drawing.Point(224, 2)
        Me.dtOrdered.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtOrdered.MinValue = New Date(CType(0, Long))
        Me.dtOrdered.Name = "dtOrdered"
        Me.dtOrdered.ShowCheckBox = False
        Me.dtOrdered.Size = New System.Drawing.Size(157, 31)
        Me.dtOrdered.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        Me.dtOrdered.TabIndex = 26
        Me.dtOrdered.TabStop = False
        Me.dtOrdered.Value = New Date(2013, 8, 14, 5, 21, 6, 502)
        '
        'lblDateReceived
        '
        Me.lblDateReceived.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateReceived.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateReceived.Location = New System.Drawing.Point(28, 120)
        Me.lblDateReceived.Name = "lblDateReceived"
        Me.lblDateReceived.Size = New System.Drawing.Size(136, 23)
        Me.lblDateReceived.TabIndex = 24
        Me.lblDateReceived.Text = "DATE RECEIVED:"
        '
        'lblDatePaid
        '
        Me.lblDatePaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDatePaid.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatePaid.Location = New System.Drawing.Point(28, 45)
        Me.lblDatePaid.Name = "lblDatePaid"
        Me.lblDatePaid.Size = New System.Drawing.Size(98, 23)
        Me.lblDatePaid.TabIndex = 22
        Me.lblDatePaid.Text = "DATE PAID:"
        '
        'lblInvoice
        '
        Me.lblInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoice.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoice.Location = New System.Drawing.Point(28, 82)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(112, 23)
        Me.lblInvoice.TabIndex = 23
        Me.lblInvoice.Text = "INVOICE NO:"
        '
        'lblDateOrdered
        '
        Me.lblDateOrdered.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateOrdered.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOrdered.Location = New System.Drawing.Point(28, 7)
        Me.lblDateOrdered.Name = "lblDateOrdered"
        Me.lblDateOrdered.Size = New System.Drawing.Size(135, 23)
        Me.lblDateOrdered.TabIndex = 22
        Me.lblDateOrdered.Text = "DATE ORDERED:"
        '
        'txtShipping
        '
        Me.txtShipping.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShipping.BackColor = System.Drawing.Color.White
        Me.txtShipping.BeforeTouchSize = New System.Drawing.Size(445, 27)
        Me.txtShipping.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipping.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipping.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtShipping.Location = New System.Drawing.Point(807, 516)
        Me.txtShipping.Metrocolor = System.Drawing.Color.Empty
        Me.txtShipping.Name = "txtShipping"
        Me.txtShipping.ReadOnly = True
        Me.txtShipping.Size = New System.Drawing.Size(207, 27)
        Me.txtShipping.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtShipping.TabIndex = 29
        Me.txtShipping.TabStop = False
        Me.txtShipping.Tag = "Shipping Paid"
        Me.txtShipping.Text = "Shipping Paid"
        Me.txtShipping.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHandling
        '
        Me.txtHandling.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHandling.BackColor = System.Drawing.Color.White
        Me.txtHandling.BeforeTouchSize = New System.Drawing.Size(445, 27)
        Me.txtHandling.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHandling.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHandling.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtHandling.Location = New System.Drawing.Point(807, 554)
        Me.txtHandling.Metrocolor = System.Drawing.Color.Empty
        Me.txtHandling.Name = "txtHandling"
        Me.txtHandling.ReadOnly = True
        Me.txtHandling.Size = New System.Drawing.Size(207, 27)
        Me.txtHandling.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtHandling.TabIndex = 31
        Me.txtHandling.TabStop = False
        Me.txtHandling.Tag = "Handling Paid"
        Me.txtHandling.Text = "Handling Paid"
        Me.txtHandling.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTax
        '
        Me.txtTax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTax.BackColor = System.Drawing.Color.White
        Me.txtTax.BeforeTouchSize = New System.Drawing.Size(445, 27)
        Me.txtTax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTax.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtTax.Location = New System.Drawing.Point(807, 478)
        Me.txtTax.Metrocolor = System.Drawing.Color.Empty
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(207, 27)
        Me.txtTax.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtTax.TabIndex = 33
        Me.txtTax.TabStop = False
        Me.txtTax.Tag = "Tax Paid"
        Me.txtTax.Text = "Tax Paid"
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BeforeTouchSize = New System.Drawing.Size(445, 27)
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtTotal.Location = New System.Drawing.Point(807, 592)
        Me.txtTotal.Metrocolor = System.Drawing.Color.Empty
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(207, 27)
        Me.txtTotal.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtTotal.TabIndex = 33
        Me.txtTotal.TabStop = False
        Me.txtTotal.Tag = "Total Paid"
        Me.txtTotal.Text = "Total Paid"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteItem.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnDeleteItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnDeleteItem.BeforeTouchSize = New System.Drawing.Size(142, 52)
        Me.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteItem.IsBackStageButton = False
        Me.btnDeleteItem.Location = New System.Drawing.Point(163, 571)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(142, 52)
        Me.btnDeleteItem.TabIndex = 35
        Me.btnDeleteItem.Text = "Delete Item"
        '
        'btnAddItem
        '
        Me.btnAddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddItem.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnAddItem.BeforeTouchSize = New System.Drawing.Size(142, 52)
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddItem.IsBackStageButton = False
        Me.btnAddItem.Location = New System.Drawing.Point(14, 571)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(142, 52)
        Me.btnAddItem.TabIndex = 34
        Me.btnAddItem.Text = "Add Item"
        '
        'txtCountry
        '
        Me.txtCountry.BackColor = System.Drawing.Color.White
        Me.txtCountry.BeforeTouchSize = New System.Drawing.Size(445, 27)
        Me.txtCountry.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCountry.Location = New System.Drawing.Point(247, 156)
        Me.txtCountry.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(212, 27)
        Me.txtCountry.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtCountry.TabIndex = 2
        Me.txtCountry.Tag = "Country"
        Me.txtCountry.Text = "Country"
        '
        'btnAddCompany
        '
        Me.btnAddCompany.BackColor = System.Drawing.Color.Green
        Me.btnAddCompany.BeforeTouchSize = New System.Drawing.Size(132, 31)
        Me.btnAddCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCompany.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCompany.ForeColor = System.Drawing.Color.White
        Me.btnAddCompany.IsBackStageButton = False
        Me.btnAddCompany.Location = New System.Drawing.Point(328, 43)
        Me.btnAddCompany.Name = "btnAddCompany"
        Me.btnAddCompany.Size = New System.Drawing.Size(132, 31)
        Me.btnAddCompany.TabIndex = 36
        Me.btnAddCompany.Text = "Add Company"
        '
        'pnlMenu
        '
        Me.pnlMenu.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlMenu.Controls.Add(Me.btnSave)
        Me.pnlMenu.Controls.Add(Me.SplitButton1)
        Me.pnlMenu.Controls.Add(Me.sbtnNotes)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(1025, 32)
        Me.pnlMenu.TabIndex = 37
        '
        'btnSave
        '
        Me.btnSave.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSave.BeforeTouchSize = New System.Drawing.Size(26, 30)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.IsBackStageButton = False
        Me.btnSave.Location = New System.Drawing.Point(14, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(26, 30)
        Me.btnSave.TabIndex = 2
        '
        'SplitButton1
        '
        Me.SplitButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SplitButton1.BeforeTouchSize = New System.Drawing.Size(103, 27)
        Me.SplitButton1.DropDownIconColor = System.Drawing.Color.White
        Me.SplitButton1.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom
        Me.SplitButton1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitButton1.ForeColor = System.Drawing.Color.White
        Me.SplitButton1.Location = New System.Drawing.Point(138, 3)
        Me.SplitButton1.MinimumSize = New System.Drawing.Size(87, 27)
        Me.SplitButton1.Name = "SplitButton1"
        MetroSplitButtonRenderer1.SplitButton = Nothing
        Me.SplitButton1.Renderer = MetroSplitButtonRenderer1
        Me.SplitButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitButton1.ShowDropDownOnButtonClick = False
        Me.SplitButton1.Size = New System.Drawing.Size(103, 27)
        Me.SplitButton1.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro
        Me.SplitButton1.TabIndex = 1
        Me.SplitButton1.Text = "Attachments"
        '
        'sbtnNotes
        '
        Me.sbtnNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.sbtnNotes.BeforeTouchSize = New System.Drawing.Size(87, 27)
        Me.sbtnNotes.DropDownIconColor = System.Drawing.Color.White
        Me.sbtnNotes.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom
        Me.sbtnNotes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbtnNotes.ForeColor = System.Drawing.Color.White
        Me.sbtnNotes.Location = New System.Drawing.Point(43, 3)
        Me.sbtnNotes.MinimumSize = New System.Drawing.Size(87, 27)
        Me.sbtnNotes.Name = "sbtnNotes"
        MetroSplitButtonRenderer2.SplitButton = Nothing
        Me.sbtnNotes.Renderer = MetroSplitButtonRenderer2
        Me.sbtnNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.sbtnNotes.ShowDropDownOnButtonClick = False
        Me.sbtnNotes.Size = New System.Drawing.Size(87, 27)
        Me.sbtnNotes.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro
        Me.sbtnNotes.TabIndex = 1
        Me.sbtnNotes.Text = "Notes"
        '
        'frmReciept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CaptionFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientSize = New System.Drawing.Size(1025, 637)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.btnAddCompany)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtHandling)
        Me.Controls.Add(Me.txtShipping)
        Me.Controls.Add(Me.pnlOrder)
        Me.Controls.Add(Me.grdItems)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.cbCompany)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Name = "frmReciept"
        Me.Text = "Purchase"
        CType(Me.cbCompany.AutoCompleteControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtZip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOrder.ResumeLayout(False)
        Me.pnlOrder.PerformLayout()
        CType(Me.dtReceived, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPaid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrdered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShipping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHandling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCompany As Syncfusion.Windows.Forms.Tools.ComboBoxAutoComplete
    Friend WithEvents txtState As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtZip As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtCity As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtAddress2 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtAddress1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Private WithEvents grdItems As DataGridView
    Private WithEvents pnlOrder As Syncfusion.Windows.Forms.Tools.GradientPanel
    Private WithEvents btnBillTo As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents dtReceived As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
    Private WithEvents txtInvoiceNo As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Private WithEvents dtOrdered As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
    Private WithEvents lblDateReceived As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private WithEvents lblInvoice As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private WithEvents lblDateOrdered As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Private WithEvents dtPaid As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
    Private WithEvents lblDatePaid As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private WithEvents txtTotal As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Private WithEvents txtTax As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Private WithEvents txtHandling As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Private WithEvents txtShipping As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Private WithEvents btnDeleteItem As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents btnAddItem As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents txtCountry As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents btnAddCompany As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents pnlMenu As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents SplitButton1 As Syncfusion.Windows.Forms.Tools.SplitButton
    Friend WithEvents sbtnNotes As Syncfusion.Windows.Forms.Tools.SplitButton
    Friend WithEvents btnSave As Syncfusion.Windows.Forms.ButtonAdv
End Class
