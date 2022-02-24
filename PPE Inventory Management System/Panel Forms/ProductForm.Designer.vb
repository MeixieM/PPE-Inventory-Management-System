<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.dgv_Products = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tb_Description = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_Price = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_Quantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_ProdName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_productId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.bt_UploadImage = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TileButton1 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.cb_Category = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cb_unit = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bt_refresh = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pb_Product = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgv_Products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'dgv_Products
        '
        Me.dgv_Products.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Products.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Products.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Products.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_Products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Products.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Products.ColumnHeadersHeight = 30
        Me.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_Products.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Products.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Products.EnableHeadersVisualStyles = False
        Me.dgv_Products.GridColor = System.Drawing.Color.White
        Me.dgv_Products.Location = New System.Drawing.Point(246, 108)
        Me.dgv_Products.Name = "dgv_Products"
        Me.dgv_Products.RowHeadersVisible = False
        Me.dgv_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Products.Size = New System.Drawing.Size(858, 580)
        Me.dgv_Products.TabIndex = 1
        Me.dgv_Products.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgv_Products.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Products.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_Products.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_Products.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_Products.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_Products.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Products.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgv_Products.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.dgv_Products.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_Products.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Products.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_Products.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_Products.ThemeStyle.HeaderStyle.Height = 30
        Me.dgv_Products.ThemeStyle.ReadOnly = False
        Me.dgv_Products.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Products.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_Products.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Products.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_Products.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_Products.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Products.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'tb_Description
        '
        Me.tb_Description.BorderColor = System.Drawing.Color.Silver
        Me.tb_Description.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Description.DefaultText = ""
        Me.tb_Description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Description.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Description.DisabledState.Parent = Me.tb_Description
        Me.tb_Description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Description.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_Description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Description.FocusedState.Parent = Me.tb_Description
        Me.tb_Description.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Description.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_Description.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Description.HoverState.Parent = Me.tb_Description
        Me.tb_Description.Location = New System.Drawing.Point(19, 309)
        Me.tb_Description.Multiline = True
        Me.tb_Description.Name = "tb_Description"
        Me.tb_Description.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Description.PlaceholderText = ""
        Me.tb_Description.SelectedText = ""
        Me.tb_Description.ShadowDecoration.Parent = Me.tb_Description
        Me.tb_Description.Size = New System.Drawing.Size(200, 132)
        Me.tb_Description.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Product Description"
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
        Me.tb_Price.Location = New System.Drawing.Point(19, 262)
        Me.tb_Price.Name = "tb_Price"
        Me.tb_Price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Price.PlaceholderText = ""
        Me.tb_Price.SelectedText = ""
        Me.tb_Price.ShadowDecoration.Parent = Me.tb_Price
        Me.tb_Price.Size = New System.Drawing.Size(200, 23)
        Me.tb_Price.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 32
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
        Me.tb_Quantity.Location = New System.Drawing.Point(19, 460)
        Me.tb_Quantity.Name = "tb_Quantity"
        Me.tb_Quantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Quantity.PlaceholderText = ""
        Me.tb_Quantity.SelectedText = ""
        Me.tb_Quantity.ShadowDecoration.Parent = Me.tb_Quantity
        Me.tb_Quantity.Size = New System.Drawing.Size(76, 23)
        Me.tb_Quantity.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 444)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 30
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
        Me.tb_ProdName.Location = New System.Drawing.Point(19, 214)
        Me.tb_ProdName.Name = "tb_ProdName"
        Me.tb_ProdName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_ProdName.PlaceholderText = ""
        Me.tb_ProdName.SelectedText = ""
        Me.tb_ProdName.ShadowDecoration.Parent = Me.tb_ProdName
        Me.tb_ProdName.Size = New System.Drawing.Size(200, 23)
        Me.tb_ProdName.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 486)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Image"
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
        Me.tb_productId.Location = New System.Drawing.Point(19, 168)
        Me.tb_productId.Name = "tb_productId"
        Me.tb_productId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_productId.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_productId.PlaceholderText = ""
        Me.tb_productId.SelectedText = ""
        Me.tb_productId.ShadowDecoration.Parent = Me.tb_productId
        Me.tb_productId.Size = New System.Drawing.Size(200, 23)
        Me.tb_productId.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Product ID"
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
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(19, 661)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.ShadowDecoration.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(96, 27)
        Me.Guna2GradientButton1.TabIndex = 40
        Me.Guna2GradientButton1.Text = "DELETE"
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.Animated = True
        Me.Guna2GradientButton2.AutoRoundedCorners = True
        Me.Guna2GradientButton2.BorderRadius = 12
        Me.Guna2GradientButton2.CheckedState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.CustomImages.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientButton2.HoverState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(129, 661)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.ShadowDecoration.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(96, 27)
        Me.Guna2GradientButton2.TabIndex = 41
        Me.Guna2GradientButton2.Text = "UPDATE"
        '
        'bt_UploadImage
        '
        Me.bt_UploadImage.Animated = True
        Me.bt_UploadImage.BorderColor = System.Drawing.Color.White
        Me.bt_UploadImage.BorderRadius = 6
        Me.bt_UploadImage.CheckedState.Parent = Me.bt_UploadImage
        Me.bt_UploadImage.CustomImages.Parent = Me.bt_UploadImage
        Me.bt_UploadImage.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_UploadImage.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_UploadImage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_UploadImage.ForeColor = System.Drawing.Color.White
        Me.bt_UploadImage.HoverState.Parent = Me.bt_UploadImage
        Me.bt_UploadImage.Location = New System.Drawing.Point(50, 612)
        Me.bt_UploadImage.Name = "bt_UploadImage"
        Me.bt_UploadImage.ShadowDecoration.Parent = Me.bt_UploadImage
        Me.bt_UploadImage.Size = New System.Drawing.Size(142, 32)
        Me.bt_UploadImage.TabIndex = 43
        Me.bt_UploadImage.Text = "Upload Image"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 37)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Manage Product"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1092, 1)
        Me.Guna2Panel1.TabIndex = 45
        '
        'Guna2TileButton1
        '
        Me.Guna2TileButton1.CheckedState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.CustomImages.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Guna2TileButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2TileButton1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TileButton1.HoverState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.Location = New System.Drawing.Point(18, 63)
        Me.Guna2TileButton1.Name = "Guna2TileButton1"
        Me.Guna2TileButton1.ShadowDecoration.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.Size = New System.Drawing.Size(201, 31)
        Me.Guna2TileButton1.TabIndex = 46
        Me.Guna2TileButton1.Text = "Product Details"
        Me.Guna2TileButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.cb_Category.Location = New System.Drawing.Point(19, 113)
        Me.cb_Category.Name = "cb_Category"
        Me.cb_Category.ShadowDecoration.Parent = Me.cb_Category
        Me.cb_Category.Size = New System.Drawing.Size(200, 36)
        Me.cb_Category.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Category"
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
        Me.cb_unit.Location = New System.Drawing.Point(101, 460)
        Me.cb_unit.Name = "cb_unit"
        Me.cb_unit.ShadowDecoration.Parent = Me.cb_unit
        Me.cb_unit.Size = New System.Drawing.Size(118, 36)
        Me.cb_unit.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(98, 444)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Unit"
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
        Me.tb_search.Location = New System.Drawing.Point(246, 63)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_search.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_search.PlaceholderText = "Search"
        Me.tb_search.SelectedText = ""
        Me.tb_search.ShadowDecoration.Parent = Me.tb_search
        Me.tb_search.Size = New System.Drawing.Size(242, 31)
        Me.tb_search.TabIndex = 47
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
        Me.bt_refresh.Location = New System.Drawing.Point(922, 63)
        Me.bt_refresh.Name = "bt_refresh"
        Me.bt_refresh.ShadowDecoration.Parent = Me.bt_refresh
        Me.bt_refresh.Size = New System.Drawing.Size(38, 32)
        Me.bt_refresh.TabIndex = 42
        '
        'pb_Product
        '
        Me.pb_Product.BackColor = System.Drawing.Color.Transparent
        Me.pb_Product.BorderRadius = 1
        Me.pb_Product.FillColor = System.Drawing.Color.DimGray
        Me.pb_Product.Image = Global.PPE_Inventory_Management_System.My.Resources.Resources.add_image
        Me.pb_Product.Location = New System.Drawing.Point(50, 502)
        Me.pb_Product.Name = "pb_Product"
        Me.pb_Product.ShadowDecoration.Parent = Me.pb_Product
        Me.pb_Product.Size = New System.Drawing.Size(142, 104)
        Me.pb_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Product.TabIndex = 36
        Me.pb_Product.TabStop = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BorderRadius = 6
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = Global.PPE_Inventory_Management_System.My.Resources.Resources.add_new_48px
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button1.Location = New System.Drawing.Point(965, 63)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(139, 33)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "Add New Product"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(-8, 0)
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1116, 700)
        Me.Controls.Add(Me.cb_unit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cb_Category)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_search)
        Me.Controls.Add(Me.Guna2TileButton1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bt_UploadImage)
        Me.Controls.Add(Me.bt_refresh)
        Me.Controls.Add(Me.Guna2GradientButton2)
        Me.Controls.Add(Me.Guna2GradientButton1)
        Me.Controls.Add(Me.tb_productId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb_Product)
        Me.Controls.Add(Me.tb_Description)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_Price)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_Quantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_ProdName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_Products)
        Me.Controls.Add(Me.Guna2Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductForm"
        Me.Text = "ProductForm"
        CType(Me.dgv_Products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgv_Products As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pb_Product As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents tb_Description As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_Price As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_Quantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_ProdName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_productId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents bt_refresh As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents bt_UploadImage As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2TileButton1 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents tb_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cb_Category As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cb_unit As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
End Class
