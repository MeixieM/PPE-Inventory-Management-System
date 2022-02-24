Imports MySql.Data.MySqlClient
Public Class INVENTORY
    Dim db As New MY_DB()

    'function to insert a new Inventory
    Public Function insertInventory(ByVal category As String, ByVal productName As String, ByVal price As String, ByVal qty As String, ByVal unit As String, ByVal available As String, ByVal total As String, ByVal purchDate As Date) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `inventory`(`Category`, `Product Name`, `Price`, `Qty.`, `Unit`, `Availability`, `Total`, `Purchase Date`) VALUES (@cat, @pn, @pp, @qty, @ut, @avail, @tt, @pd )", db.getConnection)


        command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = category
        command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = productName
        command.Parameters.Add("@pp", MySqlDbType.VarChar).Value = price
        command.Parameters.Add("qty", MySqlDbType.VarChar).Value = qty
        command.Parameters.Add("ut", MySqlDbType.VarChar).Value = unit
        command.Parameters.Add("avail", MySqlDbType.VarChar).Value = available
        command.Parameters.Add("tt", MySqlDbType.VarChar).Value = total
        command.Parameters.Add("pd", MySqlDbType.Date).Value = purchDate

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        db.closeConnection()


    End Function

    'Function to load inventory database
    Public Function getInventory(ByVal command As MySqlCommand) As DataTable

        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table

    End Function

    'Function to Delete Inventory
    Public Function deleteInventory(ByVal id As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `inventory` WHERE `#` = @ID", db.getConnection)


        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id
        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        db.closeConnection()

    End Function


    'function to update Inventory
    Public Function updateInventory(ByVal id As Integer, ByVal category As String, ByVal productName As String, ByVal price As String, ByVal qty As String, ByVal unit As String, ByVal available As String, ByVal total As String, ByVal purchDate As Date) As Boolean

        Dim command As New MySqlCommand("UPDATE `inventory` SET `Category`=@cat,`Product Name`=@pn,`Price`=@pp,`Qty.`= @qty,`Unit`=@ut,`Availability`=@avail,`Total`=@tot,`Purchase Date`=@pd WHERE `#` = @ID", db.getConnection)

        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id
        command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = category
        command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = productName
        command.Parameters.Add("@pp", MySqlDbType.VarChar).Value = price
        command.Parameters.Add("qty", MySqlDbType.VarChar).Value = qty
        command.Parameters.Add("ut", MySqlDbType.VarChar).Value = unit
        command.Parameters.Add("avail", MySqlDbType.VarChar).Value = available
        command.Parameters.Add("tot", MySqlDbType.VarChar).Value = total
        command.Parameters.Add("pd", MySqlDbType.Date).Value = purchDate


        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        db.closeConnection()


    End Function

End Class
