<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewProd))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_ProdName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_Quantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_Price = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_Description = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_Category = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.bt_UploadImage = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pb_Product = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.cb_unit = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.pb_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Product Details"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(513, 8)
        Me.Guna2GradientPanel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product Name"
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
        Me.tb_ProdName.Location = New System.Drawing.Point(29, 156)
        Me.tb_ProdName.Name = "tb_ProdName"
        Me.tb_ProdName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_ProdName.PlaceholderText = ""
        Me.tb_ProdName.SelectedText = ""
        Me.tb_ProdName.ShadowDecoration.Parent = Me.tb_ProdName
        Me.tb_ProdName.Size = New System.Drawing.Size(200, 23)
        Me.tb_ProdName.TabIndex = 4
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
        Me.tb_Quantity.Location = New System.Drawing.Point(30, 204)
        Me.tb_Quantity.Name = "tb_Quantity"
        Me.tb_Quantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Quantity.PlaceholderText = ""
        Me.tb_Quantity.SelectedText = ""
        Me.tb_Quantity.ShadowDecoration.Parent = Me.tb_Quantity
        Me.tb_Quantity.Size = New System.Drawing.Size(68, 25)
        Me.tb_Quantity.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Quantity"
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
        Me.tb_Price.Location = New System.Drawing.Point(30, 256)
        Me.tb_Price.Name = "tb_Price"
        Me.tb_Price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Price.PlaceholderText = ""
        Me.tb_Price.SelectedText = ""
        Me.tb_Price.ShadowDecoration.Parent = Me.tb_Price
        Me.tb_Price.Size = New System.Drawing.Size(200, 23)
        Me.tb_Price.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Category"
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
        Me.tb_Description.Location = New System.Drawing.Point(30, 309)
        Me.tb_Description.Multiline = True
        Me.tb_Description.Name = "tb_Description"
        Me.tb_Description.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Description.PlaceholderText = ""
        Me.tb_Description.SelectedText = ""
        Me.tb_Description.ShadowDecoration.Parent = Me.tb_Description
        Me.tb_Description.Size = New System.Drawing.Size(200, 135)
        Me.tb_Description.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Product Description"
        '
        'cb_Category
        '
        Me.cb_Category.Animated = True
        Me.cb_Category.BackColor = System.Drawing.Color.Transparent
        Me.cb_Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Category.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.cb_Category.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_Category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_Category.FocusedState.Parent = Me.cb_Category
        Me.cb_Category.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_Category.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_Category.HoverState.Parent = Me.cb_Category
        Me.cb_Category.ItemHeight = 30
        Me.cb_Category.ItemsAppearance.Parent = Me.cb_Category
        Me.cb_Category.Location = New System.Drawing.Point(30, 98)
        Me.cb_Category.Name = "cb_Category"
        Me.cb_Category.ShadowDecoration.Parent = Me.cb_Category
        Me.cb_Category.Size = New System.Drawing.Size(200, 36)
        Me.cb_Category.TabIndex = 21
        '
        'bt_UploadImage
        '
        Me.bt_UploadImage.Animated = True
        Me.bt_UploadImage.BorderRadius = 6
        Me.bt_UploadImage.CheckedState.Parent = Me.bt_UploadImage
        Me.bt_UploadImage.CustomImages.Parent = Me.bt_UploadImage
        Me.bt_UploadImage.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_UploadImage.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_UploadImage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.bt_UploadImage.ForeColor = System.Drawing.Color.LightGray
        Me.bt_UploadImage.HoverState.Parent = Me.bt_UploadImage
        Me.bt_UploadImage.Location = New System.Drawing.Point(278, 240)
        Me.bt_UploadImage.Name = "bt_UploadImage"
        Me.bt_UploadImage.ShadowDecoration.Parent = Me.bt_UploadImage
        Me.bt_UploadImage.Size = New System.Drawing.Size(200, 32)
        Me.bt_UploadImage.TabIndex = 27
        Me.bt_UploadImage.Text = "Upload Image"
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.Animated = True
        Me.Guna2GradientButton2.BorderRadius = 8
        Me.Guna2GradientButton2.CheckedState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.CustomImages.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientButton2.HoverState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(377, 412)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.ShadowDecoration.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(101, 32)
        Me.Guna2GradientButton2.TabIndex = 28
        Me.Guna2GradientButton2.Text = "SAVE"
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.BackColor = System.Drawing.Color.Silver
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(12, 55)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.Parent = Me.Guna2GradientPanel2
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(492, 1)
        Me.Guna2GradientPanel2.TabIndex = 2
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.ContainerControl = Me
        Me.Guna2DragControl1.TargetControl = Me.Guna2GradientPanel1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(275, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Image"
        '
        'pb_Product
        '
        Me.pb_Product.BackColor = System.Drawing.Color.Transparent
        Me.pb_Product.BorderRadius = 1
        Me.pb_Product.FillColor = System.Drawing.Color.White
        Me.pb_Product.Image = Global.PPE_Inventory_Management_System.My.Resources.Resources.add_image1
        Me.pb_Product.Location = New System.Drawing.Point(278, 98)
        Me.pb_Product.Name = "pb_Product"
        Me.pb_Product.ShadowDecoration.Parent = Me.pb_Product
        Me.pb_Product.Size = New System.Drawing.Size(200, 125)
        Me.pb_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Product.TabIndex = 26
        Me.pb_Product.TabStop = False
        Me.pb_Product.UseTransparentBackground = True
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = Global.PPE_Inventory_Management_System.My.Resources.Resources.left_50px2
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button1.Location = New System.Drawing.Point(4, 26)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(46, 25)
        Me.Guna2Button1.TabIndex = 2
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label7)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2GradientButton2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.cb_unit)
        Me.Guna2ShadowPanel1.Controls.Add(Me.cb_Category)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label5)
        Me.Guna2ShadowPanel1.Controls.Add(Me.bt_UploadImage)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label8)
        Me.Guna2ShadowPanel1.Controls.Add(Me.tb_ProdName)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.tb_Price)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label4)
        Me.Guna2ShadowPanel1.Controls.Add(Me.tb_Description)
        Me.Guna2ShadowPanel1.Controls.Add(Me.tb_Quantity)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label6)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.pb_Product)
        Me.Guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowDepth = 200
        Me.Guna2ShadowPanel1.ShadowShift = 3
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(513, 464)
        Me.Guna2ShadowPanel1.TabIndex = 30
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
        Me.cb_unit.Location = New System.Drawing.Point(104, 204)
        Me.cb_unit.Name = "cb_unit"
        Me.cb_unit.ShadowDecoration.Parent = Me.cb_unit
        Me.cb_unit.Size = New System.Drawing.Size(131, 36)
        Me.cb_unit.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(104, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Unit"
        '
        'AddNewProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 464)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddNewProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddNewProd"
        CType(Me.pb_Product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tb_ProdName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_Price As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_Quantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_Description As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_Category As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents bt_UploadImage As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pb_Product As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents cb_unit As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
End Class
