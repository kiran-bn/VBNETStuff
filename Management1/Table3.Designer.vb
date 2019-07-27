<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Table3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Table3))
        Me.cb_batch = New System.Windows.Forms.ComboBox()
        Me.Mc1tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_aioDataSet = New Management.data_aioDataSet()
        Me.ComboboxbatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_addnew = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkbox_female = New System.Windows.Forms.CheckBox()
        Me.checkbox_male = New System.Windows.Forms.CheckBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboboxSessionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_changepicture = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditTablesListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_telephone = New System.Windows.Forms.TextBox()
        Me.cb_gender = New System.Windows.Forms.ComboBox()
        Me.txt_city = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_changetable = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_total_records = New System.Windows.Forms.Label()
        Me.txt_dob = New System.Windows.Forms.TextBox()
        Me.txt_mobile = New System.Windows.Forms.TextBox()
        Me.txt_fathername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_session = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Mc1_tableTableAdapter = New Management.data_aioDataSetTableAdapters.mc1_tableTableAdapter()
        Me.Combo_box_SessionTableAdapter = New Management.data_aioDataSetTableAdapters.combo_box_SessionTableAdapter()
        Me.Combobox_batchTableAdapter = New Management.data_aioDataSetTableAdapters.combobox_batchTableAdapter()
        CType(Me.Mc1tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_aioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboboxbatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ComboboxSessionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_batch
        '
        Me.cb_batch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mc1tableBindingSource, "Batch", True))
        Me.cb_batch.DataSource = Me.ComboboxbatchBindingSource
        Me.cb_batch.DisplayMember = "List"
        Me.cb_batch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_batch.Enabled = False
        Me.cb_batch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_batch.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.cb_batch.FormattingEnabled = True
        Me.cb_batch.IntegralHeight = False
        Me.cb_batch.Location = New System.Drawing.Point(436, 151)
        Me.cb_batch.Name = "cb_batch"
        Me.cb_batch.Size = New System.Drawing.Size(72, 23)
        Me.cb_batch.TabIndex = 18
        '
        'Mc1tableBindingSource
        '
        Me.Mc1tableBindingSource.DataMember = "mc1_table"
        Me.Mc1tableBindingSource.DataSource = Me.Data_aioDataSet
        '
        'Data_aioDataSet
        '
        Me.Data_aioDataSet.DataSetName = "data_aioDataSet"
        Me.Data_aioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Label10.Location = New System.Drawing.Point(340, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Batch :"
        '
        'btn_addnew
        '
        Me.btn_addnew.Location = New System.Drawing.Point(112, 12)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(75, 23)
        Me.btn_addnew.TabIndex = 0
        Me.btn_addnew.Text = "Add New"
        Me.btn_addnew.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.checkbox_female)
        Me.GroupBox3.Controls.Add(Me.checkbox_male)
        Me.GroupBox3.Controls.Add(Me.btn_search)
        Me.GroupBox3.Controls.Add(Me.ComboBox4)
        Me.GroupBox3.Controls.Add(Me.txt_search)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 287)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(799, 42)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'checkbox_female
        '
        Me.checkbox_female.AutoSize = True
        Me.checkbox_female.Location = New System.Drawing.Point(627, 16)
        Me.checkbox_female.Name = "checkbox_female"
        Me.checkbox_female.Size = New System.Drawing.Size(60, 17)
        Me.checkbox_female.TabIndex = 14
        Me.checkbox_female.Text = "Female"
        Me.checkbox_female.UseVisualStyleBackColor = True
        '
        'checkbox_male
        '
        Me.checkbox_male.AutoSize = True
        Me.checkbox_male.Location = New System.Drawing.Point(577, 16)
        Me.checkbox_male.Name = "checkbox_male"
        Me.checkbox_male.Size = New System.Drawing.Size(49, 17)
        Me.checkbox_male.TabIndex = 13
        Me.checkbox_male.Text = "Male"
        Me.checkbox_male.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(315, 12)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 12
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownHeight = 107
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox4.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.IntegralHeight = False
        Me.ComboBox4.Items.AddRange(New Object() {"Search by Name", "Search by Father Name", "Search by Mobile", "Search by Telephone", "Search by Email", "Search by Batch"})
        Me.ComboBox4.Location = New System.Drawing.Point(400, 12)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(151, 23)
        Me.ComboBox4.TabIndex = 11
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.txt_search.Location = New System.Drawing.Point(110, 12)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(191, 22)
        Me.txt_search.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(21, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Search :"
        '
        'ComboboxSessionBindingSource
        '
        Me.ComboboxSessionBindingSource.DataMember = "combo_box_Session"
        Me.ComboboxSessionBindingSource.DataSource = Me.Data_aioDataSet
        '
        'btn_changepicture
        '
        Me.btn_changepicture.Enabled = False
        Me.btn_changepicture.FlatAppearance.BorderSize = 0
        Me.btn_changepicture.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_changepicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_changepicture.Location = New System.Drawing.Point(689, 175)
        Me.btn_changepicture.Name = "btn_changepicture"
        Me.btn_changepicture.Size = New System.Drawing.Size(60, 23)
        Me.btn_changepicture.TabIndex = 12
        Me.btn_changepicture.Text = ".........."
        Me.btn_changepicture.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(821, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AddNewToolStripMenuItem.Text = "Add New"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(120, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem1, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageUsersToolStripMenuItem, Me.UToolStripMenuItem, Me.EditTablesListToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ManageUsersToolStripMenuItem.Text = "Manage users"
        '
        'UToolStripMenuItem
        '
        Me.UToolStripMenuItem.Name = "UToolStripMenuItem"
        Me.UToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.UToolStripMenuItem.Text = "Backup Database"
        '
        'EditTablesListToolStripMenuItem
        '
        Me.EditTablesListToolStripMenuItem.Name = "EditTablesListToolStripMenuItem"
        Me.EditTablesListToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EditTablesListToolStripMenuItem.Text = "Edit Tables List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(385, 12)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(107, 23)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Delete Record"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(293, 12)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 2
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(202, 12)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 1
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.SystemColors.Window
        Me.txt_email.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.txt_email.Location = New System.Drawing.Point(436, 83)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.ReadOnly = True
        Me.txt_email.Size = New System.Drawing.Size(191, 22)
        Me.txt_email.TabIndex = 7
        '
        'txt_telephone
        '
        Me.txt_telephone.BackColor = System.Drawing.SystemColors.Window
        Me.txt_telephone.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.txt_telephone.Location = New System.Drawing.Point(436, 49)
        Me.txt_telephone.Name = "txt_telephone"
        Me.txt_telephone.ReadOnly = True
        Me.txt_telephone.Size = New System.Drawing.Size(191, 22)
        Me.txt_telephone.TabIndex = 6
        '
        'cb_gender
        '
        Me.cb_gender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mc1tableBindingSource, "Gender", True))
        Me.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_gender.Enabled = False
        Me.cb_gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_gender.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.cb_gender.FormattingEnabled = True
        Me.cb_gender.Items.AddRange(New Object() {"", "Male", "Female"})
        Me.cb_gender.Location = New System.Drawing.Point(111, 83)
        Me.cb_gender.Name = "cb_gender"
        Me.cb_gender.Size = New System.Drawing.Size(190, 23)
        Me.cb_gender.TabIndex = 2
        '
        'txt_city
        '
        Me.txt_city.BackColor = System.Drawing.SystemColors.Window
        Me.txt_city.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.txt_city.Location = New System.Drawing.Point(111, 151)
        Me.txt_city.Name = "txt_city"
        Me.txt_city.ReadOnly = True
        Me.txt_city.Size = New System.Drawing.Size(191, 22)
        Me.txt_city.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.ShowHelp = True
        Me.OpenFileDialog1.Title = "Browse"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 335)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(813, 228)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Lavender
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.FatherNameDataGridViewTextBoxColumn, Me.MobileDataGridViewTextBoxColumn, Me.TelephoneDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.BatchDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.SessDataGridViewTextBoxColumn, Me.PictureDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.Mc1tableBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(6, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(787, 194)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NameDataGridViewTextBoxColumn.Width = 150
        '
        'FatherNameDataGridViewTextBoxColumn
        '
        Me.FatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName"
        Me.FatherNameDataGridViewTextBoxColumn.HeaderText = "FatherName"
        Me.FatherNameDataGridViewTextBoxColumn.Name = "FatherNameDataGridViewTextBoxColumn"
        Me.FatherNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FatherNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FatherNameDataGridViewTextBoxColumn.Width = 150
        '
        'MobileDataGridViewTextBoxColumn
        '
        Me.MobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile"
        Me.MobileDataGridViewTextBoxColumn.HeaderText = "Mobile"
        Me.MobileDataGridViewTextBoxColumn.Name = "MobileDataGridViewTextBoxColumn"
        Me.MobileDataGridViewTextBoxColumn.ReadOnly = True
        Me.MobileDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MobileDataGridViewTextBoxColumn.Width = 120
        '
        'TelephoneDataGridViewTextBoxColumn
        '
        Me.TelephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.HeaderText = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.Name = "TelephoneDataGridViewTextBoxColumn"
        Me.TelephoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelephoneDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TelephoneDataGridViewTextBoxColumn.Width = 120
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmailDataGridViewTextBoxColumn.Width = 150
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        Me.DateOfBirthDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateOfBirthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'BatchDataGridViewTextBoxColumn
        '
        Me.BatchDataGridViewTextBoxColumn.DataPropertyName = "Batch"
        Me.BatchDataGridViewTextBoxColumn.HeaderText = "Batch"
        Me.BatchDataGridViewTextBoxColumn.Name = "BatchDataGridViewTextBoxColumn"
        Me.BatchDataGridViewTextBoxColumn.ReadOnly = True
        Me.BatchDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        Me.CityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CityDataGridViewTextBoxColumn.Width = 150
        '
        'SessDataGridViewTextBoxColumn
        '
        Me.SessDataGridViewTextBoxColumn.DataPropertyName = "Sess"
        Me.SessDataGridViewTextBoxColumn.HeaderText = "Session"
        Me.SessDataGridViewTextBoxColumn.Name = "SessDataGridViewTextBoxColumn"
        Me.SessDataGridViewTextBoxColumn.ReadOnly = True
        Me.SessDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SessDataGridViewTextBoxColumn.Width = 150
        '
        'PictureDataGridViewImageColumn
        '
        Me.PictureDataGridViewImageColumn.DataPropertyName = "Picture"
        Me.PictureDataGridViewImageColumn.HeaderText = "Picture"
        Me.PictureDataGridViewImageColumn.Name = "PictureDataGridViewImageColumn"
        Me.PictureDataGridViewImageColumn.Visible = False
        '
        'btn_changetable
        '
        Me.btn_changetable.Location = New System.Drawing.Point(510, 12)
        Me.btn_changetable.Name = "btn_changetable"
        Me.btn_changetable.Size = New System.Drawing.Size(117, 23)
        Me.btn_changetable.TabIndex = 4
        Me.btn_changetable.Text = "Change Table"
        Me.btn_changetable.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lbl_total_records)
        Me.GroupBox2.Controls.Add(Me.btn_changetable)
        Me.GroupBox2.Controls.Add(Me.btn_delete)
        Me.GroupBox2.Controls.Add(Me.btn_update)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Controls.Add(Me.btn_addnew)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(799, 45)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(686, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 16)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Records :"
        '
        'lbl_total_records
        '
        Me.lbl_total_records.AutoSize = True
        Me.lbl_total_records.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
        Me.lbl_total_records.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_total_records.Location = New System.Drawing.Point(752, 15)
        Me.lbl_total_records.Name = "lbl_total_records"
        Me.lbl_total_records.Size = New System.Drawing.Size(24, 16)
        Me.lbl_total_records.TabIndex = 23
        Me.lbl_total_records.Text = "00"
        '
        'txt_dob
        '
        Me.txt_dob.BackColor = System.Drawing.SystemColors.Window
        Me.txt_dob.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.txt_dob.Location = New System.Drawing.Point(111, 117)
        Me.txt_dob.Name = "txt_dob"
        Me.txt_dob.ReadOnly = True
        Me.txt_dob.Size = New System.Drawing.Size(191, 22)
        Me.txt_dob.TabIndex = 3
        '
        'txt_mobile
        '
        Me.txt_mobile.BackColor = System.Drawing.SystemColors.Window
        Me.txt_mobile.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.txt_mobile.Location = New System.Drawing.Point(110, 49)
        Me.txt_mobile.Name = "txt_mobile"
        Me.txt_mobile.ReadOnly = True
        Me.txt_mobile.Size = New System.Drawing.Size(191, 22)
        Me.txt_mobile.TabIndex = 1
        '
        'txt_fathername
        '
        Me.txt_fathername.BackColor = System.Drawing.SystemColors.Window
        Me.txt_fathername.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.txt_fathername.Location = New System.Drawing.Point(436, 15)
        Me.txt_fathername.Name = "txt_fathername"
        Me.txt_fathername.ReadOnly = True
        Me.txt_fathername.Size = New System.Drawing.Size(191, 22)
        Me.txt_fathername.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "City :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 17)
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
        Me.Label7.Location = New System.Drawing.Point(340, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Telephone :"
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.SystemColors.Window
        Me.txt_name.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(111, 15)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(191, 22)
        Me.txt_name.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = "Management"
        Me.GroupBox1.Controls.Add(Me.cb_session)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cb_batch)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btn_changepicture)
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(799, 205)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'cb_session
        '
        Me.cb_session.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mc1tableBindingSource, "Sess", True))
        Me.cb_session.DataSource = Me.ComboboxSessionBindingSource
        Me.cb_session.DisplayMember = "List"
        Me.cb_session.DropDownHeight = 107
        Me.cb_session.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_session.Enabled = False
        Me.cb_session.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_session.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.cb_session.FormattingEnabled = True
        Me.cb_session.IntegralHeight = False
        Me.cb_session.Location = New System.Drawing.Point(436, 117)
        Me.cb_session.Name = "cb_session"
        Me.cb_session.Size = New System.Drawing.Size(191, 23)
        Me.cb_session.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(340, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Session :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(636, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(340, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Email :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(340, 17)
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
        Me.Label6.Location = New System.Drawing.Point(14, 51)
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
        Me.Label3.Location = New System.Drawing.Point(14, 85)
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
        Me.Label4.Location = New System.Drawing.Point(14, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Date of birth :"
        '
        'Mc1_tableTableAdapter
        '
        Me.Mc1_tableTableAdapter.ClearBeforeFill = True
        '
        'Combo_box_SessionTableAdapter
        '
        Me.Combo_box_SessionTableAdapter.ClearBeforeFill = True
        '
        'Combobox_batchTableAdapter
        '
        Me.Combobox_batchTableAdapter.ClearBeforeFill = True
        '
        'Table3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(821, 563)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Table3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table 3 - Management"
        CType(Me.Mc1tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_aioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboboxbatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ComboboxSessionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_batch As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_addnew As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents checkbox_female As System.Windows.Forms.CheckBox
    Friend WithEvents checkbox_male As System.Windows.Forms.CheckBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_changepicture As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_telephone As System.Windows.Forms.TextBox
    Friend WithEvents cb_gender As System.Windows.Forms.ComboBox
    Friend WithEvents txt_city As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_changetable As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_dob As System.Windows.Forms.TextBox
    Friend WithEvents txt_mobile As System.Windows.Forms.TextBox
    Friend WithEvents txt_fathername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb_session As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SessionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data_aioDataSet As Management.data_aioDataSet
    Friend WithEvents Mc1tableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mc1_tableTableAdapter As Management.data_aioDataSetTableAdapters.mc1_tableTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FatherNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BatchDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SessDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ComboboxSessionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Combo_box_SessionTableAdapter As Management.data_aioDataSetTableAdapters.combo_box_SessionTableAdapter
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_total_records As System.Windows.Forms.Label
    Friend WithEvents ComboboxbatchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Combobox_batchTableAdapter As Management.data_aioDataSetTableAdapters.combobox_batchTableAdapter
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditTablesListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
