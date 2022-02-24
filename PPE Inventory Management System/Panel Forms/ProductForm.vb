Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ProductForm
    Dim product As New PRODUCT
    Dim db As New MY_DB()
    Sub populate()
        Dim command As New MySqlCommand("SELECT * FROM `product`")

        dgv_Products.ReadOnly = True

        Dim piccol As New DataGridViewImageColumn()

        dgv_Products.RowTemplate.Height = 80

        dgv_Products.DataSource = product.getProduct(command)

        piccol = dgv_Products.Columns(7)

        piccol.ImageLayout = DataGridViewImageCellLayout.Stretch

        dgv_Products.AllowUserToAddRows = False
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim addprodform = New AddNewProd
        AddNewProd.Show()
    End Sub

    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()

        'display category on the combobox
        Dim category As New CATEGORY
        cb_Category.DataSource = category.getAllCategory()
        cb_Category.DisplayMember = "category"
        cb_Category.ValueMember = "category id"

        'set the selected combo item to nothing
        cb_Category.SelectedItem = Nothing

        Dim command As New MySqlCommand("SELECT `Category ID`, `Category` FROM `category`", db.getConnection)
    End Sub

    Private Sub dgv_Products_DoubleClick(sender As Object, e As EventArgs) Handles dgv_Products.DoubleClick
        'Display the selected row data into 


        tb_productId.Text = dgv_Products.CurrentRow.Cells(0).Value.ToString()
        tb_ProdName.Text = dgv_Products.CurrentRow.Cells(1).Value.ToString()
        cb_Category.Text = dgv_Products.CurrentRow.Cells(2).Value.ToString()
        tb_Quantity.Text = dgv_Products.CurrentRow.Cells(3).Value.ToString()
        cb_unit.Text = dgv_Products.CurrentRow.Cells(4).Value.ToString()
        tb_Price.Text = dgv_Products.CurrentRow.Cells(5).Value.ToString()
        tb_Description.Text = dgv_Products.CurrentRow.Cells(6).Value.ToString()

        'display the image from datagridview to picturebox
        Dim pic As Byte()
        pic = dgv_Products.CurrentRow.Cells(7).Value
        Dim picture As New MemoryStream(pic)
        pb_Product.Image = Image.FromStream(picture)

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        'Delete product
        Try
            Dim productID As Integer = Convert.ToInt32(tb_productId.Text)
            If MsgBox("Are you sure you want to delete this product?", MsgBoxStyle.YesNo, "Delete Product") = MsgBoxResult.Yes Then

                If product.deleteProduct(productID) Then
                    MsgBox("Product Deleted", MsgBoxStyle.Information, "Delete Product")
                Else
                    MsgBox("Product Not Deleted", MsgBoxStyle.Information, "Delete Product")
                End If

            End If

        Catch ex As Exception
            MsgBox("Plese enter a Valid ID", MsgBoxStyle.Information, "Delete Product")
        End Try
        populate()
    End Sub


    Private Sub bt_refresh_Click(sender As Object, e As EventArgs) Handles bt_refresh.Click
        populate()
        'clear the forms
        cb_Category.SelectedItem = Nothing
        tb_productId.Text = ""
        tb_ProdName.Text = ""
        tb_Quantity.Text = ""
        cb_unit.SelectedItem = Nothing
        tb_Price.Text = ""
        tb_Description.Text = ""
        pb_Product.Image = Nothing
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim id As Integer
        Dim product As New PRODUCT()
        Dim pCat As String = cb_Category.Text
        Dim pName As String = tb_ProdName.Text
        Dim pQty As String = tb_Quantity.Text
        Dim pUnit As String = cb_unit.Text
        Dim pPrice As String = tb_Price.Text
        Dim pDesc As String = tb_Description.Text
        Dim pic As New MemoryStream


        If verify() Then
            Try
                id = Convert.ToInt32(tb_productId.Text)
            Catch ex As Exception
                MsgBox("Plese Enter A Valid Numeric ID", MsgBoxStyle.Exclamation, "Update Product")
            End Try

            pb_Product.Image.Save(pic, pb_Product.Image.RawFormat)

            If product.updateProduct(id, pCat, pName, pQty, pUnit, pPrice, pDesc, pic) Then
                MsgBox("Product Details Updated", MsgBoxStyle.Information, "Add Product")

            Else
                MsgBox("Error", MsgBoxStyle.Critical, "Update Product")

            End If
        Else
            MsgBox("Empty Fields", MsgBoxStyle.Critical, "Update Product")
        End If

        populate()

    End Sub
    Function verify() As Boolean
        If tb_productId.Text.Trim() = "" Or cb_Category.Text.Trim() = "" Or tb_ProdName.Text.Trim() = "" Or cb_Category.Text.Trim() = "" Or cb_unit.Text.Trim() = "" Or tb_Quantity.Text.Trim() = "" Or tb_Price.Text.Trim() = "" Or tb_Description.Text.Trim() = "" Or pb_Product.Image Is Nothing Then

            Return False
        Else
            Return True
        End If

    End Function

    Private Sub bt_UploadImage_Click(sender As Object, e As EventArgs) Handles bt_UploadImage.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg;*.png;*,*.gif)|*.jpg;*.png;*,*.gif"

        If opf.ShowDialog() = Windows.Forms.DialogResult.OK Then

            pb_Product.Image = Image.FromFile(opf.FileName)

        End If
    End Sub


    'Sub to fill the datagridview

    Sub Fillgrid(ByVal command As MySqlCommand)

        dgv_Products.ReadOnly = True

        dgv_Products.RowTemplate.Height = 80

        dgv_Products.DataSource = product.getProduct(command)

        dgv_Products.AllowUserToAddRows = False

    End Sub

    Private Sub tb_search_TextChanged(sender As Object, e As EventArgs) Handles tb_search.TextChanged
        Dim command As New MySqlCommand("SELECT * FROM `product` WHERE CONCAT(`Product ID`,`Category`,`Product Name`,`Qty.`,`Unit`,`Price`,`Description`)LIKE '%" & tb_search.Text & "%'")
        Fillgrid(command)

    End Sub


End Class