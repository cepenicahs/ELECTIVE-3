<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTicTacToe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicTacToe))
        Me.btn11 = New System.Windows.Forms.Button()
        Me.btn12 = New System.Windows.Forms.Button()
        Me.btn13 = New System.Windows.Forms.Button()
        Me.btn21 = New System.Windows.Forms.Button()
        Me.btn22 = New System.Windows.Forms.Button()
        Me.btn23 = New System.Windows.Forms.Button()
        Me.btn31 = New System.Windows.Forms.Button()
        Me.btn32 = New System.Windows.Forms.Button()
        Me.btn33 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn11
        '
        Me.btn11.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn11.Font = New System.Drawing.Font("Cooper Black", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn11.ForeColor = System.Drawing.Color.Black
        Me.btn11.Location = New System.Drawing.Point(92, 153)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(112, 99)
        Me.btn11.TabIndex = 0
        Me.btn11.UseVisualStyleBackColor = False
        '
        'btn12
        '
        Me.btn12.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn12.Font = New System.Drawing.Font("Cooper Black", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn12.ForeColor = System.Drawing.Color.Black
        Me.btn12.Location = New System.Drawing.Point(210, 153)
        Me.btn12.Name = "btn12"
        Me.btn12.Size = New System.Drawing.Size(112, 99)
        Me.btn12.TabIndex = 1
        Me.btn12.UseVisualStyleBackColor = False
        '
        'btn13
        '
        Me.btn13.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn13.Font = New System.Drawing.Font("Cooper Black", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn13.ForeColor = System.Drawing.Color.Black
        Me.btn13.Location = New System.Drawing.Point(328, 153)
        Me.btn13.Name = "btn13"
        Me.btn13.Size = New System.Drawing.Size(112, 99)
        Me.btn13.TabIndex = 2
        Me.btn13.UseVisualStyleBackColor = False
        '
        'btn21
        '
        Me.btn21.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn21.Font = New System.Drawing.Font("Cooper Black", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn21.ForeColor = System.Drawing.Color.Black
        Me.btn21.Location = New System.Drawing.Point(92, 258)
        Me.btn21.Name = "btn21"
        Me.btn21.Size = New System.Drawing.Size(112, 99)
        Me.btn21.TabIndex = 3
        Me.btn21.UseVisualStyleBackColor = False
        '
        'btn22
        '
        Me.btn22.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn22.Font = New System.Drawing.Font("Cooper Black", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn22.ForeColor = System.Drawing.Color.Black
        Me.btn22.Location = New System.Drawing.Point(210, 258)
        Me.btn22.Name = "btn22"
        Me.btn22.Size = New System.Drawing.Size(112, 99)
        Me.btn22.TabIndex = 4
        Me.btn22.UseVisualStyleBackColor = False
        '
        'btn23
        '
        Me.btn23.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn23.Font = New System.Drawing.Font("Cooper Black", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn23.ForeColor = System.Drawing.Color.Black
        Me.btn23.Location = New System.Drawing.Point(328, 258)
        Me.btn23.Name = "btn23"
        Me.btn23.Size = New System.Drawing.Size(112, 99)
        Me.btn23.TabIndex = 5
        Me.btn23.UseVisualStyleBackColor = False
        '
        'btn31
        '
        Me.btn31.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn31.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn31.Font = New System.Drawing.Font("Cooper Black", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn31.ForeColor = System.Drawing.Color.Black
        Me.btn31.Location = New System.Drawing.Point(92, 363)
        Me.btn31.Name = "btn31"
        Me.btn31.Size = New System.Drawing.Size(112, 99)
        Me.btn31.TabIndex = 6
        Me.btn31.UseVisualStyleBackColor = False
        '
        'btn32
        '
        Me.btn32.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn32.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn32.Font = New System.Drawing.Font("Cooper Black", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn32.ForeColor = System.Drawing.Color.Black
        Me.btn32.Location = New System.Drawing.Point(210, 363)
        Me.btn32.Name = "btn32"
        Me.btn32.Size = New System.Drawing.Size(112, 99)
        Me.btn32.TabIndex = 7
        Me.btn32.UseVisualStyleBackColor = False
        '
        'btn33
        '
        Me.btn33.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn33.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn33.Font = New System.Drawing.Font("Cooper Black", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn33.ForeColor = System.Drawing.Color.Black
        Me.btn33.Location = New System.Drawing.Point(328, 363)
        Me.btn33.Name = "btn33"
        Me.btn33.Size = New System.Drawing.Size(112, 99)
        Me.btn33.TabIndex = 8
        Me.btn33.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(82, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 61)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "TICTACTOE"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Crimson
        Me.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.Location = New System.Drawing.Point(195, 500)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(140, 59)
        Me.btnPlay.TabIndex = 10
        Me.btnPlay.Text = "PLAY"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-13, -10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(550, 681)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Thistle
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(537, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmTicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 651)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn33)
        Me.Controls.Add(Me.btn32)
        Me.Controls.Add(Me.btn31)
        Me.Controls.Add(Me.btn23)
        Me.Controls.Add(Me.btn22)
        Me.Controls.Add(Me.btn21)
        Me.Controls.Add(Me.btn13)
        Me.Controls.Add(Me.btn12)
        Me.Controls.Add(Me.btn11)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTicTacToe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TICTACTOE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn11 As Button
    Friend WithEvents btn12 As Button
    Friend WithEvents btn13 As Button
    Friend WithEvents btn21 As Button
    Friend WithEvents btn22 As Button
    Friend WithEvents btn23 As Button
    Friend WithEvents btn31 As Button
    Friend WithEvents btn32 As Button
    Friend WithEvents btn33 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
