Imports MySql.Data.MySqlClient
Public Class SupplierForm
    Dim supplier As New SUPPLIER()
    Dim db As New MY_DB()
    Sub populate()
        Dim command As New MySqlCommand("SELECT * FROM `suppliers`")

        dgv_suppliers.ReadOnly = True

        dgv_suppliers.RowTemplate.Height = 40

        dgv_suppliers.DataSource = supplier.getSupplier(command)

        dgv_suppliers.AllowUserToAddRows = False
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim addNewSup = New AddNewSup
        addNewSup.Show()
    End Sub

    Private Sub bt_refresh_Click(sender As Object, e As EventArgs) Handles bt_refresh.Click
        populate()

        tb_supplierID.Text = ""
        tb_supplierName.Text = ""
        tb_email.Text = ""
        tb_contact.Text = ""
        tb_address.Text = ""
        tb_description.Text = ""
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim id As Integer
        Dim supplier As New SUPPLIER()
        Dim supplyName As String = tb_supplierName.Text
        Dim email As String = tb_email.Text
        Dim contact As String = tb_contact.Text
        Dim address As String = tb_address.Text
        Dim desc As String = tb_description.Text

        If verify() Then
            Try
                id = Convert.ToInt32(tb_supplierID.Text)
            Catch ex As Exception
                MsgBox("Plese Enter A Valid Numeric ID", MsgBoxStyle.Exclamation, "Update Suppllier")
            End Try


            If supplier.updateSupplier(id, supplyName, email, contact, address, desc) Then
                MsgBox("Suppllier Details Updated", MsgBoxStyle.Information, "Add Suppllier")

            Else
                MsgBox("Error", MsgBoxStyle.Critical, "Update Suppllier")

            End If
        Else
            MsgBox("Empty Fields", MsgBoxStyle.Critical, "Update Suppllier")
        End If

        populate()

    End Sub
    Function verify() As Boolean
        If tb_supplierID.Text.Trim() = "" Or tb_supplierName.Text.Trim() = "" Or tb_email.Text.Trim() = "" Or tb_contact.Text.Trim() = "" Or tb_address.Text.Trim() = "" Or tb_description.Text.Trim() = "" Then

            Return False
        Else
            Return True
        End If

    End Function

    'Sub to fill the datagridview

    Sub Fillgrid(ByVal command As MySqlCommand)

        dgv_suppliers.ReadOnly = True

        dgv_suppliers.RowTemplate.Height = 40

        dgv_suppliers.DataSource = supplier.getSupplier(command)

        dgv_suppliers.AllowUserToAddRows = False

    End Sub

    Private Sub tb_search_TextChanged(sender As Object, e As EventArgs) Handles tb_search.TextChanged
        Dim command As New MySqlCommand("SELECT * FROM `suppliers` WHERE CONCAT(`Supplier ID`,`Supplier Name`,`Email`,`ContactNo`,`Address`,`Description`)LIKE '%" & tb_search.Text & "%'")
        Fillgrid(command)

    End Sub

    Private Sub SupplierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub dgv_suppliers_DoubleClick(sender As Object, e As EventArgs) Handles dgv_suppliers.DoubleClick
        'Display the selected row data into 

        tb_supplierID.Text = dgv_suppliers.CurrentRow.Cells(0).Value.ToString()
        tb_supplierName.Text = dgv_suppliers.CurrentRow.Cells(1).Value.ToString()
        tb_email.Text = dgv_suppliers.CurrentRow.Cells(2).Value.ToString()
        tb_contact.Text = dgv_suppliers.CurrentRow.Cells(3).Value.ToString()
        tb_address.Text = dgv_suppliers.CurrentRow.Cells(4).Value.ToString()
        tb_description.Text = dgv_suppliers.CurrentRow.Cells(5).Value.ToString()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        'Delete product
        Try
            Dim supplierID As Integer = Convert.ToInt32(tb_supplierID.Text)
            If MsgBox("Are you sure you want to delete this supplier?", MsgBoxStyle.YesNo, "Delete Supplier") = MsgBoxResult.Yes Then

                If supplier.deleteSupplier(supplierID) Then
                    MsgBox("Product Supplier", MsgBoxStyle.Information, "Delete Supplier")
                Else
                    MsgBox("Product Not Supplier", MsgBoxStyle.Information, "Delete Supplier")
                End If

            End If

        Catch ex As Exception
            MsgBox("Plese enter a Valid ID", MsgBoxStyle.Information, "Delete Supplier")
        End Try
        populate()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        'Print datagridview Inventory
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.dgv_suppliers.Width, Me.dgv_suppliers.Height)
        dgv_suppliers.DrawToBitmap(bm, New Rectangle(0, 0, Me.dgv_suppliers.Width, Me.dgv_suppliers.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
End Class