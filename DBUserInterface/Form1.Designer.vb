<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CustNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveCustomer = New System.Windows.Forms.Button()
        Me.DispCustName = New System.Windows.Forms.TextBox()
        Me.DispCustID = New System.Windows.Forms.TextBox()
        Me.CountCustomerButton = New System.Windows.Forms.Button()
        Me.ReadButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CustNameTextBox
        '
        Me.CustNameTextBox.Location = New System.Drawing.Point(195, 44)
        Me.CustNameTextBox.Name = "CustNameTextBox"
        Me.CustNameTextBox.Size = New System.Drawing.Size(201, 20)
        Me.CustNameTextBox.TabIndex = 2
        '
        'CustIDTextBox
        '
        Me.CustIDTextBox.Location = New System.Drawing.Point(195, 103)
        Me.CustIDTextBox.Name = "CustIDTextBox"
        Me.CustIDTextBox.Size = New System.Drawing.Size(201, 20)
        Me.CustIDTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Customer ID"
        '
        'SaveCustomer
        '
        Me.SaveCustomer.Location = New System.Drawing.Point(471, 57)
        Me.SaveCustomer.Name = "SaveCustomer"
        Me.SaveCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SaveCustomer.Size = New System.Drawing.Size(168, 52)
        Me.SaveCustomer.TabIndex = 6
        Me.SaveCustomer.Text = "Save Customer"
        Me.SaveCustomer.UseVisualStyleBackColor = True
        '
        'DispCustName
        '
        Me.DispCustName.Location = New System.Drawing.Point(145, 270)
        Me.DispCustName.Name = "DispCustName"
        Me.DispCustName.Size = New System.Drawing.Size(100, 20)
        Me.DispCustName.TabIndex = 7
        '
        'DispCustID
        '
        Me.DispCustID.Location = New System.Drawing.Point(145, 314)
        Me.DispCustID.Name = "DispCustID"
        Me.DispCustID.Size = New System.Drawing.Size(100, 20)
        Me.DispCustID.TabIndex = 8
        '
        'CountCustomerButton
        '
        Me.CountCustomerButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.CountCustomerButton.Location = New System.Drawing.Point(367, 276)
        Me.CountCustomerButton.Name = "CountCustomerButton"
        Me.CountCustomerButton.Size = New System.Drawing.Size(75, 23)
        Me.CountCustomerButton.TabIndex = 9
        Me.CountCustomerButton.Text = "Find Customer"
        Me.CountCustomerButton.UseVisualStyleBackColor = True
        '
        'ReadButton
        '
        Me.ReadButton.Location = New System.Drawing.Point(538, 274)
        Me.ReadButton.Name = "ReadButton"
        Me.ReadButton.Size = New System.Drawing.Size(75, 23)
        Me.ReadButton.TabIndex = 10
        Me.ReadButton.Text = "Read"
        Me.ReadButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 523)
        Me.Controls.Add(Me.ReadButton)
        Me.Controls.Add(Me.CountCustomerButton)
        Me.Controls.Add(Me.DispCustID)
        Me.Controls.Add(Me.DispCustName)
        Me.Controls.Add(Me.SaveCustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CustIDTextBox)
        Me.Controls.Add(Me.CustNameTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustNameTextBox As TextBox
    Friend WithEvents CustIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveCustomer As Button
    Friend WithEvents DispCustName As TextBox
    Friend WithEvents DispCustID As TextBox
    Friend WithEvents CountCustomerButton As Button
    Friend WithEvents ReadButton As Button
End Class
