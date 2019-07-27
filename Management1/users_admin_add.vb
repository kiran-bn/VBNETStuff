Imports System.Data.OleDb
Imports System.IO

Public Class users_admin_add
    Dim cn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox3.Text <> "" Then

                If TextBox4.Text <> "" Then

                    If TextBox4.Text = TextBox5.Text Then
                        Dim ms As New MemoryStream()
                        With cmd
                            .Connection = cn
                            .CommandText = "INSERT INTO users_data1(Name,Email,Gender,Username,Pass) VALUES(@a0,@a1,@a2,@a3,@a4)"
                            .Parameters.Add("@a0", OleDbType.VarChar).Value = TextBox1.Text
                            .Parameters.Add("@a1", OleDbType.VarChar).Value = TextBox2.Text
                            .Parameters.Add("@a2", OleDbType.VarChar).Value = ComboBox1.Text
                            .Parameters.Add("@a3", OleDbType.VarChar).Value = TextBox3.Text
                            .Parameters.Add("@a4", OleDbType.VarChar).Value = TextBox4.Text
                            .ExecuteNonQuery()
                            .Dispose()
                            TextBox1.Text = ""
                            TextBox2.Text = ""
                            ComboBox1.Text = ""
                            TextBox3.Text = ""
                            TextBox4.Text = ""
                            TextBox5.Text = ""
                            MsgBox("User Registered", MsgBoxStyle.Information)
                            Me.Close()
                            '//
                            '// 
                            Try
                                '// UPDATE USERS LIST AFTER NEW
                                users.Users_data1TableAdapter.update_admin_users(users.Data_aioDataSet.users_data1, "")
                                ''
                                ''
                                'This line will update total users count
                                users.Label14.Text = users.Data_aioDataSet.users_data1.Rows.Count
                            Catch ex As System.Exception
                                System.Windows.Forms.MessageBox.Show(ex.Message)
                            End Try
                            '//
                            '//
                        End With

                    Else
                        MsgBox("Password doesn't match", MsgBoxStyle.Information, "Error")
                    End If

                Else
                    MsgBox("Password cannot be empty", MsgBoxStyle.Exclamation, "Error")
                End If

            Else
                MsgBox("Username, cannot be empty", MsgBoxStyle.Exclamation, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub users_admin_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str As String
        Dim readvalue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Management Soft", "Database Location", Nothing)
        Dim readvalue1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Management Soft", "Database Password", Nothing)
        str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & readvalue & ";Jet OLEDB:Database Password=" & readvalue1
        cn = New OleDbConnection(str)
        cn.Open()
    End Sub
End Class