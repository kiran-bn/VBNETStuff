' There are 3 rows in the db in 2 columns

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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex <> 0 Then
            ComboBox2.SelectedIndex = ComboBox1.SelectedIndex
            TextBox1.Text = DirectCast(ComboBox2.SelectedItem, KeyValuePair(Of String, String)).Key
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oledbCmd As OleDbCommand
        Dim sql As String

        Dim comboSource As New Dictionary(Of String, String)

        ConnectDB_Click()
        Try
            sql = "Select * From CustomerTable"
            oledbCmd = New OleDbCommand(sql, cnn)
            Dim oledbReader As OleDbDataReader = oledbCmd.ExecuteReader()
            comboSource.Add("", "")
            While oledbReader.Read
                comboSource.Add(oledbReader.Item(1), oledbReader.Item(0))

            End While
            oledbReader.Close()
            oledbCmd.Dispose()
            ComboBox1.DataSource = New BindingSource(comboSource, Nothing)
            ComboBox1.DisplayMember = "Value"
            ComboBox1.ValueMember = "Key"

            ComboBox2.DataSource = New BindingSource(comboSource, Nothing)
            ComboBox2.DisplayMember = "Value"
            ComboBox2.ValueMember = "Key"

        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try
        DisconnectDB_Click()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ComboBox1.Items.Count 'Displays the rows populated in the combobox. Shows 4 as the answer as there is a blank row in the combobox
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim val As String
        Dim text As String = DirectCast(ComboBox2.SelectedItem, KeyValuePair(Of String, String)).Value

        For i = 1 To ComboBox1.Items.Count
            ComboBox2.SelectedIndex.Equals(i) 'Forces the combobox to select the value based on the index. Useful for iterating
            val = DirectCast(ComboBox2.SelectedItem, KeyValuePair(Of String, String)).Value

            'the variable text could be any other variable maybe from global variables

            If text = val Then
                TextBox1.Text = val
                Exit For
            End If
        Next
    End Sub
End Class
