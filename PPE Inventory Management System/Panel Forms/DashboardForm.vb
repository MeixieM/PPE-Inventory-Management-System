Imports MySql.Data.MySqlClient
Public Class DashboardForm
    Dim db As New MY_DB()


    Sub loaddashboard()
        Dim dashboard As New DASHBOARD()

        Dim totalMask As String = (dashboard.totalFaceMask)
        lb_facemask.Text = totalMask

        Dim totalAlcohol As String = (dashboard.totalAlcohol)
        lb_alcohol.Text = totalAlcohol

        Dim totalGoggles As String = (dashboard.totalGoggles)
        lb_goggles.Text = totalGoggles

        Dim totalThermometer As String = (dashboard.totalThermometer)
        lb_gun.Text = totalThermometer

        Dim totalGloves As String = (dashboard.totalGloves)
        lb_gloves.Text = totalGloves

        Dim totalFaceShield As String = (dashboard.totalFaceShield)
        lb_shield.Text = totalFaceShield

        Dim totalGowns As String = (dashboard.totalGowns)
        lb_gowns.Text = totalGowns

        Dim totalInStock As String = (dashboard.totalInStock)
        lbl_instock.Text = totalInStock

        Dim totalOutofStock As String = (dashboard.totalOutofStock)
        lbl_outofstock.Text = totalOutofStock

        Dim totalPrice As String = (dashboard.totalPrice)
        lbl_price.Text = totalPrice
    End Sub

    Sub loadChar()

    End Sub
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddashboard()
    End Sub


End Class