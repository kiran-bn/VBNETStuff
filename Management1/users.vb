Public Class users

    Private Sub users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Data_aioDataSet.users_data1' table. You can move, or remove it, as needed.
        Me.Users_data1TableAdapter.Fill(Me.Data_aioDataSet.users_data1)

        'TODO: This line of code loads data into the 'Data_aioDataSet.users_data' table. You can move, or remove it, as needed.
        Me.Users_dataTableAdapter.Fill(Me.Data_aioDataSet.users_data)

        Label7.Text = Data_aioDataSet.users_data.Rows.Count
        '//////////////////////////////
        Label14.Text = Data_aioDataSet.users_data1.Rows.Count
    End Sub

    '/////////////////////////////////////
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    ''/'//'//'//    OTHER USERS
    '////////////////////////////////////
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            TextBox4.UseSystemPasswordChar = False
        End If
        If CheckBox1.CheckState = CheckState.Unchecked Then
            TextBox4.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        users_add.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button4.Enabled = False
        DataGridView1.Enabled = False
        TextBox1.ReadOnly = False
        TextBox2.ReadOnly = False
        ComboBox1.Enabled = True
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Try
            If TextBox1.Text <> "" Then

                If TextBox3.Text <> "" Then

                    If TextBox4.Text <> "" Then

                        UsersdataBindingSource.EndEdit()
                        Users_dataTableAdapter.Update(Data_aioDataSet.users_data)
                        MsgBox("Records Updated", MsgBoxStyle.Information, "Updated")
                        Button1.Enabled = True
                        Button2.Enabled = True
                        Button4.Enabled = True
                        DataGridView1.Enabled = True
                        TextBox1.ReadOnly = True
                        TextBox2.ReadOnly = True
                        ComboBox1.Enabled = False
                        TextBox3.ReadOnly = True
                        TextBox4.ReadOnly = True

                    Else
                        MsgBox("Password cannot be empty", MsgBoxStyle.Exclamation, "Error")

                    End If

                Else
                    MsgBox("UserName cannot be empty", MsgBoxStyle.Exclamation, "Error")

                End If

            Else
                MsgBox("Name cannot be empty", MsgBoxStyle.Exclamation, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure, you want to remove this user ?", MsgBoxStyle.YesNo, "Delete")
        If ask = MsgBoxResult.Yes Then
            Try
                UsersdataBindingSource.RemoveCurrent()
                MsgBox("Record Removed", MsgBoxStyle.Information, "Removed")
                Users_dataTableAdapter.Update(Data_aioDataSet.users_data)
                Label7.Text = Data_aioDataSet.users_data.Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    '/////////////////////////////////////
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    ''/'//'//'//    ADMIN USERS
    '////////////////////////////////////
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        users_admin_add.Show()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Button6.Enabled = False
        Button7.Enabled = False
        Button9.Enabled = False
        DataGridView2.Enabled = False
        TextBox5.ReadOnly = False
        TextBox6.ReadOnly = False
        ComboBox2.Enabled = True
        TextBox7.ReadOnly = False
        TextBox8.ReadOnly = False
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click

        Try
            If TextBox5.Text <> "" Then

                If TextBox7.Text <> "" Then

                    If TextBox8.Text <> "" Then

                        Users_data1BindingSource.EndEdit()
                        Users_data1TableAdapter.Update(Data_aioDataSet.users_data1)
                        MsgBox("Records Updated", MsgBoxStyle.Information, "Updated")
                        Button6.Enabled = True
                        Button7.Enabled = True
                        Button9.Enabled = True
                        DataGridView2.Enabled = True
                        TextBox5.ReadOnly = True
                        TextBox6.ReadOnly = True
                        ComboBox2.Enabled = False
                        TextBox7.ReadOnly = True
                        TextBox8.ReadOnly = True

                    Else
                        MsgBox("Password cannot be empty", MsgBoxStyle.Exclamation, "Error")

                    End If

                Else
                    MsgBox("UserName cannot be empty", MsgBoxStyle.Exclamation, "Error")

                End If

            Else
                MsgBox("Name cannot be empty", MsgBoxStyle.Exclamation, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = CheckState.Checked Then
            TextBox8.UseSystemPasswordChar = False
        End If
        If CheckBox2.CheckState = CheckState.Unchecked Then
            TextBox8.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure, you want to remove this user ?", MsgBoxStyle.YesNo, "Delete")
        If ask = MsgBoxResult.Yes Then
            Try
                Users_data1BindingSource.RemoveCurrent()
                MsgBox("Record Removed", MsgBoxStyle.Information, "Removed")
                Users_data1TableAdapter.Update(Data_aioDataSet.users_data1)
                Label14.Text = Data_aioDataSet.users_data1.Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class