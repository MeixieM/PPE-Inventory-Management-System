Imports System.IO
Imports MySql.Data.MySqlClient

Public Class PRODUCT

    Dim db As New MY_DB()

    'function to insert a new product
    Public Function insertProduct(ByVal pCat As String, ByVal pName As String, ByVal pQty As String, ByVal pUnit As String, ByVal pPrice As String, ByVal pDesc As String, ByVal pImage As MemoryStream) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `product`(`Category`, `Product Name`, `Qty.`, `Unit`, `Price`, `Description`, `Image`) VALUES (@pc, @pn, @pq,@pu, @pp, @pd, @pi)", db.getConnection)

        command.Parameters.Add("@pc", MySqlDbType.VarChar).Value = pCat
        command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pName
        command.Parameters.Add("@pq", MySqlDbType.VarChar).Value = pQty
        command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = pUnit
        command.Parameters.Add("@pp", MySqlDbType.VarChar).Value = pPrice
        command.Parameters.Add("@pd", MySqlDbType.VarChar).Value = pDesc
        command.Parameters.Add("@pi", MySqlDbType.Blob).Value = pImage.ToArray()

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        db.closeConnection()


    End Function
    'Function to load Product database
    Public Function getProduct(ByVal command As MySqlCommand) As DataTable

        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table

    End Function

    'Function to Delete Product
    Public Function deleteProduct(ByVal id As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `product` WHERE `Product ID` = @productID", db.getConnection)


        command.Parameters.Add("@productID", MySqlDbType.Int32).Value = id
        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        db.closeConnection()

    End Function


    'function to update product
    Public Function updateProduct(ByVal id As Integer, ByVal pCat As String, ByVal pName As String, ByVal pQty As String, ByVal pUnit As String, ByVal pPrice As String, ByVal pDesc As String, ByVal pImage As MemoryStream) As Boolean

        Dim command As New MySqlCommand("UPDATE `product` SET `Category`=@pc,`Product Name`=@pn,`Qty.`=@pq,`Unit` =@pu,`Price`=@pp,`Description`=@pd,`Image`=@pi WHERE `Product ID` = @ID", db.getConnection)

        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id
        command.Parameters.Add("@pc", MySqlDbType.VarChar).Value = pCat
        command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pName
        command.Parameters.Add("@pq", MySqlDbType.VarChar).Value = pQty
        command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = pUnit
        command.Parameters.Add("@pp", MySqlDbType.VarChar).Value = pPrice
        command.Parameters.Add("@pd", MySqlDbType.VarChar).Value = pDesc
        command.Parameters.Add("@pi", MySqlDbType.Blob).Value = pImage.ToArray()

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        db.closeConnection()


    End Function

    Public Function checkProductName(ByVal productName As String) As Boolean
        Dim command As New MySqlCommand("SELECT * FROM `product` WHERE `Product Name`=@pn", db.getConnection)
        command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = productName
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return False
        Else
            Return True

        End If

    End Function
End Class