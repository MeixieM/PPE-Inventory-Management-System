Imports MySql.Data.MySqlClient
Public Class AddNewSup
    Dim db As New MY_DB()

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim supplier As New SUPPLIER()
        Dim supplyName As String = tb_supplierName.Text
        Dim email As String = tb_email.Text
        Dim contact As String = tb_contact.Text
        Dim address As String = tb_address.Text
        Dim desc As String = tb_description.Text


        If verify() Then
            If supplier.checkSuppplierName(supplyName) Then
                If supplier.insertSupplier(supplyName, email, contact, address, desc) Then
                    MsgBox("New Supplier Saved", MsgBoxStyle.Information, "Add Supplier")

                Else
                    MsgBox("Error", MsgBoxStyle.Critical, "Add Supplier")

                End If
            Else
                MsgBox("This Supplier Already Exists", MsgBoxStyle.Information, "Add Supplier")
            End If
        Else
                MsgBox("Empty Fields", MsgBoxStyle.Critical, "Add Supplier")
        End If
    End Sub
    Function verify() As Boolean
        If tb_supplierName.Text.Trim() = "" Or tb_email.Text.Trim() = "" Or tb_contact.Text.Trim() = "" Or tb_address.Text.Trim() = "" Or tb_description.Text.Trim() = "" Then

            Return False
        Else
            Return True
        End If

    End Function

End Class