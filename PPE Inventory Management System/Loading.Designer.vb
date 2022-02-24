<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loading
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Myprogressbar = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Myprogressbar
        '
        Me.Myprogressbar.AutoRoundedCorners = True
        Me.Myprogressbar.BackColor = System.Drawing.Color.Transparent
        Me.Myprogressbar.BorderRadius = 12
        Me.Myprogressbar.FillColor = System.Drawing.Color.White
        Me.Myprogressbar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Myprogressbar.Location = New System.Drawing.Point(12, 314)
        Me.Myprogressbar.Name = "Myprogressbar"
        Me.Myprogressbar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Myprogressbar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Myprogressbar.ShadowDecoration.Parent = Me.Myprogressbar
        Me.Myprogressbar.Size = New System.Drawing.Size(281, 27)
        Me.Myprogressbar.TabIndex = 0
        Me.Myprogressbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Myprogressbar.UseTransparentBackground = True
        '
        'Timer1
        '
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.ContainerControl = Me
        Me.Guna2DragControl1.TargetControl = Me.Guna2PictureBox2
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.PPE_Inventory_Management_System.My.Resources.Resources.ezgif1
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(82, 76)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(137, 128)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Guna2PictureBox2.TabIndex = 14
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2DragControl2
        '
        Me.Guna2DragControl2.ContainerControl = Me
        Me.Guna2DragControl2.TargetControl = Me.Guna2Panel1
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Myprogressbar)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(305, 353)
        Me.Guna2Panel1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(105, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "STARTING..."
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(305, 353)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Myprogressbar As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label1 As Label
End Class
