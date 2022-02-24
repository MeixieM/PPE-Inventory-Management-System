<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupplierForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2TileButton1 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.tb_supplierID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.id = New System.Windows.Forms.Label()
        Me.dgv_suppliers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tb_supplierName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lb_name = New System.Windows.Forms.Label()
        Me.tb_email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lb_email = New System.Windows.Forms.Label()
        Me.tb_contact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lb_contact = New System.Windows.Forms.Label()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.tb_address = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bt_refresh = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.tb_description = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientButton4 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgv_suppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 45)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1092, 1)
        Me.Guna2Panel1.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 37)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Suppliers"
        '
        'Guna2TileButton1
        '
        Me.Guna2TileButton1.CheckedState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.CustomImages.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Guna2TileButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2TileButton1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TileButton1.HoverState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.Location = New System.Drawing.Point(12, 73)
        Me.Guna2TileButton1.Name = "Guna2TileButton1"
        Me.Guna2TileButton1.ShadowDecoration.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.Size = New System.Drawing.Size(266, 32)
        Me.Guna2TileButton1.TabIndex = 50
        Me.Guna2TileButton1.Text = "Supplier Details"
        Me.Guna2TileButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_supplierID
        '
        Me.tb_supplierID.BorderColor = System.Drawing.Color.Silver
        Me.tb_supplierID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_supplierID.DefaultText = ""
        Me.tb_supplierID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_supplierID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_supplierID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_supplierID.DisabledState.Parent = Me.tb_supplierID
        Me.tb_supplierID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_supplierID.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_supplierID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_supplierID.FocusedState.Parent = Me.tb_supplierID
        Me.tb_supplierID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_supplierID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_supplierID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_supplierID.HoverState.Parent = Me.tb_supplierID
        Me.tb_supplierID.Location = New System.Drawing.Point(39, 146)
        Me.tb_supplierID.Name = "tb_supplierID"
        Me.tb_supplierID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_supplierID.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_supplierID.PlaceholderText = ""
        Me.tb_supplierID.SelectedText = ""
        Me.tb_supplierID.ShadowDecoration.Parent = Me.tb_supplierID
        Me.tb_supplierID.Size = New System.Drawing.Size(200, 23)
        Me.tb_supplierID.TabIndex = 49
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(36, 130)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(64, 13)
        Me.id.TabIndex = 48
        Me.id.Text = "Supplier ID"
        '
        'dgv_suppliers
        '
        Me.dgv_suppliers.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_suppliers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_suppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_suppliers.BackgroundColor = System.Drawing.Color.White
        Me.dgv_suppliers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_suppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_suppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_suppliers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_suppliers.ColumnHeadersHeight = 30
        Me.dgv_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_suppliers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_suppliers.EnableHeadersVisualStyles = False
        Me.dgv_suppliers.GridColor = System.Drawing.Color.White
        Me.dgv_suppliers.Location = New System.Drawing.Point(303, 114)
        Me.dgv_suppliers.Name = "dgv_suppliers"
        Me.dgv_suppliers.RowHeadersVisible = False
        Me.dgv_suppliers.RowTemplate.Height = 40
        Me.dgv_suppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_suppliers.Size = New System.Drawing.Size(803, 573)
        Me.dgv_suppliers.TabIndex = 52
        Me.dgv_suppliers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgv_suppliers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_suppliers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_suppliers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_suppliers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_suppliers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_suppliers.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_suppliers.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgv_suppliers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.dgv_suppliers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_suppliers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_suppliers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_suppliers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_suppliers.ThemeStyle.HeaderStyle.Height = 30
        Me.dgv_suppliers.ThemeStyle.ReadOnly = False
        Me.dgv_suppliers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_suppliers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_suppliers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_suppliers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_suppliers.ThemeStyle.RowsStyle.Height = 40
        Me.dgv_suppliers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_suppliers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'tb_supplierName
        '
        Me.tb_supplierName.BorderColor = System.Drawing.Color.Silver
        Me.tb_supplierName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_supplierName.DefaultText = ""
        Me.tb_supplierName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_supplierName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_supplierName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_supplierName.DisabledState.Parent = Me.tb_supplierName
        Me.tb_supplierName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_supplierName.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_supplierName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_supplierName.FocusedState.Parent = Me.tb_supplierName
        Me.tb_supplierName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_supplierName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_supplierName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_supplierName.HoverState.Parent = Me.tb_supplierName
        Me.tb_supplierName.Location = New System.Drawing.Point(39, 193)
        Me.tb_supplierName.Name = "tb_supplierName"
        Me.tb_supplierName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_supplierName.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_supplierName.PlaceholderText = ""
        Me.tb_supplierName.SelectedText = ""
        Me.tb_supplierName.ShadowDecoration.Parent = Me.tb_supplierName
        Me.tb_supplierName.Size = New System.Drawing.Size(200, 23)
        Me.tb_supplierName.TabIndex = 56
        '
        'lb_name
        '
        Me.lb_name.AutoSize = True
        Me.lb_name.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_name.Location = New System.Drawing.Point(36, 177)
        Me.lb_name.Name = "lb_name"
        Me.lb_name.Size = New System.Drawing.Size(82, 13)
        Me.lb_name.TabIndex = 55
        Me.lb_name.Text = "Supplier Name"
        '
        'tb_email
        '
        Me.tb_email.BorderColor = System.Drawing.Color.Silver
        Me.tb_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_email.DefaultText = ""
        Me.tb_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_email.DisabledState.Parent = Me.tb_email
        Me.tb_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_email.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_email.FocusedState.Parent = Me.tb_email
        Me.tb_email.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_email.HoverState.Parent = Me.tb_email
        Me.tb_email.Location = New System.Drawing.Point(39, 239)
        Me.tb_email.Name = "tb_email"
        Me.tb_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_email.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_email.PlaceholderText = ""
        Me.tb_email.SelectedText = ""
        Me.tb_email.ShadowDecoration.Parent = Me.tb_email
        Me.tb_email.Size = New System.Drawing.Size(200, 23)
        Me.tb_email.TabIndex = 58
        '
        'lb_email
        '
        Me.lb_email.AutoSize = True
        Me.lb_email.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_email.Location = New System.Drawing.Point(36, 223)
        Me.lb_email.Name = "lb_email"
        Me.lb_email.Size = New System.Drawing.Size(34, 13)
        Me.lb_email.TabIndex = 57
        Me.lb_email.Text = "Email"
        '
        'tb_contact
        '
        Me.tb_contact.BorderColor = System.Drawing.Color.Silver
        Me.tb_contact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_contact.DefaultText = ""
        Me.tb_contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_contact.DisabledState.Parent = Me.tb_contact
        Me.tb_contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_contact.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_contact.FocusedState.Parent = Me.tb_contact
        Me.tb_contact.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_contact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_contact.HoverState.Parent = Me.tb_contact
        Me.tb_contact.Location = New System.Drawing.Point(39, 286)
        Me.tb_contact.Name = "tb_contact"
        Me.tb_contact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_contact.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_contact.PlaceholderText = ""
        Me.tb_contact.SelectedText = ""
        Me.tb_contact.ShadowDecoration.Parent = Me.tb_contact
        Me.tb_contact.Size = New System.Drawing.Size(200, 23)
        Me.tb_contact.TabIndex = 60
        '
        'lb_contact
        '
        Me.lb_contact.AutoSize = True
        Me.lb_contact.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_contact.Location = New System.Drawing.Point(36, 270)
        Me.lb_contact.Name = "lb_contact"
        Me.lb_contact.Size = New System.Drawing.Size(68, 13)
        Me.lb_contact.TabIndex = 59
        Me.lb_contact.Text = "Contact No."
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
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientButton2.HoverState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(143, 635)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.ShadowDecoration.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(96, 27)
        Me.Guna2GradientButton2.TabIndex = 62
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
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientButton1.HoverState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(39, 635)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.ShadowDecoration.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(96, 27)
        Me.Guna2GradientButton1.TabIndex = 61
        Me.Guna2GradientButton1.Text = "DELETE"
        '
        'tb_address
        '
        Me.tb_address.BorderColor = System.Drawing.Color.Silver
        Me.tb_address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_address.DefaultText = ""
        Me.tb_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_address.DisabledState.Parent = Me.tb_address
        Me.tb_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_address.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_address.FocusedState.Parent = Me.tb_address
        Me.tb_address.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tb_address.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_address.HoverState.Parent = Me.tb_address
        Me.tb_address.Location = New System.Drawing.Point(39, 341)
        Me.tb_address.Multiline = True
        Me.tb_address.Name = "tb_address"
        Me.tb_address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_address.PlaceholderText = ""
        Me.tb_address.SelectedText = ""
        Me.tb_address.ShadowDecoration.Parent = Me.tb_address
        Me.tb_address.Size = New System.Drawing.Size(200, 106)
        Me.tb_address.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Address"
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
        Me.tb_search.Location = New System.Drawing.Point(303, 73)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_search.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_search.PlaceholderText = "Search"
        Me.tb_search.SelectedText = ""
        Me.tb_search.ShadowDecoration.Parent = Me.tb_search
        Me.tb_search.Size = New System.Drawing.Size(242, 33)
        Me.tb_search.TabIndex = 54
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
        Me.bt_refresh.Location = New System.Drawing.Point(923, 73)
        Me.bt_refresh.Name = "bt_refresh"
        Me.bt_refresh.ShadowDecoration.Parent = Me.bt_refresh
        Me.bt_refresh.Size = New System.Drawing.Size(38, 32)
        Me.bt_refresh.TabIndex = 53
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BorderRadius = 6
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = Global.PPE_Inventory_Management_System.My.Resources.Resources.add_new_48px
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button1.Location = New System.Drawing.Point(967, 73)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(139, 33)
        Me.Guna2Button1.TabIndex = 51
        Me.Guna2Button1.Text = "Add New  Supplier"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(-8, 0)
        '
        'tb_description
        '
        Me.tb_description.BorderColor = System.Drawing.Color.Silver
        Me.tb_description.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_description.DefaultText = ""
        Me.tb_description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_description.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_description.DisabledState.Parent = Me.tb_description
        Me.tb_description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_description.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_description.FocusedState.Parent = Me.tb_description
        Me.tb_description.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tb_description.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_description.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_description.HoverState.Parent = Me.tb_description
        Me.tb_description.Location = New System.Drawing.Point(39, 472)
        Me.tb_description.Multiline = True
        Me.tb_description.Name = "tb_description"
        Me.tb_description.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_description.PlaceholderText = ""
        Me.tb_description.SelectedText = ""
        Me.tb_description.ShadowDecoration.Parent = Me.tb_description
        Me.tb_description.Size = New System.Drawing.Size(200, 106)
        Me.tb_description.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Description"
        '
        'Guna2GradientButton4
        '
        Me.Guna2GradientButton4.Animated = True
        Me.Guna2GradientButton4.BorderRadius = 10
        Me.Guna2GradientButton4.CheckedState.Parent = Me.Guna2GradientButton4
        Me.Guna2GradientButton4.CustomImages.Parent = Me.Guna2GradientButton4
        Me.Guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2GradientButton4.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2GradientButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton4.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientButton4.HoverState.Parent = Me.Guna2GradientButton4
        Me.Guna2GradientButton4.Image = Global.PPE_Inventory_Management_System.My.Resources.Resources.print_48px
        Me.Guna2GradientButton4.Location = New System.Drawing.Point(551, 75)
        Me.Guna2GradientButton4.Name = "Guna2GradientButton4"
        Me.Guna2GradientButton4.ShadowDecoration.Parent = Me.Guna2GradientButton4
        Me.Guna2GradientButton4.Size = New System.Drawing.Size(85, 33)
        Me.Guna2GradientButton4.TabIndex = 88
        Me.Guna2GradientButton4.Text = "Print"
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
        'SupplierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 700)
        Me.Controls.Add(Me.Guna2GradientButton4)
        Me.Controls.Add(Me.tb_description)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_address)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2GradientButton2)
        Me.Controls.Add(Me.Guna2GradientButton1)
        Me.Controls.Add(Me.tb_contact)
        Me.Controls.Add(Me.lb_contact)
        Me.Controls.Add(Me.tb_email)
        Me.Controls.Add(Me.lb_email)
        Me.Controls.Add(Me.tb_supplierName)
        Me.Controls.Add(Me.lb_name)
        Me.Controls.Add(Me.tb_search)
        Me.Controls.Add(Me.bt_refresh)
        Me.Controls.Add(Me.dgv_suppliers)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2TileButton1)
        Me.Controls.Add(Me.tb_supplierID)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SupplierForm"
        Me.Text = "SupplierForm"
        CType(Me.dgv_suppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2TileButton1 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents tb_supplierID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents id As Label
    Friend WithEvents tb_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents bt_refresh As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgv_suppliers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tb_email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lb_email As Label
    Friend WithEvents tb_supplierName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lb_name As Label
    Friend WithEvents tb_contact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lb_contact As Label
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tb_address As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_description As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GradientButton4 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
