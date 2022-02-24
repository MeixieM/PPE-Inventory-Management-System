Imports MySql.Data.MySqlClient

Public Class InventoryForm
    Dim product As New PRODUCT()
    Dim inventory As New INVENTORY()
    Dim db As New MY_DB()
    Sub populate()
        Dim command As New MySqlCommand("SELECT `Product ID`, `Category`, `Product Name`, `Qty.`, `Unit`, `Price`,`Image` FROM `product`")

        dgv_inv.ReadOnly = True

        Dim piccol As New DataGridViewImageColumn()

        dgv_inv.RowTemplate.Height = 40

        dgv_inv.DataSource = product.getProduct(command)

        piccol = dgv_inv.Columns(6)

        piccol.ImageLayout = DataGridViewImageCellLayout.Stretch

        dgv_inv.AllowUserToAddRows = False
    End Sub

    Sub filldgvInventory()
        Dim command As New MySqlCommand("SELECT * FROM `inventory`")

        dgv_inventory.ReadOnly = True
        dgv_inventory.RowTemplate.Height = 40
        dgv_inventory.DataSource = inventory.getInventory(command)
        dgv_inventory.AllowUserToAddRows = False
    End Sub

    Sub fillcombobox()
        'display category on the combobox
        Dim category As New CATEGORY
        cb_Category.DataSource = category.getAllCategory()
        cb_Category.DisplayMember = "category"
        cb_Category.ValueMember = "category id"

        'set the selected combo item to nothing
        cb_Category.SelectedItem = Nothing

        Dim command As New MySqlCommand("SELECT `Category ID`, `Category` FROM `category`", db.getConnection)
    End Sub
    'Sub to fill the datagridview

    Sub Fillgrid(ByVal command As MySqlCommand)

        dgv_inventory.ReadOnly = True

        dgv_inventory.RowTemplate.Height = 40

        dgv_inventory.DataSource = inventory.getInventory(command)

        dgv_inventory.AllowUserToAddRows = False

    End Sub
    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        fillcombobox()
        filldgvInventory()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim id As Integer
        Dim inventory As New INVENTORY()
        Dim category As String = cb_Category.Text
        Dim productName As String = tb_ProdName.Text
        Dim price As String = tb_Price.Text
        Dim qty As String = tb_Quantity.Text
        Dim unit As String = cb_unit.Text
        Dim available As String = tb_available.Text
        Dim purchDate As Date = dtp_date.Text
        Dim Sum As Integer
        Sum = (Val(tb_Price.Text) * (Val(tb_Quantity.Text)))
        tb_total.Text = Sum
        Dim total As String = tb_total.Text

        If verify() Then
            Try
                id = Convert.ToInt32(tb_productId.Text)
            Catch ex As Exception
                MsgBox("Plese Enter A Valid Numeric ID", MsgBoxStyle.Exclamation, "Update Product")
            End Try

            If inventory.updateInventory(id, category, productName, price, qty, unit, available, Sum, purchDate) Then
                MsgBox("Product Details Updated", MsgBoxStyle.Information, "Update Product")

            Else
                MsgBox("Error", MsgBoxStyle.Critical, "Update Product")

            End If
        Else
            MsgBox("Empty Fields", MsgBoxStyle.Critical, "Update Product")
        End If
        filldgvInventory()
        populate()
    End Sub
    Function verify() As Boolean
        If tb_productId.Text.Trim() = "" Or cb_Category.Text.Trim() = "" Or tb_ProdName.Text.Trim() = "" Or cb_Category.Text.Trim() = "" Or cb_unit.Text.Trim() = "" Or tb_Quantity.Text.Trim() = "" Or tb_Price.Text.Trim() = "" Then

            Return False
        Else
            Return True
        End If

    End Function

    Private Sub dgv_inv_Click(sender As Object, e As EventArgs) Handles dgv_inv.Click
        tb_productId.Text = dgv_inv.CurrentRow.Cells(0).Value.ToString()
        cb_Category.Text = dgv_inv.CurrentRow.Cells(1).Value.ToString()
        tb_ProdName.Text = dgv_inv.CurrentRow.Cells(2).Value.ToString()
        tb_Quantity.Text = dgv_inv.CurrentRow.Cells(3).Value.ToString()
        cb_unit.Text = dgv_inv.CurrentRow.Cells(4).Value.ToString()
        tb_Price.Text = dgv_inv.CurrentRow.Cells(5).Value.ToString()


        tb_total.Text = ""
        tb_available.Text = Nothing
        dtp_date.Value = Date.Now


    End Sub

    Private Sub bt_refresh_Click(sender As Object, e As EventArgs) Handles bt_refresh.Click
        filldgvInventory()
        tb_productId.Text = ""
        cb_Category.Text = Nothing
        tb_ProdName.Text = ""
        tb_Price.Text = ""
        tb_Quantity.Text = ""
        cb_unit.Text = Nothing
        tb_available.Text = Nothing
        tb_total.Text = ""
        dtp_date.Value = Date.Now
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Dim inventory As New INVENTORY()
        Dim category As String = cb_Category.Text
        Dim productName As String = tb_ProdName.Text
        Dim price As String = tb_Price.Text
        Dim qty As String = tb_Quantity.Text
        Dim unit As String = cb_unit.Text
        Dim available As String = tb_available.Text
        Dim purchDate As Date = dtp_date.Text

        Dim Sum As Integer
        Sum = (Val(tb_Price.Text) * (Val(tb_Quantity.Text)))
        tb_total.Text = Sum
        Dim total As String = tb_total.Text

        If verify() Then

            If inventory.insertInventory(category, productName, price, qty, unit, available, Sum, purchDate) Then
                MsgBox("New Product Saved", MsgBoxStyle.Information, "Add Product")

            Else
                MsgBox("Error", MsgBoxStyle.Critical, "Add Product")

            End If

        Else
            MsgBox("Empty Fields", MsgBoxStyle.Critical, "Add Product")
        End If

        filldgvInventory()
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_inventory.CellClick
        tb_productId.Text = dgv_inventory.CurrentRow.Cells(0).Value.ToString()
        cb_Category.Text = dgv_inventory.CurrentRow.Cells(1).Value.ToString()
        tb_ProdName.Text = dgv_inventory.CurrentRow.Cells(2).Value.ToString()
        tb_Price.Text = dgv_inventory.CurrentRow.Cells(3).Value.ToString()
        tb_Quantity.Text = dgv_inventory.CurrentRow.Cells(4).Value.ToString()
        cb_unit.Text = dgv_inventory.CurrentRow.Cells(5).Value.ToString()
        tb_available.Text = dgv_inventory.CurrentRow.Cells(6).Value.ToString()
        tb_total.Text = dgv_inventory.CurrentRow.Cells(7).Value.ToString()
        dtp_date.Text = dgv_inventory.CurrentRow.Cells(8).Value.ToString()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        'Delete product
        Try
            Dim productID As Integer = Convert.ToInt32(tb_productId.Text)
            If MsgBox("Are you sure you want to delete this product?", MsgBoxStyle.YesNo, "Delete Product") = MsgBoxResult.Yes Then

                If inventory.deleteInventory(productID) Then
                    MsgBox("Product Deleted", MsgBoxStyle.Information, "Delete Product")
                Else
                    MsgBox("Product Not Deleted", MsgBoxStyle.Information, "Delete Product")
                End If

            End If
        Catch ex As Exception
            MsgBox("Plese enter a Valid ID", MsgBoxStyle.Information, "Delete Product")
        End Try
        filldgvInventory()
    End Sub

    Private Sub tb_search_TextChanged(sender As Object, e As EventArgs) Handles tb_search.TextChanged
        Dim command As New MySqlCommand("SELECT * FROM `inventory` WHERE  CONCAT (`#`, `Category`, `Product Name`, `Price`, `Qty.`, `Unit`, `Availability`, `Total`, `Purchase Date`)LIKE '%" & tb_search.Text & "%'")
        Fillgrid(command)
    End Sub

    Private bm As Bitmap
    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        'Print datagridview Inventory
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.dgv_inventory.Width, Me.dgv_inventory.Height)
        dgv_inventory.DrawToBitmap(bm, New Rectangle(0, 0, Me.dgv_inventory.Width, Me.dgv_inventory.Height))
        e.Graphics.DrawImage(bm, 0, 0)

    End Sub
End Class