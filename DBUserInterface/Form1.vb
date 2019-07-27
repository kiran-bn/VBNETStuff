Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Form1
    Public cnn As OleDbConnection
    Private Sub ConnectDB_Click() 'sender As Object, e As EventArgs) ' Handles ConnectDB.Click
        Dim connetionString As String
        'Dim cnn As OleDbConnection
        connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Nirmal\Documents\TestDB.accdb';"
        cnn = New OleDbConnection(connetionString)
        Try
            cnn.Open()
            'MsgBox("Connection Open ! ")
            'cnn.Close()
        Catch ex As Exception
            MsgBox("Cannot open connection ! ")
        End Try
    End Sub

    Private Sub DisconnectDB_Click() 'sender As Object, e As EventArgs) ' Handles DisconnectDB.Click
        Try
            cnn.Close()
            'MsgBox("Connection Closed ! ")
        Catch ex As Exception
            MsgBox("Cannot close connection ! ")
        End Try
    End Sub

    Private Sub SaveCustomer_Click(sender As Object, e As EventArgs) Handles SaveCustomer.Click
        Dim SQLQuery As String
        Dim cmd As OleDbCommand
        ConnectDB_Click()
        Try
            SQLQuery = "Insert into CustomerTable (Cust_name,Cust_id) values ('" + CustNameTextBox.Text + "','" & CustIDTextBox.Text & "')"
            cmd = New OleDbCommand(SQLQuery, cnn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Data added !!")
        Catch ex As Exception
            MsgBox("Cannot open connection ! ")
        End Try
        DisconnectDB_Click()
    End Sub

    Private Sub CountCustomerButton_Click(sender As Object, e As EventArgs) Handles CountCustomerButton.Click
        Dim cmd As OleDbCommand
        Dim sql As String
        ConnectDB_Click()
        'connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password"
        sql = "Select count(*) From CustomerTable"
        'cnn = New SqlConnection(connetionString)
        Try
            cmd = New OleDbCommand(sql, cnn)
            Dim count As Integer = cmd.ExecuteScalar()
            cmd.Dispose()
            MsgBox(" No of Rows " & count)
        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try
        DisconnectDB_Click()
    End Sub

    Private Sub ReadButton_Click(sender As Object, e As EventArgs) Handles ReadButton.Click
        Dim oledbCmd As OleDbCommand
        Dim sql As String
        ConnectDB_Click()
        Try
            sql = "Select * From CustomerTable"
            oledbCmd = New OleDbCommand(sql, cnn)
            Dim oledbReader As OleDbDataReader = oledbCmd.ExecuteReader()
            While oledbReader.Read
                MsgBox(oledbReader.Item(0) & "  -  " & oledbReader.Item(1))
            End While
            oledbReader.Close()
            oledbCmd.Dispose()

        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try
        DisconnectDB_Click()
    End Sub

End Class
