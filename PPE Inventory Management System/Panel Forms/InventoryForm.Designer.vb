<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgv_inv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cb_unit = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cb_Category = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2TileButton1 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.tb_productId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_Price = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_Quantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_ProdName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_available = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtp_date = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dgv_inventory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2TileButton2 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2GradientButton3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.tb_total = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Guna2GradientButton4 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.tb_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bt_refresh = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.dgv_inv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(242, 37)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Manage Inventory"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Location = New System.Drawing.Point(19, 49)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1092, 2)
        Me.Guna2Panel1.TabIndex = 46
        '
        'dgv_inv
        '
        Me.dgv_inv.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_inv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_inv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_inv.BackgroundColor = System.Drawing.Color.White
        Me.dgv_inv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_inv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_inv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_inv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_inv.ColumnHeadersHeight = 30
        Me.dgv_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_inv.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_inv.EnableHeadersVisualStyles = False
        Me.dgv_inv.GridColor = System.Drawing.Color.White
        Me.dgv_inv.Location = New System.Drawing.Point(354, 523)
        Me.dgv_inv.Name = "dgv_inv"
        Me.dgv_inv.RowHeadersVisible = False
        Me.dgv_inv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_inv.Size = New System.Drawing.Size(750, 165)
        Me.dgv_inv.TabIndex = 54
        Me.dgv_inv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgv_inv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_inv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_inv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_inv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_inv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_inv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_inv.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgv_inv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgv_inv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_inv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_inv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_inv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_inv.ThemeStyle.HeaderStyle.Height = 30
        Me.dgv_inv.ThemeStyle.ReadOnly = False
        Me.dgv_inv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_inv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_inv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_inv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_inv.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_inv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_inv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cb_unit
        '
        Me.cb_unit.BackColor = System.Drawing.Color.Transparent
        Me.cb_unit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_unit.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.cb_unit.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_unit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_unit.FocusedState.Parent = Me.cb_unit
        Me.cb_unit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cb_unit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_unit.HoverState.Parent = Me.cb_unit
        Me.cb_unit.ItemHeight = 30
        Me.cb_unit.Items.AddRange(New Object() {"pcs", "pack", "pack of 10", "pack of 50", "pack of 100", "box", "box(50pcs)", "box(100pcs)", "gallon", "ml"})
        Me.cb_unit.ItemsAppearance.Parent = Me.cb_unit
        Me.cb_unit.Location = New System.Drawing.Point(135, 314)
        Me.cb_unit.Name = "cb_unit"
        Me.cb_unit.ShadowDecoration.Parent = Me.cb_unit
        Me.cb_unit.Size = New System.Drawing.Size(159, 36)
        Me.cb_unit.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(132, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Unit"
        '
        'cb_Category
        '
        Me.cb_Category.BackColor = System.Drawing.Color.Transparent
        Me.cb_Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Category.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.cb_Category.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_Category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_Category.FocusedState.Parent = Me.cb_Category
        Me.cb_Category.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_Category.ForeColor = System.Drawing.Color.Black
        Me.cb_Category.HoverState.Parent = Me.cb_Category
        Me.cb_Category.ItemHeight = 30
        Me.cb_Category.ItemsAppearance.Parent = Me.cb_Category
        Me.cb_Category.Location = New System.Drawing.Point(53, 118)
        Me.cb_Category.Name = "cb_Category"
        Me.cb_Category.ShadowDecoration.Parent = Me.cb_Category
        Me.cb_Category.Size = New System.Drawing.Size(241, 36)
        Me.cb_Category.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(50, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Category"
        '
        'Guna2TileButton1
        '
        Me.Guna2TileButton1.CheckedState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.CustomImages.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Guna2TileButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2TileButton1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TileButton1.HoverState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.Location = New System.Drawing.Point(53, 57)
        Me.Guna2TileButton1.Name = "Guna2TileButton1"
        Me.Guna2TileButton1.ShadowDecoration.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.Size = New System.Drawing.Size(242, 31)
        Me.Guna2TileButton1.TabIndex = 68
        Me.Guna2TileButton1.Text = "Product Details"
        Me.Guna2TileButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_productId
        '
        Me.tb_productId.BorderColor = System.Drawing.Color.Silver
        Me.tb_productId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_productId.DefaultText = ""
        Me.tb_productId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_productId.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_productId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_productId.DisabledState.Parent = Me.tb_productId
        Me.tb_productId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_productId.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_productId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_productId.FocusedState.Parent = Me.tb_productId
        Me.tb_productId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_productId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_productId.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_productId.HoverState.Parent = Me.tb_productId
        Me.tb_productId.Location = New System.Drawing.Point(53, 173)
        Me.tb_productId.Name = "tb_productId"
        Me.tb_productId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_productId.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_productId.PlaceholderText = ""
        Me.tb_productId.ReadOnly = True
        Me.tb_productId.SelectedText = ""
        Me.tb_productId.ShadowDecoration.Parent = Me.tb_productId
        Me.tb_productId.Size = New System.Drawing.Size(241, 23)
        Me.tb_productId.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Product ID"
        '
        'tb_Price
        '
        Me.tb_Price.BorderColor = System.Drawing.Color.Silver
        Me.tb_Price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Price.DefaultText = ""
        Me.tb_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Price.DisabledState.Parent = Me.tb_Price
        Me.tb_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Price.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Price.FocusedState.Parent = Me.tb_Price
        Me.tb_Price.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_Price.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Price.HoverState.Parent = Me.tb_Price
        Me.tb_Price.Location = New System.Drawing.Point(53, 267)
        Me.tb_Price.Name = "tb_Price"
        Me.tb_Price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Price.PlaceholderText = ""
        Me.tb_Price.SelectedText = ""
        Me.tb_Price.ShadowDecoration.Parent = Me.tb_Price
        Me.tb_Price.Size = New System.Drawing.Size(241, 23)
        Me.tb_Price.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Price"
        '
        'tb_Quantity
        '
        Me.tb_Quantity.BorderColor = System.Drawing.Color.Silver
        Me.tb_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Quantity.DefaultText = ""
        Me.tb_Quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Quantity.DisabledState.Parent = Me.tb_Quantity
        Me.tb_Quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Quantity.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_Quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Quantity.FocusedState.Parent = Me.tb_Quantity
        Me.tb_Quantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_Quantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_Quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Quantity.HoverState.Parent = Me.tb_Quantity
        Me.tb_Quantity.Location = New System.Drawing.Point(53, 314)
        Me.tb_Quantity.Name = "tb_Quantity"
        Me.tb_Quantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Quantity.PlaceholderText = ""
        Me.tb_Quantity.SelectedText = ""
        Me.tb_Quantity.ShadowDecoration.Parent = Me.tb_Quantity
        Me.tb_Quantity.Size = New System.Drawing.Size(76, 23)
        Me.tb_Quantity.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Quantity"
        '
        'tb_ProdName
        '
        Me.tb_ProdName.BorderColor = System.Drawing.Color.Silver
        Me.tb_ProdName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_ProdName.DefaultText = ""
        Me.tb_ProdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_ProdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_ProdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_ProdName.DisabledState.Parent = Me.tb_ProdName
        Me.tb_ProdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_ProdName.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_ProdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_ProdName.FocusedState.Parent = Me.tb_ProdName
        Me.tb_ProdName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_ProdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_ProdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_ProdName.HoverState.Parent = Me.tb_ProdName
        Me.tb_ProdName.Location = New System.Drawing.Point(53, 219)
        Me.tb_ProdName.Name = "tb_ProdName"
        Me.tb_ProdName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_ProdName.PlaceholderText = ""
        Me.tb_ProdName.SelectedText = ""
        Me.tb_ProdName.ShadowDecoration.Parent = Me.tb_ProdName
        Me.tb_ProdName.Size = New System.Drawing.Size(241, 23)
        Me.tb_ProdName.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Product Name"
        '
        'tb_available
        '
        Me.tb_available.BackColor = System.Drawing.Color.Transparent
        Me.tb_available.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tb_available.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tb_available.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_available.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_available.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_available.FocusedState.Parent = Me.tb_available
        Me.tb_available.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_available.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tb_available.HoverState.Parent = Me.tb_available
        Me.tb_available.ItemHeight = 30
        Me.tb_available.Items.AddRange(New Object() {"In Stock", "Out of Stock"})
        Me.tb_available.ItemsAppearance.Parent = Me.tb_available
        Me.tb_available.Location = New System.Drawing.Point(59, 370)
        Me.tb_available.Name = "tb_available"
        Me.tb_available.ShadowDecoration.Parent = Me.tb_available
        Me.tb_available.Size = New System.Drawing.Size(235, 36)
        Me.tb_available.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Availability"
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.Animated = True
        Me.Guna2GradientButton2.AutoRoundedCorners = True
        Me.Guna2GradientButton2.BorderRadius = 12
        Me.Guna2GradientButton2.CheckedState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.CustomImages.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientButton2.HoverState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(58, 584)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.ShadowDecoration.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(102, 27)
        Me.Guna2GradientButton2.TabIndex = 76
        Me.Guna2GradientButton2.Text = "UPDATE"
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.Animated = True
        Me.Guna2GradientButton1.AutoRoundedCorners = True
        Me.Guna2GradientButton1.BorderRadius = 12
        Me.Guna2GradientButton1.CheckedState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.CustomImages.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientButton1.HoverState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(117, 626)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.ShadowDecoration.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(104, 27)
        Me.Guna2GradientButton1.TabIndex = 75
        Me.Guna2GradientButton1.Text = "DELETE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(56, 477)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Purchase Date"
        '
        'dtp_date
        '
        Me.dtp_date.CheckedState.Parent = Me.dtp_date
        Me.dtp_date.CustomFormat = "MM/dd/yyyy"
        Me.dtp_date.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dtp_date.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_date.HoverState.Parent = Me.dtp_date
        Me.dtp_date.Location = New System.Drawing.Point(59, 493)
        Me.dtp_date.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_date.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.ShadowDecoration.Parent = Me.dtp_date
        Me.dtp_date.Size = New System.Drawing.Size(235, 24)
        Me.dtp_date.TabIndex = 80
        Me.dtp_date.Value = New Date(2021, 4, 10, 3, 40, 35, 238)
        '
        'dgv_inventory
        '
        Me.dgv_inventory.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_inventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_inventory.BackgroundColor = System.Drawing.Color.White
        Me.dgv_inventory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_inventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_inventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_inventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_inventory.ColumnHeadersHeight = 30
        Me.dgv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_inventory.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_inventory.EnableHeadersVisualStyles = False
        Me.dgv_inventory.GridColor = System.Drawing.Color.White
        Me.dgv_inventory.Location = New System.Drawing.Point(354, 94)
        Me.dgv_inventory.Name = "dgv_inventory"
        Me.dgv_inventory.RowHeadersVisible = False
        Me.dgv_inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_inventory.Size = New System.Drawing.Size(775, 385)
        Me.dgv_inventory.TabIndex = 82
        Me.dgv_inventory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgv_inventory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_inventory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_inventory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_inventory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_inventory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_inventory.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_inventory.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgv_inventory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.dgv_inventory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_inventory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_inventory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_inventory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_inventory.ThemeStyle.HeaderStyle.Height = 30
        Me.dgv_inventory.ThemeStyle.ReadOnly = False
        Me.dgv_inventory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_inventory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_inventory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_inventory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_inventory.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_inventory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_inventory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2TileButton2
        '
        Me.Guna2TileButton2.CheckedState.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.CustomImages.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Guna2TileButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2TileButton2.ForeColor = System.Drawing.Color.Black
        Me.Guna2TileButton2.HoverState.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.Location = New System.Drawing.Point(354, 485)
        Me.Guna2TileButton2.Name = "Guna2TileButton2"
        Me.Guna2TileButton2.ShadowDecoration.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.Size = New System.Drawing.Size(176, 31)
        Me.Guna2TileButton2.TabIndex = 83
        Me.Guna2TileButton2.Text = "Select Product"
        Me.Guna2TileButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2GradientButton3
        '
        Me.Guna2GradientButton3.Animated = True
        Me.Guna2GradientButton3.AutoRoundedCorners = True
        Me.Guna2GradientButton3.BorderRadius = 12
        Me.Guna2GradientButton3.CheckedState.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.CustomImages.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2GradientButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton3.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientButton3.HoverState.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.Location = New System.Drawing.Point(189, 584)
        Me.Guna2GradientButton3.Name = "Guna2GradientButton3"
        Me.Guna2GradientButton3.ShadowDecoration.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.Size = New System.Drawing.Size(104, 27)
        Me.Guna2GradientButton3.TabIndex = 84
        Me.Guna2GradientButton3.Text = "ADD"
        '
        'tb_total
        '
        Me.tb_total.BorderColor = System.Drawing.Color.Silver
        Me.tb_total.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_total.DefaultText = ""
        Me.tb_total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_total.DisabledState.Parent = Me.tb_total
        Me.tb_total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_total.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_total.FocusedState.Parent = Me.tb_total
        Me.tb_total.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_total.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_total.HoverState.Parent = Me.tb_total
        Me.tb_total.Location = New System.Drawing.Point(59, 430)
        Me.tb_total.Name = "tb_total"
        Me.tb_total.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_total.PlaceholderText = ""
        Me.tb_total.ReadOnly = True
        Me.tb_total.SelectedText = ""
        Me.tb_total.ShadowDecoration.Parent = Me.tb_total
        Me.tb_total.Size = New System.Drawing.Size(235, 23)
        Me.tb_total.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Total"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Guna2GradientButton4
        '
        Me.Guna2GradientButton4.Animated = True
        Me.Guna2GradientButton4.AutoRoundedCorners = True
        Me.Guna2GradientButton4.BorderRadius = 12
        Me.Guna2GradientButton4.CheckedState.Parent = Me.Guna2GradientButton4
        Me.Guna2GradientButton4.CustomImages.Parent = Me.Guna2GradientButton4
        Me.Guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2GradientButton4.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2GradientButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton4.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientButton4.HoverState.Parent = Me.Guna2GradientButton4
        Me.Guna2GradientButton4.Image = Global.PPE_Inventory_Management_System.My.Resources.Resources.print_48px
        Me.Guna2GradientButton4.Location = New System.Drawing.Point(1019, 61)
        Me.Guna2GradientButton4.Name = "Guna2GradientButton4"
        Me.Guna2GradientButton4.ShadowDecoration.Parent = Me.Guna2GradientButton4
        Me.Guna2GradientButton4.Size = New System.Drawing.Size(85, 27)
        Me.Guna2GradientButton4.TabIndex = 87
        Me.Guna2GradientButton4.Text = "Print"
        '
        'tb_search
        '
        Me.tb_search.BorderColor = System.Drawing.Color.Silver
        Me.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_search.DefaultText = ""
        Me.tb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_search.DisabledState.Parent = Me.tb_search
        Me.tb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_search.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_search.FocusedState.Parent = Me.tb_search
        Me.tb_search.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_search.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_search.HoverState.Parent = Me.tb_search
        Me.tb_search.IconLeft = Global.PPE_Inventory_Management_System.My.Resources.Resources.search_64px
        Me.tb_search.Location = New System.Drawing.Point(354, 57)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_search.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_search.PlaceholderText = "Search"
        Me.tb_search.SelectedText = ""
        Me.tb_search.ShadowDecoration.Parent = Me.tb_search
        Me.tb_search.Size = New System.Drawing.Size(235, 31)
        Me.tb_search.TabIndex = 81
        '
        'bt_refresh
        '
        Me.bt_refresh.Animated = True
        Me.bt_refresh.BorderRadius = 6
        Me.bt_refresh.CheckedState.Parent = Me.bt_refresh
        Me.bt_refresh.CustomImages.Parent = Me.bt_refresh
        Me.bt_refresh.FillColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.bt_refresh.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_refresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_refresh.ForeColor = System.Drawing.Color.White
        Me.bt_refresh.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.bt_refresh.HoverState.Parent = Me.bt_refresh
        Me.bt_refresh.Image = Global.PPE_Inventory_Management_System.My.Resources.Resources.refresh_64px
        Me.bt_refresh.ImageSize = New System.Drawing.Size(25, 25)
        Me.bt_refresh.Location = New System.Drawing.Point(595, 57)
        Me.bt_refresh.Name = "bt_refresh"
        Me.bt_refresh.ShadowDecoration.Parent = Me.bt_refresh
        Me.bt_refresh.Size = New System.Drawing.Size(38, 31)
        Me.bt_refresh.TabIndex = 56
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 700)
        Me.Controls.Add(Me.Guna2GradientButton4)
        Me.Controls.Add(Me.tb_total)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Guna2GradientButton3)
        Me.Controls.Add(Me.Guna2TileButton2)
        Me.Controls.Add(Me.dgv_inventory)
        Me.Controls.Add(Me.tb_search)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Guna2GradientButton2)
        Me.Controls.Add(Me.Guna2GradientButton1)
        Me.Controls.Add(Me.tb_available)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_unit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cb_Category)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Guna2TileButton1)
        Me.Controls.Add(Me.tb_productId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_Price)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_Quantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_ProdName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bt_refresh)
        Me.Controls.Add(Me.dgv_inv)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InventoryForm"
        Me.Text = "InventoryForm"
        CType(Me.dgv_inv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgv_inv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents bt_refresh As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents cb_unit As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cb_Category As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2TileButton1 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents tb_productId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_Price As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_Quantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_ProdName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_available As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_date As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tb_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TileButton2 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents dgv_inventory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2GradientButton3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tb_total As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2GradientButton4 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
