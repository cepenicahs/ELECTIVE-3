<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerate
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
        Dim AgeLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim FeverLabel As System.Windows.Forms.Label
        Dim Sore_throatLabel As System.Windows.Forms.Label
        Dim CoughLabel As System.Windows.Forms.Label
        Dim Loss_of_tasteLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFever = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtSore = New System.Windows.Forms.TextBox()
        Me.txtLoss = New System.Windows.Forms.TextBox()
        Me.txtCough = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        AgeLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        FeverLabel = New System.Windows.Forms.Label()
        Sore_throatLabel = New System.Windows.Forms.Label()
        CoughLabel = New System.Windows.Forms.Label()
        Loss_of_tasteLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(52, 162)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(42, 20)
        AgeLabel.TabIndex = 11
        AgeLabel.Text = "Age:"
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Location = New System.Drawing.Point(49, 127)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(127, 20)
        ContactNumberLabel.TabIndex = 9
        ContactNumberLabel.Text = "Contact number:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(52, 191)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(72, 20)
        AddressLabel.TabIndex = 7
        AddressLabel.Text = "Address:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(48, 57)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(90, 20)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(49, 92)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(94, 20)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "Last Name: "
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Location = New System.Drawing.Point(6, 227)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(519, 40)
        ContactLabel.TabIndex = 21
        ContactLabel.Text = "Did you have contact with an asymptomatic or COVID-19 positive person" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for the pa" &
    "st two (2) weeks?"
        '
        'FeverLabel
        '
        FeverLabel.AutoSize = True
        FeverLabel.Location = New System.Drawing.Point(48, 68)
        FeverLabel.Name = "FeverLabel"
        FeverLabel.Size = New System.Drawing.Size(53, 20)
        FeverLabel.TabIndex = 13
        FeverLabel.Text = "Fever:"
        '
        'Sore_throatLabel
        '
        Sore_throatLabel.AutoSize = True
        Sore_throatLabel.Location = New System.Drawing.Point(48, 164)
        Sore_throatLabel.Name = "Sore_throatLabel"
        Sore_throatLabel.Size = New System.Drawing.Size(93, 20)
        Sore_throatLabel.TabIndex = 19
        Sore_throatLabel.Text = "Sore throat:"
        '
        'CoughLabel
        '
        CoughLabel.AutoSize = True
        CoughLabel.Location = New System.Drawing.Point(48, 100)
        CoughLabel.Name = "CoughLabel"
        CoughLabel.Size = New System.Drawing.Size(60, 20)
        CoughLabel.TabIndex = 15
        CoughLabel.Text = "Cough:"
        '
        'Loss_of_tasteLabel
        '
        Loss_of_tasteLabel.AutoSize = True
        Loss_of_tasteLabel.Location = New System.Drawing.Point(48, 132)
        Loss_of_tasteLabel.Name = "Loss_of_tasteLabel"
        Loss_of_tasteLabel.Size = New System.Drawing.Size(163, 20)
        Loss_of_tasteLabel.TabIndex = 17
        Loss_of_tasteLabel.Text = "Loss of taste or smell:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(152, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(461, 436)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(390, 652)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(160, 47)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(AgeLabel)
        Me.GroupBox1.Controls.Add(ContactNumberLabel)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.txtContactNumber)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 306)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter your personal information:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(182, 188)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(245, 69)
        Me.txtAddress.TabIndex = 4
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(182, 156)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(130, 26)
        Me.txtAge.TabIndex = 3
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(182, 124)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(130, 26)
        Me.txtContactNumber.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(182, 89)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(245, 26)
        Me.txtLastName.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(181, 54)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(246, 26)
        Me.txtFirstName.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox2.Controls.Add(Me.txtFever)
        Me.GroupBox2.Controls.Add(Me.txtContact)
        Me.GroupBox2.Controls.Add(ContactLabel)
        Me.GroupBox2.Controls.Add(FeverLabel)
        Me.GroupBox2.Controls.Add(Me.txtSore)
        Me.GroupBox2.Controls.Add(Sore_throatLabel)
        Me.GroupBox2.Controls.Add(CoughLabel)
        Me.GroupBox2.Controls.Add(Me.txtLoss)
        Me.GroupBox2.Controls.Add(Me.txtCough)
        Me.GroupBox2.Controls.Add(Loss_of_tasteLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 404)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(527, 406)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Have you experienced any of the following COVID-19 Symptoms for the past two (2) " &
    "weeks?"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(235, 652)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 47)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "UPLOAD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtFever
        '
        Me.txtFever.Location = New System.Drawing.Point(223, 62)
        Me.txtFever.Name = "txtFever"
        Me.txtFever.Size = New System.Drawing.Size(100, 26)
        Me.txtFever.TabIndex = 0
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(219, 260)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(100, 26)
        Me.txtContact.TabIndex = 4
        '
        'txtSore
        '
        Me.txtSore.Location = New System.Drawing.Point(223, 158)
        Me.txtSore.Name = "txtSore"
        Me.txtSore.Size = New System.Drawing.Size(100, 26)
        Me.txtSore.TabIndex = 3
        '
        'txtLoss
        '
        Me.txtLoss.Location = New System.Drawing.Point(223, 126)
        Me.txtLoss.Name = "txtLoss"
        Me.txtLoss.Size = New System.Drawing.Size(100, 26)
        Me.txtLoss.TabIndex = 2
        '
        'txtCough
        '
        Me.txtCough.Location = New System.Drawing.Point(223, 94)
        Me.txtCough.Name = "txtCough"
        Me.txtCough.Size = New System.Drawing.Size(100, 26)
        Me.txtCough.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(361, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 59)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "ITRACE"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btnGenerate)
        Me.GroupBox3.Controls.Add(Me.txtInput)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(545, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(726, 718)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "QR Code:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(93, 491)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(581, 146)
        Me.txtInput.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(503, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 42)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "QR Code Generator"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightCyan
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.BackToolStripMenuItem.Text = "back"
        '
        'frmGenerate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1284, 829)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGenerate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtFever As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtSore As TextBox
    Friend WithEvents txtLoss As TextBox
    Friend WithEvents txtCough As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtInput As TextBox
End Class
