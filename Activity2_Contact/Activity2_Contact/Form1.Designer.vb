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
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim FeverLabel As System.Windows.Forms.Label
        Dim CoughLabel As System.Windows.Forms.Label
        Dim Loss_of_tasteLabel As System.Windows.Forms.Label
        Dim Sore_throatLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Me.ContactDataSet = New Activity2_Contact.contactDataSet()
        Me.TblContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblContactsTableAdapter = New Activity2_Contact.contactDataSetTableAdapters.tblContactsTableAdapter()
        Me.TableAdapterManager = New Activity2_Contact.contactDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.FeverTextBox = New System.Windows.Forms.TextBox()
        Me.CoughTextBox = New System.Windows.Forms.TextBox()
        Me.Loss_of_tasteTextBox = New System.Windows.Forms.TextBox()
        Me.Sore_throatTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.TblContactsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        FeverLabel = New System.Windows.Forms.Label()
        CoughLabel = New System.Windows.Forms.Label()
        Loss_of_tasteLabel = New System.Windows.Forms.Label()
        Sore_throatLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        CType(Me.ContactDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblContactsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContactDataSet
        '
        Me.ContactDataSet.DataSetName = "contactDataSet"
        Me.ContactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblContactsBindingSource
        '
        Me.TblContactsBindingSource.DataMember = "tblContacts"
        Me.TblContactsBindingSource.DataSource = Me.ContactDataSet
        '
        'TblContactsTableAdapter
        '
        Me.TblContactsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblContactsTableAdapter = Me.TblContactsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Activity2_Contact.contactDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(35, 48)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(136, 45)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(67, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(35, 80)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(90, 20)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "firstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(136, 77)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(246, 26)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(36, 115)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(94, 20)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "Last Name: "
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "lastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(137, 112)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(245, 26)
        Me.LastNameTextBox.TabIndex = 6
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(36, 151)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(101, 20)
        AddressLabel.TabIndex = 7
        AddressLabel.Text = "Full Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(136, 148)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(245, 69)
        Me.AddressTextBox.TabIndex = 8
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Location = New System.Drawing.Point(452, 61)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(129, 20)
        ContactNumberLabel.TabIndex = 9
        ContactNumberLabel.Text = "Contact Number:"
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "contactNumber", True))
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(584, 58)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(130, 26)
        Me.ContactNumberTextBox.TabIndex = 10
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(536, 107)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(42, 20)
        AgeLabel.TabIndex = 11
        AgeLabel.Text = "Age:"
        AddHandler AgeLabel.Click, AddressOf Me.AgeLabel_Click
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(584, 104)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 26)
        Me.AgeTextBox.TabIndex = 12
        '
        'FeverLabel
        '
        FeverLabel.AutoSize = True
        FeverLabel.Location = New System.Drawing.Point(44, 44)
        FeverLabel.Name = "FeverLabel"
        FeverLabel.Size = New System.Drawing.Size(53, 20)
        FeverLabel.TabIndex = 13
        FeverLabel.Text = "Fever:"
        '
        'FeverTextBox
        '
        Me.FeverTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "fever", True))
        Me.FeverTextBox.Location = New System.Drawing.Point(219, 38)
        Me.FeverTextBox.Name = "FeverTextBox"
        Me.FeverTextBox.Size = New System.Drawing.Size(100, 26)
        Me.FeverTextBox.TabIndex = 14
        '
        'CoughLabel
        '
        CoughLabel.AutoSize = True
        CoughLabel.Location = New System.Drawing.Point(44, 76)
        CoughLabel.Name = "CoughLabel"
        CoughLabel.Size = New System.Drawing.Size(60, 20)
        CoughLabel.TabIndex = 15
        CoughLabel.Text = "Cough:"
        '
        'CoughTextBox
        '
        Me.CoughTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "cough", True))
        Me.CoughTextBox.Location = New System.Drawing.Point(219, 70)
        Me.CoughTextBox.Name = "CoughTextBox"
        Me.CoughTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CoughTextBox.TabIndex = 16
        '
        'Loss_of_tasteLabel
        '
        Loss_of_tasteLabel.AutoSize = True
        Loss_of_tasteLabel.Location = New System.Drawing.Point(44, 108)
        Loss_of_tasteLabel.Name = "Loss_of_tasteLabel"
        Loss_of_tasteLabel.Size = New System.Drawing.Size(163, 20)
        Loss_of_tasteLabel.TabIndex = 17
        Loss_of_tasteLabel.Text = "Loss of taste or smell:"
        '
        'Loss_of_tasteTextBox
        '
        Me.Loss_of_tasteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "loss_of_taste", True))
        Me.Loss_of_tasteTextBox.Location = New System.Drawing.Point(219, 102)
        Me.Loss_of_tasteTextBox.Name = "Loss_of_tasteTextBox"
        Me.Loss_of_tasteTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Loss_of_tasteTextBox.TabIndex = 18
        '
        'Sore_throatLabel
        '
        Sore_throatLabel.AutoSize = True
        Sore_throatLabel.Location = New System.Drawing.Point(44, 140)
        Sore_throatLabel.Name = "Sore_throatLabel"
        Sore_throatLabel.Size = New System.Drawing.Size(93, 20)
        Sore_throatLabel.TabIndex = 19
        Sore_throatLabel.Text = "Sore throat:"
        '
        'Sore_throatTextBox
        '
        Me.Sore_throatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "sore_throat", True))
        Me.Sore_throatTextBox.Location = New System.Drawing.Point(219, 134)
        Me.Sore_throatTextBox.Name = "Sore_throatTextBox"
        Me.Sore_throatTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Sore_throatTextBox.TabIndex = 20
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Location = New System.Drawing.Point(6, 177)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(714, 20)
        ContactLabel.TabIndex = 21
        ContactLabel.Text = "Did you have contact with an asymptomatic or COVID-19 positive person for the pas" &
    "t two (2) weeks?"
        '
        'ContactTextBox
        '
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "contact", True))
        Me.ContactTextBox.Location = New System.Drawing.Point(219, 210)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ContactTextBox.TabIndex = 22
        '
        'TblContactsDataGridView
        '
        Me.TblContactsDataGridView.AutoGenerateColumns = False
        Me.TblContactsDataGridView.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.TblContactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblContactsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.TblContactsDataGridView.DataSource = Me.TblContactsBindingSource
        Me.TblContactsDataGridView.Location = New System.Drawing.Point(33, 726)
        Me.TblContactsDataGridView.Name = "TblContactsDataGridView"
        Me.TblContactsDataGridView.Size = New System.Drawing.Size(770, 220)
        Me.TblContactsDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "firstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "firstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "lastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "lastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn4.HeaderText = "address"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "contactNumber"
        Me.DataGridViewTextBoxColumn5.HeaderText = "contactNumber"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "age"
        Me.DataGridViewTextBoxColumn6.HeaderText = "age"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fever"
        Me.DataGridViewTextBoxColumn7.HeaderText = "fever"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cough"
        Me.DataGridViewTextBoxColumn8.HeaderText = "cough"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "loss_of_taste"
        Me.DataGridViewTextBoxColumn9.HeaderText = "loss_of_taste"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "sore_throat"
        Me.DataGridViewTextBoxColumn10.HeaderText = "sore_throat"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "contact"
        Me.DataGridViewTextBoxColumn11.HeaderText = "contact"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(AgeLabel)
        Me.GroupBox1.Controls.Add(ContactNumberLabel)
        Me.GroupBox1.Controls.Add(Me.AgeTextBox)
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(Me.ContactNumberTextBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(34, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 293)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.FeverTextBox)
        Me.GroupBox2.Controls.Add(Me.ContactTextBox)
        Me.GroupBox2.Controls.Add(ContactLabel)
        Me.GroupBox2.Controls.Add(FeverLabel)
        Me.GroupBox2.Controls.Add(Me.Sore_throatTextBox)
        Me.GroupBox2.Controls.Add(Sore_throatLabel)
        Me.GroupBox2.Controls.Add(CoughLabel)
        Me.GroupBox2.Controls.Add(Me.Loss_of_tasteTextBox)
        Me.GroupBox2.Controls.Add(Me.CoughTextBox)
        Me.GroupBox2.Controls.Add(Loss_of_tasteLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(34, 352)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(770, 326)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Have you experienced any of the following COVID-19 Symptoms for the past two (2) " &
    "weeks?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 681)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 31)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "RECORDS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(328, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 31)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "RECORDS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 24)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Contact Tracing Application"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(527, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 46)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(641, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 46)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Submit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(832, 951)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TblContactsDataGridView)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.ContactDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblContactsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContactDataSet As contactDataSet
    Friend WithEvents TblContactsBindingSource As BindingSource
    Friend WithEvents TblContactsTableAdapter As contactDataSetTableAdapters.tblContactsTableAdapter
    Friend WithEvents TableAdapterManager As contactDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents ContactNumberTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents FeverTextBox As TextBox
    Friend WithEvents CoughTextBox As TextBox
    Friend WithEvents Loss_of_tasteTextBox As TextBox
    Friend WithEvents Sore_throatTextBox As TextBox
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents TblContactsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
