<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Table2_add
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Table2_add))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_session = New System.Windows.Forms.ComboBox()
        Me.ComboboxSessionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_aioDataSet = New Management.data_aioDataSet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cb_batch = New System.Windows.Forms.ComboBox()
        Me.ComboboxbatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_telephone = New System.Windows.Forms.TextBox()
        Me.cb_gender = New System.Windows.Forms.ComboBox()
        Me.txt_city = New System.Windows.Forms.TextBox()
        Me.txt_dob = New System.Windows.Forms.TextBox()
        Me.txt_mobile = New System.Windows.Forms.TextBox()
        Me.txt_fathername = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Combobox_batchTableAdapter = New Management.data_aioDataSetTableAdapters.combobox_batchTableAdapter()
        Me.Combo_box_SessionTableAdapter = New Management.data_aioDataSetTableAdapters.combo_box_SessionTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ComboboxSessionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_aioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboboxbatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 366)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(521, 45)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(263, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Save Record"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_session)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cb_batch)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.txt_telephone)
        Me.GroupBox1.Controls.Add(Me.cb_gender)
        Me.GroupBox1.Controls.Add(Me.txt_city)
        Me.GroupBox1.Controls.Add(Me.txt_dob)
        Me.GroupBox1.Controls.Add(Me.txt_mobile)
        Me.GroupBox1.Controls.Add(Me.txt_fathername)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(9, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 351)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'cb_session
        '
        Me.cb_session.DataSource = Me.ComboboxSessionBindingSource
        Me.cb_session.DisplayMember = "List"
        Me.cb_session.DropDownHeight = 107
        Me.cb_session.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_session.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_session.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.cb_session.FormattingEnabled = True
        Me.cb_session.IntegralHeight = False
        Me.cb_session.Location = New System.Drawing.Point(112, 285)
        Me.cb_session.Name = "cb_session"
        Me.cb_session.Size = New System.Drawing.Size(190, 23)
        Me.cb_session.TabIndex = 8
        Me.cb_session.ValueMember = "List"
        '
        'ComboboxSessionBindingSource
        '
        Me.ComboboxSessionBindingSource.DataMember = "combo_box_Session"
        Me.ComboboxSessionBindingSource.DataSource = Me.Data_aioDataSet
        '
        'Data_aioDataSet
        '
        Me.Data_aioDataSet.DataSetName = "data_aioDataSet"
        Me.Data_aioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(15, 287)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Session :"
        '
        'cb_batch
        '
        Me.cb_batch.DataSource = Me.ComboboxbatchBindingSource
        Me.cb_batch.DisplayMember = "List"
        Me.cb_batch.DropDownHeight = 107
        Me.cb_batch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_batch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_batch.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.cb_batch.FormattingEnabled = True
        Me.cb_batch.IntegralHeight = False
        Me.cb_batch.Location = New System.Drawing.Point(112, 319)
        Me.cb_batch.Name = "cb_batch"
        Me.cb_batch.Size = New System.Drawing.Size(72, 23)
        Me.cb_batch.TabIndex = 9
        Me.cb_batch.ValueMember = "List"
        '
        'ComboboxbatchBindingSource
        '
        Me.ComboboxbatchBindingSource.DataMember = "combobox_batch"
        Me.ComboboxbatchBindingSource.DataSource = Me.Data_aioDataSet
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Batch :"
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(398, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(345, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.txt_email.Location = New System.Drawing.Point(112, 253)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(191, 22)
        Me.txt_email.TabIndex = 7
        '
        'txt_telephone
        '
        Me.txt_telephone.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.txt_telephone.Location = New System.Drawing.Point(112, 219)
        Me.txt_telephone.Name = "txt_telephone"
        Me.txt_telephone.Size = New System.Drawing.Size(191, 22)
        Me.txt_telephone.TabIndex = 6
        '
        'cb_gender
        '
        Me.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_gender.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.cb_gender.FormattingEnabled = True
        Me.cb_gender.Items.AddRange(New Object() {"", "Male", "Female"})
        Me.cb_gender.Location = New System.Drawing.Point(112, 83)
        Me.cb_gender.Name = "cb_gender"
        Me.cb_gender.Size = New System.Drawing.Size(190, 23)
        Me.cb_gender.TabIndex = 2
        '
        'txt_city
        '
        Me.txt_city.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.txt_city.Location = New System.Drawing.Point(112, 151)
        Me.txt_city.Name = "txt_city"
        Me.txt_city.Size = New System.Drawing.Size(191, 22)
        Me.txt_city.TabIndex = 4
        '
        'txt_dob
        '
        Me.txt_dob.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.txt_dob.Location = New System.Drawing.Point(112, 117)
        Me.txt_dob.Name = "txt_dob"
        Me.txt_dob.Size = New System.Drawing.Size(191, 22)
        Me.txt_dob.TabIndex = 3
        '
        'txt_mobile
        '
        Me.txt_mobile.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.txt_mobile.Location = New System.Drawing.Point(112, 186)
        Me.txt_mobile.Name = "txt_mobile"
        Me.txt_mobile.Size = New System.Drawing.Size(191, 22)
        Me.txt_mobile.TabIndex = 5
        '
        'txt_fathername
        '
        Me.txt_fathername.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.txt_fathername.Location = New System.Drawing.Point(112, 49)
        Me.txt_fathername.Name = "txt_fathername"
        Me.txt_fathername.Size = New System.Drawing.Size(191, 22)
        Me.txt_fathername.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(112, 15)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(191, 22)
        Me.txt_name.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "City :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(15, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Email :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Telephone :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Father Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Mobile :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Gender :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Date of birth :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.ShowHelp = True
        Me.OpenFileDialog1.Title = "Browse"
        '
        'Combobox_batchTableAdapter
        '
        Me.Combobox_batchTableAdapter.ClearBeforeFill = True
        '
        'Combo_box_SessionTableAdapter
        '
        Me.Combo_box_SessionTableAdapter.ClearBeforeFill = True
        '
        'mc_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(539, 422)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mc_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New - Management"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ComboboxSessionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_aioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboboxbatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_batch As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_telephone As System.Windows.Forms.TextBox
    Friend WithEvents cb_gender As System.Windows.Forms.ComboBox
    Friend WithEvents txt_city As System.Windows.Forms.TextBox
    Friend WithEvents txt_dob As System.Windows.Forms.TextBox
    Friend WithEvents txt_mobile As System.Windows.Forms.TextBox
    Friend WithEvents txt_fathername As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cb_session As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Data_aioDataSet As Management.data_aioDataSet
    Friend WithEvents ComboboxbatchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Combobox_batchTableAdapter As Management.data_aioDataSetTableAdapters.combobox_batchTableAdapter
    Friend WithEvents ComboboxSessionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Combo_box_SessionTableAdapter As Management.data_aioDataSetTableAdapters.combo_box_SessionTableAdapter
End Class
