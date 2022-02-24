Public Class MainForm
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
        customizeDesign()

        Timer1.Enabled = True

    End Sub

    Private Sub customizeDesign()
        pn_Dashboard.Visible = False
        pn_Category.Visible = False
    End Sub

    Private Sub hideSubMenu()
        If pn_Dashboard.Visible = False Then
            pn_Dashboard.Visible = True
        End If
        If pn_Category.Visible = False Then
            pn_Category.Visible = True
        End If
    End Sub

    Private Sub showSubMenu(subMenu As Panel)

        If subMenu.Visible = False Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If

    End Sub
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pn_childForm.Controls.Add(childForm)
        pn_childForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
#Region "Dashboard"
    Private Sub btn_Dashboard_Click(sender As Object, e As EventArgs) Handles btn_Dashboard.Click
        openChildForm(New DashboardForm()) 'This open up another form
    End Sub

#End Region

    Private currentForm As Form = Nothing

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

        openChildForm(New ProductForm())

    End Sub
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        openChildForm(New CategoryForm())

    End Sub
    Private Sub Guna2GradientButton7_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton7.Click
        openChildForm(New SupplierForm())
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_Date.Text = Date.Now.ToString("dddd, dd MMMM yyyy")
        lbl_Time.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        'Environment.Exit(0)
        Try
            If MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo, "Logout") = MsgBoxResult.Yes Then

                Me.Close()
                Dim lform = New Login
                Login.Show()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        openChildForm(New InventoryForm())
    End Sub


End Class