Imports MySql.Data.MySqlClient
Public Class SUPPLIER

    Dim db As New MY_DB()

    'function to insert a new Suppier
    Public Function insertSupplier(ByVal supplyName As String, ByVal email As String, ByVal contacno As String, ByVal address As String, ByVal desc As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `suppliers`(`Supplier Name`, `Email`, `ContactNo`, `Address`,`Description`) VALUES (@sn, @se,@sc,@adr,@sd)", db.getConnection)
        '@sn, @se,@sc,@adr

        command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = supplyName
        command.Parameters.Add("@se", MySqlDbType.VarChar).Value = email
        command.Parameters.Add("@sc", MySqlDbType.VarChar).Value = contacno
        command.Parameters.Add("adr", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("sd", MySqlDbType.VarChar).Value = desc

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        db.closeConnection()


    End Function
    'Function to load supplier database
    Public Function getSupplier(ByVal command As MySqlCommand) As DataTable

        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table

    End Function

    'Function to Delete Supplier
    Public Function deleteSupplier(ByVal id As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `suppliers` WHERE `Supplier ID` = @ID", db.getConnection)


        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id
        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        db.closeConnection()

    End Function


    'function to update Supplier
    Public Function updateSupplier(ByVal id As Integer, ByVal supplyName As String, ByVal email As String, ByVal contacno As String, ByVal address As String, ByVal desc As String) As Boolean

        Dim command As New MySqlCommand("UPDATE `suppliers` SET `Supplier Name`=@sn,`Email`=@se,`ContactNo`=@sc,`Address`=@adr ,`Description`=@sd WHERE `Supplier ID`=@ID", db.getConnection)

        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id
        command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = supplyName
        command.Parameters.Add("@se", MySqlDbType.VarChar).Value = email
        command.Parameters.Add("@sc", MySqlDbType.VarChar).Value = contacno
        command.Parameters.Add("adr", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("sd", MySqlDbType.VarChar).Value = desc
        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        db.closeConnection()

    End Function
    Public Function checkSuppplierName(ByVal supplierName As String) As Boolean

        'This checks if supplierName already exist in the database
        Dim command As New MySqlCommand("SELECT * FROM `suppliers` WHERE `Supplier Name`=@sn", db.getConnection)
        command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = supplierName
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
