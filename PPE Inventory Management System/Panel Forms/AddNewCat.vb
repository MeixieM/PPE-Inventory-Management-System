Public Class AddNewCat

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click

        Dim category As New CATEGORY()
        Dim categoryName As String = tb_category.Text


        If verify() Then

            If category.checkCategoryName(categoryName) Then

                If category.insertCategory(categoryName) Then
                    MsgBox("New Category Saved", MsgBoxStyle.Information, "Add Category")

                Else
                    MsgBox("Error", MsgBoxStyle.Critical, "Add Category")

                End If
            Else
                MsgBox("This Category Name Already Exists", MsgBoxStyle.Information, "Add Category")
            End If
        Else
            MsgBox("Empty Fields", MsgBoxStyle.Critical, "Add Category")
        End If


    End Sub
    Function verify() As Boolean
        If tb_category.Text.Trim() = "" Then
            Return False
        Else
            Return True
        End If
    End Function




End Class