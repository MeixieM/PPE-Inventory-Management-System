Imports MySql.Data.MySqlClient
Public Class CATEGORY

    Dim db As New MY_DB()

    'Function to insert a new category
    Public Function insertCategory(ByVal categoryName As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `category`(`Category`) VALUES (@cat)", db.getConnection)

        command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = categoryName

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        db.closeConnection()
    End Function
    'Function to load Category database
    Public Function getCategory(ByVal command As MySqlCommand) As DataTable

        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table

    End Function

    'Function to Delete Category
    Public Function deleteCategory(ByVal id As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `category` WHERE `Category ID` = @categoryID", db.getConnection)


        command.Parameters.Add("@categoryID", MySqlDbType.Int32).Value = id
        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        db.closeConnection()

    End Function

    'function to update category
    Public Function updateCategory(ByVal id As Integer, ByVal categoryName As String) As Boolean

        Dim command As New MySqlCommand("UPDATE `category` SET `Category`=@cat WHERE `Category ID` =@ID", db.getConnection)

        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id
        command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = categoryName

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        db.closeConnection()

    End Function

    Public Function checkCategoryName(ByVal categoryName As String) As Boolean
        'This checks if CategoryName already exist
        Dim command As New MySqlCommand("SELECT * FROM `category` WHERE `Category`=@cat", db.getConnection)
        command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = categoryName
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return False
        Else
            Return True

        End If

    End Function

    ''Function to load Category database
    Public Function getAllCategory() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM category", db.getConnection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Return table



    End Function
End Class

