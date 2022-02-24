Imports System.IO
Imports MySql.Data.MySqlClient
Public Class AddNewProd
    Dim db As New MY_DB()

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles bt_UploadImage.Click

        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg;*.png;*,*.gif)|*.jpg;*.png;*,*.gif"

        If opf.ShowDialog() = Windows.Forms.DialogResult.OK Then

            pb_Product.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click

        Dim product As New PRODUCT()
        Dim pCat As String = cb_Category.Text
        Dim pName As String = tb_ProdName.Text
        Dim pQty As String = tb_Quantity.Text
        Dim pUnit As String = cb_unit.Text
        Dim pPrice As String = tb_Price.Text
        Dim pDesc As String = tb_Description.Text
        Dim pic As New MemoryStream


        If verify() Then
            pb_Product.Image.Save(pic, pb_Product.Image.RawFormat)
            If product.checkProductName(pName) Then

                If product.insertProduct(pCat, pName, pQty, pUnit, pPrice, pDesc, pic) Then
                    MsgBox("New Product Saved", MsgBoxStyle.Information, "Add Product")
                Else
                    MsgBox("Error", MsgBoxStyle.Critical, "Add Product")

                End If
            Else
                MsgBox("This Product Already Exists", MsgBoxStyle.Information, "Add Product")
            End If

        Else
                MsgBox("Empty Fields", MsgBoxStyle.Critical, "Add Product")
        End If



    End Sub
    Function verify() As Boolean
        If cb_Category.Text.Trim() = "" Or tb_ProdName.Text.Trim() = "" Or tb_Quantity.Text.Trim() = "" Or cb_unit.Text.Trim() = "" Or tb_Price.Text.Trim() = "" Or tb_Description.Text.Trim() = "" Or pb_Product.Image Is Nothing Then

            Return False
        Else
            Return True
        End If

    End Function

    Dim category As New CATEGORY
    Private Sub AddNewProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display category on the combobox
        Dim category As New CATEGORY
        cb_Category.DataSource = category.getAllCategory()
        cb_Category.DisplayMember = "category"
        cb_Category.ValueMember = "category id"

        Dim command As New MySqlCommand("SELECT `Category ID`, `Category` FROM `category`", db.getConnection)

        'set the selected combo item to nothing
        cb_Category.SelectedItem = Nothing
    End Sub


End Class