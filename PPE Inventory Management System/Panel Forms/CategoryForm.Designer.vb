<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategoryForm
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
        Me.bt_refresh = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.tb_categoryID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_catname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_User = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(Me.dgv_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'bt_refresh
        '
        Me.bt_refresh.Animated = True
        Me.bt_refresh.BorderRadius = 8
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
        Me.bt_refresh.Location = New System.Drawing.Point(663, 77)
        Me.bt_refresh.Name = "bt_refresh"
        Me.bt_refresh.ShadowDecoration.Parent = Me.bt_refresh
        Me.bt_refresh.Size = New System.Drawing.Size(38, 32)
        Me.bt_refresh.TabIndex = 44
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BorderRadius = 8
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = Global.PPE_Inventory_Management_System.My.Resources.Resources.add_new_48px
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button1.Location = New System.Drawing.Point(707, 77)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(139, 33)
        Me.Guna2Button1.TabIndex = 43
        Me.Guna2Button1.Text = "Add New Category"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(-8, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 37)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Manage Category"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Location = New System.Drawing.Point(15, 46)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1076, 1)
        Me.Guna2Panel1.TabIndex = 46
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
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(266, 252)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.ShadowDecoration.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(96, 27)
        Me.Guna2GradientButton2.TabIndex = 48
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
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(162, 252)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.ShadowDecoration.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(96, 27)
        Me.Guna2GradientButton1.TabIndex = 47
        Me.Guna2GradientButton1.Text = "DELETE"
        '
        'tb_categoryID
        '
        Me.tb_categoryID.BorderColor = System.Drawing.Color.Silver
        Me.tb_categoryID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_categoryID.DefaultText = ""
        Me.tb_categoryID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_categoryID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_categoryID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_categoryID.DisabledState.Parent = Me.tb_categoryID
        Me.tb_categoryID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_categoryID.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_categoryID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_categoryID.FocusedState.Parent = Me.tb_categoryID
        Me.tb_categoryID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_categoryID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_categoryID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_categoryID.HoverState.Parent = Me.tb_categoryID
        Me.tb_categoryID.Location = New System.Drawing.Point(162, 166)
        Me.tb_categoryID.Name = "tb_categoryID"
        Me.tb_categoryID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_categoryID.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_categoryID.PlaceholderText = ""
        Me.tb_categoryID.SelectedText = ""
        Me.tb_categoryID.ShadowDecoration.Parent = Me.tb_categoryID
        Me.tb_categoryID.Size = New System.Drawing.Size(200, 23)
        Me.tb_categoryID.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(159, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Category ID"
        '
        'tb_catname
        '
        Me.tb_catname.BorderColor = System.Drawing.Color.Silver
        Me.tb_catname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_catname.DefaultText = ""
        Me.tb_catname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_catname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_catname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_catname.DisabledState.Parent = Me.tb_catname
        Me.tb_catname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_catname.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tb_catname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_catname.FocusedState.Parent = Me.tb_catname
        Me.tb_catname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_catname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_catname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_catname.HoverState.Parent = Me.tb_catname
        Me.tb_catname.Location = New System.Drawing.Point(162, 212)
        Me.tb_catname.Name = "tb_catname"
        Me.tb_catname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_catname.PlaceholderText = ""
        Me.tb_catname.SelectedText = ""
        Me.tb_catname.ShadowDecoration.Parent = Me.tb_catname
        Me.tb_catname.Size = New System.Drawing.Size(200, 23)
        Me.tb_catname.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Category Name"
        '
        'dgv_User
        '
        Me.dgv_User.AllowUserToAddRows = False
        Me.dgv_User.AllowUserToDeleteRows = False
        Me.dgv_User.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgv_User.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_User.BackgroundColor = System.Drawing.Color.White
        Me.dgv_User.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_User.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_User.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(191, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_User.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_User.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_User.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_User.EnableHeadersVisualStyles = False
        Me.dgv_User.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_User.Location = New System.Drawing.Point(389, 124)
        Me.dgv_User.Name = "dgv_User"
        Me.dgv_User.RowHeadersVisible = False
        Me.dgv_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_User.Size = New System.Drawing.Size(457, 525)
        Me.dgv_User.TabIndex = 54
        Me.dgv_User.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgv_User.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_User.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_User.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_User.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_User.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_User.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_User.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_User.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.dgv_User.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_User.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_User.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_User.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_User.ThemeStyle.HeaderStyle.Height = 30
        Me.dgv_User.ThemeStyle.ReadOnly = False
        Me.dgv_User.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_User.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_User.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_User.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_User.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_User.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_User.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'CategoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 700)
        Me.Controls.Add(Me.dgv_User)
        Me.Controls.Add(Me.tb_categoryID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_catname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2GradientButton2)
        Me.Controls.Add(Me.Guna2GradientButton1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bt_refresh)
        Me.Controls.Add(Me.Guna2Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CategoryForm"
        Me.Text = "CategoryForm"
        CType(Me.dgv_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents bt_refresh As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tb_categoryID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_catname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_User As Guna.UI2.WinForms.Guna2DataGridView
End Class
