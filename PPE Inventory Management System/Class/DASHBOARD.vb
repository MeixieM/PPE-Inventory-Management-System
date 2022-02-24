Imports MySql.Data.MySqlClient
Public Class DASHBOARD

    Dim db As New MY_DB()
    'Function to load supplier database


    Public Function getDashboard(ByVal command As MySqlCommand) As DataTable

        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table

    End Function

    Function execCount(ByVal query As String) As String
        Dim command As New MySqlCommand(query, db.getConnection)

        db.openConnection()
        Return command.ExecuteScalar().ToString()
        db.closeConnection()
    End Function
    Function totalFaceMask() As String
        Return execCount("SELECT SUM(`Qty.`) FROM `inventory` WHERE (`Category`)LIKE '%Face Mask%'")
    End Function
    Function totalAlcohol() As String
        Return execCount("SELECT SUM(`Qty.`) FROM `inventory` WHERE (`Category`)LIKE '%Alcohol/Sanitizers%'")
    End Function
    Function totalGoggles() As String
        Return execCount("SELECT SUM(`Qty.`) FROM `inventory` WHERE (`Category`)LIKE '%Goggles%'")
    End Function
    Function totalThermometer() As String
        Return execCount("SELECT SUM(`Qty.`) FROM `inventory` WHERE (`Category`)LIKE '%Thermometer%'")
    End Function
    Function totalGloves() As String
        Return execCount("SELECT SUM(`Qty.`) FROM `inventory` WHERE (`Category`)LIKE '%Gloves%'")
    End Function
    Function totalFaceShield() As String
        Return execCount("SELECT SUM(`Qty.`) FROM `inventory` WHERE (`Category`)LIKE '%Face Shield%'")
    End Function

    Function totalGowns() As String
        Return execCount("SELECT SUM(`Qty.`) FROM `inventory` WHERE (`Category`)LIKE '%Gown%'")
    End Function

    Function totalInStock() As String
        Return execCount("SELECT count(*) FROM `inventory` WHERE (`Availability`)LIKE '%In Stock%'")
    End Function

    Function totalOutofStock() As String
        Return execCount("SELECT count(*) FROM `inventory` WHERE (`Availability`)LIKE '%Out of Stock%'")
    End Function
    Function totalPrice() As String
        Return execCount("SELECT SUM(`Total`) FROM `inventory`")
    End Function
End Class
