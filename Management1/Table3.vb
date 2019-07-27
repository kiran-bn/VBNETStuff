Public Class Table3

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        txt_name.ReadOnly = False
        txt_fathername.ReadOnly = False
        txt_mobile.ReadOnly = False
        txt_telephone.ReadOnly = False
        cb_gender.Enabled = True
        txt_email.ReadOnly = False
        txt_dob.ReadOnly = False
        txt_search.Enabled = False
        cb_session.Enabled = True
        txt_city.ReadOnly = False
        cb_batch.Enabled = True
        btn_addnew.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_changetable.Enabled = False
        btn_changepicture.Enabled = True
        btn_search.Enabled = False
        ComboBox4.Enabled = False
        checkbox_male.Enabled = False
        checkbox_female.Enabled = False
        DataGridView1.Enabled = False
        EditToolStripMenuItem1.Enabled = False
        UpdateToolStripMenuItem.Enabled = True
        DeleteToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        If txt_name.Text <> "" Then
            Mc1tableBindingSource.EndEdit()
            Mc1_tableTableAdapter.Update(Data_aioDataSet.mc1_table)
            MsgBox("Records Updated", MsgBoxStyle.Information, "Updated")
            txt_name.ReadOnly = True
            txt_fathername.ReadOnly = True
            txt_mobile.ReadOnly = True
            txt_telephone.ReadOnly = True
            cb_gender.Enabled = False
            txt_email.ReadOnly = True
            txt_dob.ReadOnly = True
            txt_search.Enabled = True
            cb_session.Enabled = False
            txt_city.ReadOnly = True
            cb_batch.Enabled = False
            btn_addnew.Enabled = True
            btn_edit.Enabled = True
            btn_delete.Enabled = True
            btn_changetable.Enabled = True
            btn_changepicture.Enabled = False
            btn_search.Enabled = True
            ComboBox4.Enabled = True
            checkbox_male.Enabled = True
            checkbox_female.Enabled = True
            DataGridView1.Enabled = True
            EditToolStripMenuItem1.Enabled = True
            UpdateToolStripMenuItem.Enabled = True
            DeleteToolStripMenuItem.Enabled = True
        Else
            MsgBox("Name cannot be empty", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub EditToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem1.Click

        btn_edit.PerformClick()



        'txt_name.ReadOnly = False
        'txt_fathername.ReadOnly = False
        'txt_mobile.ReadOnly = False
        'txt_telephone.ReadOnly = False
        'cb_gender.Enabled = True
        'txt_email.ReadOnly = False
        'txt_dob.ReadOnly = False
        'txt_search.Enabled = False
        'cb_session.Enabled = True
        'txt_city.ReadOnly = False
        'cb_batch.Enabled = True
        'btn_addnew.Enabled = False
        'btn_edit.Enabled = False
        'btn_delete.Enabled = False
        'btn_changetable.Enabled = False
        'btn_changepicture.Enabled = True
        'btn_search.Enabled = False
        'ComboBox4.Enabled = False
        'checkbox_male.Enabled = False
        'checkbox_female.Enabled = False
        'DataGridView1.Enabled = False
        'EditToolStripMenuItem1.Enabled = False
        'UpdateToolStripMenuItem.Enabled = True
        'DeleteToolStripMenuItem.Enabled = False
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click

        btn_update.PerformClick()


        'Mc1tableBindingSource.EndEdit()
        'Mc1_tableTableAdapter.Update(Data_aioDataSet.mc1_table)
        'MsgBox("Records Updated", MsgBoxStyle.Information, "Updated")
        'txt_name.ReadOnly = True
        'txt_fathername.ReadOnly = True
        'txt_mobile.ReadOnly = True
        'txt_telephone.ReadOnly = True
        'cb_gender.Enabled = False
        'txt_email.ReadOnly = True
        'txt_dob.ReadOnly = True
        'txt_search.Enabled = True
        'cb_session.Enabled = False
        'txt_city.ReadOnly = True
        'cb_batch.Enabled = False
        'btn_addnew.Enabled = True
        'btn_edit.Enabled = True
        'btn_delete.Enabled = True
        'btn_changetable.Enabled = True
        'btn_changepicture.Enabled = False
        'btn_search.Enabled = True
        'ComboBox4.Enabled = True
        'checkbox_male.Enabled = True
        'checkbox_female.Enabled = True
        'DataGridView1.Enabled = True
        'EditToolStripMenuItem1.Enabled = True
        'UpdateToolStripMenuItem.Enabled = True
        'DeleteToolStripMenuItem.Enabled = True
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewToolStripMenuItem.Click
        Table3_add.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_changetable.Click
        login.Show()
        login.Label1.Text = "Select Table"
        login.PictureBox2.Hide()
        login.ComboBox1.Show()
        login.ComboBox1.Text = Me.Text
        login.Button1.Show()
        login.Button4.Show()
        login.Timer1.Stop()
        login.PictureBox1.Hide()
        login.TextBox1.Hide()
        login.TextBox2.Hide()
        login.Button2.Hide()
        login.Button3.Hide()
        login.CheckBox1.Hide()
        login.Label2.Hide()
        login.Label3.Hide()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addnew.Click
        Table3_add.Show()
    End Sub

    Private Sub mc1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Data_aioDataSet.combobox_batch' table. You can move, or remove it, as needed.
        Me.Combobox_batchTableAdapter.Fill(Me.Data_aioDataSet.combobox_batch)
        'TODO: This line of code loads data into the 'Data_aioDataSet.combo_box_Session' table. You can move, or remove it, as needed.
        Me.Combo_box_SessionTableAdapter.Fill(Me.Data_aioDataSet.combo_box_Session)
        'TODO: This line of code loads data into the 'Data_aioDataSet.mc1_table' table. You can move, or remove it, as needed.
        Me.Mc1_tableTableAdapter.Fill(Me.Data_aioDataSet.mc1_table)
        lbl_total_records.Text = Data_aioDataSet.mc1_table.Rows.Count
        ComboBox4.Text = "Search by Name"
        Me.Text = login.ComboBox1.Text + " - Management"
        Try
            txt_name.DataBindings.Add("Text", Mc1tableBindingSource, "Name")
            txt_fathername.DataBindings.Add("Text", Mc1tableBindingSource, "FatherName")
            txt_mobile.DataBindings.Add("Text", Mc1tableBindingSource, "Mobile")
            txt_telephone.DataBindings.Add("Text", Mc1tableBindingSource, "Telephone")
            'cb_gender.DataBindings.Add("Text", Mc1tableBindingSource, "Gender")
            txt_email.DataBindings.Add("Text", Mc1tableBindingSource, "Email")
            txt_dob.DataBindings.Add("Text", Mc1tableBindingSource, "DateOfBirth")
            'cb_session.DataBindings.Add("Text", Mc1tableBindingSource, "Sess")
            txt_city.DataBindings.Add("Text", Mc1tableBindingSource, "City")
            'cb_batch.DataBindings.Add("Text", Mc1tableBindingSource, "Batch")
            PictureBox1.DataBindings.Add("Image", Mc1tableBindingSource, "Picture", True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddNewUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageUsersToolStripMenuItem.Click
        users.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click

        If txt_search.Text <> "" Then

            If ComboBox4.Text = "Search by Name" Then
                Try
                    Me.Mc1_tableTableAdapter.FillByName(Me.Data_aioDataSet.mc1_table, "%" & txt_search.Text & "%")
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            ElseIf ComboBox4.Text = "Search by Father Name" Then
                Try
                    Me.Mc1_tableTableAdapter.FillByFatherName(Me.Data_aioDataSet.mc1_table, "%" & txt_search.Text & "%")
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            ElseIf ComboBox4.Text = "Search by Mobile" Then
                Try
                    Me.Mc1_tableTableAdapter.FillByMobile(Me.Data_aioDataSet.mc1_table, "%" & txt_search.Text & "%")
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            ElseIf ComboBox4.Text = "Search by Telephone" Then
                Try
                    Me.Mc1_tableTableAdapter.FillByTelephone(Me.Data_aioDataSet.mc1_table, "%" & txt_search.Text & "%")
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            ElseIf ComboBox4.Text = "Search by Email" Then
                Try
                    Me.Mc1_tableTableAdapter.FillByEmail(Me.Data_aioDataSet.mc1_table, "%" & txt_search.Text & "%")
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            ElseIf ComboBox4.Text = "Search by Batch" Then
                Try
                    Me.Mc1_tableTableAdapter.FillByBatch(Me.Data_aioDataSet.mc1_table, "%" & txt_search.Text & "%")
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

            ElseIf ComboBox4.Text = "Search by Session" Then
                Try
                    Me.Mc1_tableTableAdapter.FillBySess(Me.Data_aioDataSet.mc1_table, "%" & txt_search.Text & "%")
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            End If

        Else

            Try
                Me.Mc1_tableTableAdapter.FillByName(Me.Data_aioDataSet.mc1_table, "")
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure, you want to delete this record ?", MsgBoxStyle.YesNo, "Confirm")
        If ask = MsgBoxResult.Yes Then
            Mc1tableBindingSource.RemoveCurrent()
            MsgBox("Record Removed", MsgBoxStyle.Information, "Removed")
            '//
            Mc1_tableTableAdapter.Update(Data_aioDataSet.mc1_table)
            '//REFRESH TOTAL RECORDS LABEL
            lbl_total_records.Text = Data_aioDataSet.mc1_table.Rows.Count
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure, you want to delete this record ?", MsgBoxStyle.YesNo, "Confirm")
        If ask = MsgBoxResult.Yes Then
            Mc1tableBindingSource.RemoveCurrent()
            MsgBox("Record Removed", MsgBoxStyle.Information, "Removed")
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkbox_male.CheckedChanged
        If checkbox_male.Checked Then
            checkbox_female.Checked = False
            Try
                Me.Mc1_tableTableAdapter.FillByGender(Me.Data_aioDataSet.mc1_table, "Male")
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf checkbox_male.Checked = False Then
            Try
                Me.Mc1_tableTableAdapter.Fill(Me.Data_aioDataSet.mc1_table)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkbox_female.CheckedChanged
        If checkbox_female.Checked Then
            checkbox_male.Checked = False
            Try
                Me.Mc1_tableTableAdapter.FillByGender(Me.Data_aioDataSet.Mc1_table, "Female")
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf checkbox_female.Checked = False Then
            Try
                Me.Mc1_tableTableAdapter.Fill(Me.Data_aioDataSet.Mc1_table)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub UToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UToolStripMenuItem.Click
        backup.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_changepicture.Click
        Try
            OpenFileDialog1.Filter = "JPEG |*.jpg|JPG |*.JPG|PNG |*.png|BMP |*.bmp|GIF |*.gif"
            OpenFileDialog1.ShowDialog()
            Dim path As String = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(path)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EditTablesListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditTablesListToolStripMenuItem.Click
        edit_list.Show()
    End Sub
End Class