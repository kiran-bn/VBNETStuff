Imports System.Text
Imports System.IO

Public Class login
    '//
    '// Read Settings file
    '//
    Dim File = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Management Soft", "Settings Location", Nothing)
    Dim List = "List"
    Dim a = "a"
    Dim b = "b"
    Dim c = "c"
    '//////////////////////
    '//////////////////////
    '\\\\\\\\\\\\\\\\\\\\\\
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Users_dataTableAdapter1.Fill(Me.Data_aioDataSet.users_data)
            Me.Users_data1TableAdapter.Fill(Me.Data_aioDataSet.users_data1)
        Catch ex As Exception
            MsgBox("Database not found, Please setup database first" & vbNewLine & "Error may be dut to:" & vbNewLine & "   1 - Database location" & vbNewLine & "   2 - Database Password" & vbNewLine & "   3 - Microsoft OLEDB 12.0 not registered on your mechine", MsgBoxStyle.Exclamation, "Error")
            Button3.Enabled = False
        End Try
        '////////////////

        '//
        '//                                         READ TABLES LIST FROM SETTNGS FILE

        If My.Computer.FileSystem.FileExists(File) Then
            Dim table1 = ReadIni(File, List, a, "")
            Dim table2 = ReadIni(File, List, b, "")
            Dim table3 = ReadIni(File, List, c, "")

            Dim columns() As String = {table1, table2, table3}
            For Each column As String In columns
                ComboBox1.Items.Add(column)
            Next
            ComboBox1.SelectedIndex = 0
        Else
            MsgBox("Settings File not found, Please setup settings file first", MsgBoxStyle.Exclamation, "Error")
            Button4.Enabled = False
        End If

        '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        '////////////////////////////////////
        '========This will get database information
        '========from windows registry | Don't remove it
        '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        '////////////////////////////////////
        Try
            Dim readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Management Soft", "Database Location", Nothing)
            Dim readvalue1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Management Soft", "Database Password", Nothing)
            My.Settings.Item("data_aioConnectionString") = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & readValue & ";Jet OLEDB:Database Password=" & readvalue1
        Catch ex As Exception
            MsgBox("Database Connection Error", MsgBoxStyle.Exclamation, "Error")
            Button3.Enabled = False
        End Try

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim username As String
            Dim password As String

            username = TextBox1.Text
            password = TextBox2.Text

            If Me.Users_dataTableAdapter1.ScalarQueryLogin(username, password) Then   'ORDINARY USER LOGIN
                PictureBox1.Hide()
                TextBox1.Hide()
                TextBox2.Hide()
                Button2.Hide()
                Button3.Hide()
                CheckBox1.Hide()
                Label2.Hide()
                Label3.Hide()
                Label1.Text = "Loading ..."
                PictureBox2.Show()
                Timer1.Start()

                '//
                '// IF USER IS LOGGED IN AS ORDINARY USER THEN ADMIN FEATURES ARE HIDDEN
                '//
                '// HIDDEN IN Table 1
                Table1.ManageUsersToolStripMenuItem.Visible = False
                Table1.UToolStripMenuItem.Visible = False
                Table1.ToolStripSeparator1.Visible = False
                Table1.EditTablesListToolStripMenuItem.Visible = False
                '//
                '// HIDDEN IN Table 2
                Table2.ManageUsersToolStripMenuItem.Visible = False
                Table2.UToolStripMenuItem.Visible = False
                Table2.ToolStripSeparator1.Visible = False
                Table2.EditTablesListToolStripMenuItem.Visible = False
                '//
                '// HIDDEN IN Table 3
                Table3.ManageUsersToolStripMenuItem.Visible = False
                Table3.UToolStripMenuItem.Visible = False
                Table3.ToolStripSeparator1.Visible = False
                Table2.EditTablesListToolStripMenuItem.Visible = False

                '/////////////////////////////////////
                '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            ElseIf Me.Users_data1TableAdapter.ScalarQueryLogin(username, password) Then   'ADMIN USER LOGIN

                PictureBox1.Hide()
                TextBox1.Hide()
                TextBox2.Hide()
                Button2.Hide()
                Button3.Hide()
                CheckBox1.Hide()
                Label2.Hide()
                Label3.Hide()
                Label1.Text = "Loading ..."
                PictureBox2.Show()
                Timer1.Start()
            Else
                MsgBox("Username or Password is incorrect", MsgBoxStyle.Information, "Login Error")
                TextBox2.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Database Error", MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        '\\\\\\\\\\\\\   HERE YOU CAN CHANGE WHICH TABLE TO SHOW BY COMBOBOX TEXT | LIKE  SHOW TABLE <MC> BY SELECTING <TABLE1> FROM COMBOBOX  \\\\\\\\\\\\\\\\

        If ComboBox1.Text = ReadIni(File, List, a, "") Then
            Table1.Show()
            Table1.Text = ReadIni(File, List, a, "") & " - Management"
            Me.Close()
        ElseIf ComboBox1.Text = ReadIni(File, List, b, "") Then
            Table2.Show()
            Table2.Text = ReadIni(File, List, b, "") & " - Management"
            Me.Close()
        ElseIf ComboBox1.Text = ReadIni(File, List, c, "") Then
            Table3.Show()
            Table3.Text = ReadIni(File, List, c, "") & " - Management"
            Me.Close()
        Else
            MsgBox("Table not found or loading error", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 40 Then
            Label1.Text = "Select Table"
            PictureBox2.Hide()
            ComboBox1.Show()
            Button1.Show()
            Button4.Show()
            Timer1.Stop()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
