Imports System.Data.OleDb
Imports System.IO

Public Class Table3_add
    Dim cn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            OpenFileDialog1.Filter = "JPEG |*.jpg|JPG |*.JPG|PNG |*.png|BMP |*.bmp|GIF |*.gif"
            OpenFileDialog1.ShowDialog()
            Dim path As String = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(path)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If txt_name.Text <> "" Then

            Try
                Dim ms As New MemoryStream()
                Dim arrimage() As Byte
                If (PictureBox1.Image IsNot Nothing) Then
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                    arrimage = ms.GetBuffer
                    ms.Close()
                End If
                With cmd
                    .Connection = cn
                    .CommandText = "INSERT INTO mc1_table(Name,FatherName,Mobile,Telephone,Gender,Email,DateOfBirth,Batch,Sess,City,Picture) VALUES(@a0,@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)"
                    .Parameters.Add("@a0", OleDbType.VarChar).Value = txt_name.Text
                    .Parameters.Add("@a1", OleDbType.VarChar).Value = txt_fathername.Text
                    .Parameters.Add("@a2", OleDbType.VarChar).Value = txt_mobile.Text
                    .Parameters.Add("@a3", OleDbType.VarChar).Value = txt_telephone.Text
                    .Parameters.Add("@a4", OleDbType.VarChar).Value = cb_gender.Text
                    .Parameters.Add("@a5", OleDbType.VarChar).Value = txt_email.Text
                    .Parameters.Add("@a6", OleDbType.VarChar).Value = txt_dob.Text
                    .Parameters.Add("@a7", OleDbType.VarChar).Value = cb_batch.Text
                    .Parameters.Add("@a8", OleDbType.VarChar).Value = cb_session.Text
                    .Parameters.Add("@a9", OleDbType.VarChar).Value = txt_city.Text
                    .Parameters.Add("@a10", OleDbType.Binary).Value = IIf(PictureBox1.Image IsNot Nothing, arrimage, DBNull.Value)
                    .ExecuteNonQuery()
                    .Dispose()
                    MsgBox("Record Saved", MsgBoxStyle.Information)
                    Me.Close()
                    '//
                    '//
                    '// Auto refresh the Records | New in this version
                    Table3.Mc1_tableTableAdapter.FillByName(Table3.Data_aioDataSet.mc1_table, "")
                    '//
                    '//
                    '//
                    '//REFRESH TOTAL RECORDS LABEL
                    Table3.lbl_total_records.Text = Table3.Data_aioDataSet.mc1_table.Rows.Count
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Name cannot be empty", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub mc1_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Data_aioDataSet.combobox_batch' table. You can move, or remove it, as needed.
        Me.Combobox_batchTableAdapter.Fill(Me.Data_aioDataSet.combobox_batch)
        'TODO: This line of code loads data into the 'Data_aioDataSet.combo_box_Session' table. You can move, or remove it, as needed.
        Me.Combo_box_SessionTableAdapter.Fill(Me.Data_aioDataSet.combo_box_Session)
        Dim str As String
        Dim readvalue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Management Soft", "Database Location", Nothing)
        Dim readvalue1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Management Soft", "Database Password", Nothing)
        str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & readvalue & ";Jet OLEDB:Database Password=" & readvalue1
        cn = New OleDbConnection(str)
        cn.Open()
    End Sub
End Class