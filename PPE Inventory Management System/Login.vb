Imports MySql.Data.MySqlClient
Public Class Login

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        pn_register.Visible = True
        Guna2Transition1.ShowSync(pn_register)

        pn_login.Visible = False

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        pn_register.Visible = False
        Guna2Transition1.HideSync(pn_register)

        pn_login.Visible = True


    End Sub
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

        Dim db As New MY_DB()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `user` WHERE `username` = @usn AND `password` = @pass", db.getConnection)

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = tb_Username.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tb_Password.Text

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Dim main = New MainForm
            MainForm.Show()
            Me.Close()

        Else
            MsgBox("Invalid Username or Password", MsgBoxStyle.Critical, "Login Error")
        End If

    End Sub

    Private Sub ckb_Show_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Show.CheckedChanged
        If tb_Password.UseSystemPasswordChar Then
            'show password
            tb_Password.UseSystemPasswordChar = False
        Else
            'hide password
            tb_Password.UseSystemPasswordChar = True
        End If
    End Sub



    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click

        Dim uname As String = tb_regusername.Text
        Dim pass As String = tb_regpass.Text
        Dim conpass As String = tb_regconpass.Text

        If uname.Trim() = "" Or pass.Trim() = "" Or conpass.Trim() = "" Then

            MsgBox("Empty Fields")
        ElseIf Not String.Equals(pass, conpass) Then

            MsgBox("Password doesn't match")

        ElseIf usernameExist(uname) Then
            MsgBox("Username already exist")
        Else

            Dim db As New MY_DB()
            Dim adapter As New MySqlDataAdapter()
            Dim table As New DataTable()
            Dim command As New MySqlCommand("INSERT INTO `user`(`username`, `password`) VALUES (@usn, @pass)", db.getConnection)


            command.Parameters.Add("usn", MySqlDbType.VarChar).Value = uname
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass

            db.openConnection()
            If command.ExecuteNonQuery() = 1 Then
                MsgBox("Account Successfully Created")
            Else
                MsgBox("Try Again")
                db.closeConnection()
            End If

        End If


    End Sub
    Public Function usernameExist(ByVal username As String) As Boolean

        Dim db As New MY_DB()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `user` WHERE `username` = @usn", db.getConnection)
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username

        adapter.SelectCommand = command
        adapter.Fill(table)

        'if the username exitst return true
        If table.Rows.Count > 0 Then
            Return True
            'if not return false
        Else
            Return False
        End If

    End Function

    Private Sub Guna2ControlBox1_Click_1(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Environment.Exit(0)
    End Sub
End Class
