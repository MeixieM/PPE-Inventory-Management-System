<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.pn_login = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.ckb_Show = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_Username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pn_register = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.tb_regconpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.tb_regusername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_regpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pn_login.SuspendLayout()
        Me.pn_register.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.Interval = 100
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 8
        Me.GunaElipse1.TargetControl = Me
        '
        'pn_login
        '
        Me.pn_login.BackColor = System.Drawing.Color.Transparent
        Me.pn_login.Controls.Add(Me.Label2)
        Me.pn_login.Controls.Add(Me.ckb_Show)
        Me.pn_login.Controls.Add(Me.Guna2Button1)
        Me.pn_login.Controls.Add(Me.Label1)
        Me.pn_login.Controls.Add(Me.tb_Password)
        Me.pn_login.Controls.Add(Me.tb_Username)
        Me.pn_login.Controls.Add(Me.Guna2GradientButton1)
        Me.Guna2Transition1.SetDecoration(Me.pn_login, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pn_login.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pn_login.Location = New System.Drawing.Point(593, 104)
        Me.pn_login.Name = "pn_login"
        Me.pn_login.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pn_login.ShadowShift = 10
        Me.pn_login.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.pn_login.Size = New System.Drawing.Size(266, 363)
        Me.pn_login.TabIndex = 14
        '
        'ckb_Show
        '
        Me.ckb_Show.AutoSize = True
        Me.ckb_Show.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckb_Show.CheckedState.BorderRadius = 0
        Me.ckb_Show.CheckedState.BorderThickness = 0
        Me.ckb_Show.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.ckb_Show, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ckb_Show.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckb_Show.Location = New System.Drawing.Point(22, 182)
        Me.ckb_Show.Name = "ckb_Show"
        Me.ckb_Show.Size = New System.Drawing.Size(108, 17)
        Me.ckb_Show.TabIndex = 8
        Me.ckb_Show.Text = "Show password"
        Me.ckb_Show.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ckb_Show.UncheckedState.BorderRadius = 0
        Me.ckb_Show.UncheckedState.BorderThickness = 0
        Me.ckb_Show.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 21
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = Global.PPE_Inventory_Management_System.My.Resources.Resources.right_50px
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2Button1.Location = New System.Drawing.Point(21, 287)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(231, 45)
        Me.Guna2Button1.TabIndex = 7
        Me.Guna2Button1.Text = "Create Account"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User Login"
        '
        'tb_Password
        '
        Me.tb_Password.Animated = True
        Me.tb_Password.BorderRadius = 8
        Me.tb_Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.tb_Password, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tb_Password.DefaultText = ""
        Me.tb_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Password.DisabledState.Parent = Me.tb_Password
        Me.tb_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Password.FillColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.tb_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Password.FocusedState.Parent = Me.tb_Password
        Me.tb_Password.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.tb_Password.ForeColor = System.Drawing.Color.DimGray
        Me.tb_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Password.HoverState.Parent = Me.tb_Password
        Me.tb_Password.IconLeft = Global.PPE_Inventory_Management_System.My.Resources.Resources.icons8_password_26px
        Me.tb_Password.Location = New System.Drawing.Point(21, 133)
        Me.tb_Password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Password.Name = "tb_Password"
        Me.tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Password.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.tb_Password.PlaceholderText = "Password"
        Me.tb_Password.SelectedText = ""
        Me.tb_Password.ShadowDecoration.Parent = Me.tb_Password
        Me.tb_Password.Size = New System.Drawing.Size(231, 36)
        Me.tb_Password.TabIndex = 3
        Me.tb_Password.UseSystemPasswordChar = True
        '
        'tb_Username
        '
        Me.tb_Username.Animated = True
        Me.tb_Username.BorderRadius = 8
        Me.tb_Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.tb_Username, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tb_Username.DefaultText = ""
        Me.tb_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Username.DisabledState.Parent = Me.tb_Username
        Me.tb_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Username.FillColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.tb_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Username.FocusedState.Parent = Me.tb_Username
        Me.tb_Username.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.tb_Username.ForeColor = System.Drawing.Color.DimGray
        Me.tb_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Username.HoverState.Parent = Me.tb_Username
        Me.tb_Username.IconLeft = Global.PPE_Inventory_Management_System.My.Resources.Resources.icons8_user_50px
        Me.tb_Username.Location = New System.Drawing.Point(21, 82)
        Me.tb_Username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Username.Name = "tb_Username"
        Me.tb_Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Username.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.tb_Username.PlaceholderText = "Username"
        Me.tb_Username.SelectedText = ""
        Me.tb_Username.ShadowDecoration.Parent = Me.tb_Username
        Me.tb_Username.Size = New System.Drawing.Size(231, 36)
        Me.tb_Username.TabIndex = 1
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.Animated = True
        Me.Guna2GradientButton1.AutoRoundedCorners = True
        Me.Guna2GradientButton1.BorderRadius = 21
        Me.Guna2GradientButton1.CheckedState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientButton1.CustomImages.Parent = Me.Guna2GradientButton1
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.HoverState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(21, 218)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.ShadowDecoration.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(231, 45)
        Me.Guna2GradientButton1.TabIndex = 5
        Me.Guna2GradientButton1.Text = "LOGIN"
        '
        'pn_register
        '
        Me.pn_register.BackColor = System.Drawing.Color.Transparent
        Me.pn_register.Controls.Add(Me.tb_regconpass)
        Me.pn_register.Controls.Add(Me.Guna2GradientButton2)
        Me.pn_register.Controls.Add(Me.tb_regusername)
        Me.pn_register.Controls.Add(Me.Label4)
        Me.pn_register.Controls.Add(Me.Label3)
        Me.pn_register.Controls.Add(Me.tb_regpass)
        Me.Guna2Transition1.SetDecoration(Me.pn_register, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pn_register.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pn_register.Location = New System.Drawing.Point(593, 104)
        Me.pn_register.Name = "pn_register"
        Me.pn_register.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pn_register.ShadowShift = 10
        Me.pn_register.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.pn_register.Size = New System.Drawing.Size(266, 363)
        Me.pn_register.TabIndex = 14
        '
        'tb_regconpass
        '
        Me.tb_regconpass.Animated = True
        Me.tb_regconpass.BorderRadius = 8
        Me.tb_regconpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.tb_regconpass, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tb_regconpass.DefaultText = ""
        Me.tb_regconpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_regconpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_regconpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_regconpass.DisabledState.Parent = Me.tb_regconpass
        Me.tb_regconpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_regconpass.FillColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.tb_regconpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_regconpass.FocusedState.Parent = Me.tb_regconpass
        Me.tb_regconpass.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.tb_regconpass.ForeColor = System.Drawing.Color.DimGray
        Me.tb_regconpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_regconpass.HoverState.Parent = Me.tb_regconpass
        Me.tb_regconpass.IconLeft = Global.PPE_Inventory_Management_System.My.Resources.Resources.icons8_password_26px
        Me.tb_regconpass.Location = New System.Drawing.Point(19, 175)
        Me.tb_regconpass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_regconpass.Name = "tb_regconpass"
        Me.tb_regconpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.tb_regconpass.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.tb_regconpass.PlaceholderText = "Confirm Password"
        Me.tb_regconpass.SelectedText = ""
        Me.tb_regconpass.ShadowDecoration.Parent = Me.tb_regconpass
        Me.tb_regconpass.Size = New System.Drawing.Size(231, 36)
        Me.tb_regconpass.TabIndex = 9
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.Animated = True
        Me.Guna2GradientButton2.AutoRoundedCorners = True
        Me.Guna2GradientButton2.BorderRadius = 21
        Me.Guna2GradientButton2.CheckedState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.CustomImages.Parent = Me.Guna2GradientButton2
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.HoverState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(19, 245)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.ShadowDecoration.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(231, 45)
        Me.Guna2GradientButton2.TabIndex = 5
        Me.Guna2GradientButton2.Text = "Create Account"
        '
        'tb_regusername
        '
        Me.tb_regusername.Animated = True
        Me.tb_regusername.BorderRadius = 8
        Me.tb_regusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.tb_regusername, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tb_regusername.DefaultText = ""
        Me.tb_regusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_regusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_regusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_regusername.DisabledState.Parent = Me.tb_regusername
        Me.tb_regusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_regusername.FillColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.tb_regusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_regusername.FocusedState.Parent = Me.tb_regusername
        Me.tb_regusername.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.tb_regusername.ForeColor = System.Drawing.Color.DimGray
        Me.tb_regusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_regusername.HoverState.Parent = Me.tb_regusername
        Me.tb_regusername.IconLeft = Global.PPE_Inventory_Management_System.My.Resources.Resources.icons8_user_50px
        Me.tb_regusername.Location = New System.Drawing.Point(22, 76)
        Me.tb_regusername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_regusername.Name = "tb_regusername"
        Me.tb_regusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_regusername.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.tb_regusername.PlaceholderText = "Username"
        Me.tb_regusername.SelectedText = ""
        Me.tb_regusername.ShadowDecoration.Parent = Me.tb_regusername
        Me.tb_regusername.Size = New System.Drawing.Size(231, 36)
        Me.tb_regusername.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 37)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Register"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(119, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Login"
        '
        'tb_regpass
        '
        Me.tb_regpass.Animated = True
        Me.tb_regpass.BorderRadius = 8
        Me.tb_regpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.tb_regpass, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tb_regpass.DefaultText = ""
        Me.tb_regpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_regpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_regpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_regpass.DisabledState.Parent = Me.tb_regpass
        Me.tb_regpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_regpass.FillColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.tb_regpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_regpass.FocusedState.Parent = Me.tb_regpass
        Me.tb_regpass.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.tb_regpass.ForeColor = System.Drawing.Color.DimGray
        Me.tb_regpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_regpass.HoverState.Parent = Me.tb_regpass
        Me.tb_regpass.IconLeft = Global.PPE_Inventory_Management_System.My.Resources.Resources.icons8_password_26px
        Me.tb_regpass.Location = New System.Drawing.Point(22, 126)
        Me.tb_regpass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_regpass.Name = "tb_regpass"
        Me.tb_regpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.tb_regpass.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.tb_regpass.PlaceholderText = "Password"
        Me.tb_regpass.SelectedText = ""
        Me.tb_regpass.ShadowDecoration.Parent = Me.tb_regpass
        Me.tb_regpass.Size = New System.Drawing.Size(231, 36)
        Me.tb_regpass.TabIndex = 3
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.PPE_Inventory_Management_System.My.Resources.Resources.Asset_12
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-94, -28)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(975, 787)
        Me.Guna2PictureBox1.TabIndex = 9
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2ControlBox1.BorderThickness = 1
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(849, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(31, 25)
        Me.Guna2ControlBox1.TabIndex = 15
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.Animated = True
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2ControlBox2.BorderThickness = 1
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(817, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(31, 25)
        Me.Guna2ControlBox2.TabIndex = 16
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(45, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Developed By: Alex Fernan Mercado"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 545)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.pn_login)
        Me.Controls.Add(Me.pn_register)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pn_login.ResumeLayout(False)
        Me.pn_login.PerformLayout()
        Me.pn_register.ResumeLayout(False)
        Me.pn_register.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents pn_login As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tb_Username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tb_Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pn_register As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents tb_regusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tb_regpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents tb_regconpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ckb_Show As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label2 As Label
End Class
