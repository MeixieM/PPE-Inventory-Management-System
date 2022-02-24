Imports MySql.Data.MySqlClient
Public Class CategoryForm
    Dim category As New CATEGORY
    Sub populate()
        Dim command As New MySqlCommand("SELECT * FROM `category`")

        dgv_User.ReadOnly = True

        dgv_User.RowTemplate.Height = 50
        dgv_User.DataSource = category.getCategory(command)

        dgv_User.AllowUserToAddRows = False
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim addcatform = New AddNewCat
        AddNewCat.Show()
    End Sub

    Private Sub CategoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Try
            Dim categoryID As Integer = Convert.ToInt32(tb_categoryID.Text)
            If MsgBox("Are you sure you want to delete this category?", MsgBoxStyle.YesNo, "Delete Category") = MsgBoxResult.Yes Then

                If category.deleteCategory(categoryID) Then
                    MsgBox("Product Deleted", MsgBoxStyle.Information, "Delete Category")
                Else
                    MsgBox("Category Not Deleted", MsgBoxStyle.Information, "Delete Category")
                End If

            End If

        Catch ex As Exception
            MsgBox("Plese enter a Valid ID", MsgBoxStyle.Information, "Delete Category")
        End Try
        populate()
    End Sub


    Private Sub dgv_Category_DoubleClick(sender As Object, e As EventArgs) Handles dgv_User.DoubleClick
        tb_categoryID.Text = dgv_User.CurrentRow.Cells(0).Value.ToString()
        tb_catname.Text = dgv_User.CurrentRow.Cells(1).Value.ToString()
    End Sub

    Private Sub bt_refresh_Click(sender As Object, e As EventArgs) Handles bt_refresh.Click
        populate()
        tb_categoryID.Text = ""
        tb_catname.Text = ""


    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim id As Integer
        Dim category As New CATEGORY()
        Dim CategoryName As String = tb_catname.Text


        If verify() Then
            Try
                id = Convert.ToInt32(tb_categoryID.Text)
            Catch ex As Exception
                MsgBox("Plese Enter A Valid Numeric ID", MsgBoxStyle.Exclamation, "Update Category")
            End Try


            If category.updateCategory(id, CategoryName) Then
                MsgBox("Category Details Updated", MsgBoxStyle.Information, "Add Category")

            Else
                MsgBox("Error", MsgBoxStyle.Critical, "Update Category")

            End If
        Else
            MsgBox("Empty Fields", MsgBoxStyle.Critical, "Update Category")
        End If

        populate()
    End Sub
    Function verify() As Boolean
        If tb_categoryID.Text.Trim() = "" Or tb_catname.Text.Trim() = "" Then

            Return False
        Else
            Return True
        End If

    End Function
End Class