Public Class frmTicTacToe
    Dim flag = 0
    Dim turn = True
    Dim count = 0

    Private Sub frmTicTacToe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initial()
    End Sub

    Private Sub Initial()
        btn11.Enabled = False
        btn12.Enabled = False
        btn13.Enabled = False
        btn21.Enabled = False
        btn22.Enabled = False
        btn23.Enabled = False
        btn31.Enabled = False
        btn32.Enabled = False
        btn33.Enabled = False
        btn11.Text = ""
        btn12.Text = ""
        btn13.Text = ""
        btn21.Text = ""
        btn22.Text = ""
        btn23.Text = ""
        btn31.Text = ""
        btn32.Text = ""
        btn33.Text = ""
    End Sub
    Private Sub Reset()
        btn11.BackColor = Color.LavenderBlush
        btn12.BackColor = Color.LavenderBlush
        btn13.BackColor = Color.LavenderBlush
        btn21.BackColor = Color.LavenderBlush
        btn22.BackColor = Color.LavenderBlush
        btn23.BackColor = Color.LavenderBlush
        btn31.BackColor = Color.LavenderBlush
        btn32.BackColor = Color.LavenderBlush
        btn33.BackColor = Color.LavenderBlush

        btn11.Enabled = True
        btn12.Enabled = True
        btn13.Enabled = True
        btn21.Enabled = True
        btn22.Enabled = True
        btn23.Enabled = True
        btn31.Enabled = True
        btn32.Enabled = True
        btn33.Enabled = True
        btn11.Text = ""
        btn12.Text = ""
        btn13.Text = ""
        btn21.Text = ""
        btn22.Text = ""
        btn23.Text = ""
        btn31.Text = ""
        btn32.Text = ""
        btn33.Text = ""

        turn = True
        count = 0

    End Sub

    Private Sub Checker()
        'HORIZONTAL
        Dim winner As Boolean
        winner = False

        If ((btn11.Text = btn12.Text) And (btn12.Text = btn13.Text) And (btn11.Enabled = False)) Then
            winner = True
        End If
        If ((btn21.Text = btn22.Text) And (btn22.Text = btn23.Text) And (btn21.Enabled = False)) Then
            winner = True
        End If
        If ((btn31.Text = btn32.Text) And (btn32.Text = btn33.Text) And (btn31.Enabled = False)) Then
            winner = True
        End If

        'VERTICAL
        If ((btn11.Text = btn21.Text) And (btn21.Text = btn31.Text) And (btn31.Enabled = False)) Then
            winner = True
        End If

        If ((btn12.Text = btn22.Text) And (btn22.Text = btn32.Text) And (btn32.Enabled = False)) Then
                winner = True
            End If
        If ((btn13.Text = btn23.Text) And (btn32.Text = btn33.Text) And (btn33.Enabled = False)) Then
            winner = True
        End If

        'DIAGONAL
        If ((btn11.Text = btn22.Text) And (btn22.Text = btn33.Text) And (btn33.Enabled = False)) Then
            winner = True
        End If
        If ((btn13.Text = btn22.Text) And (btn22.Text = btn31.Text) And (btn31.Enabled = False)) Then
            winner = True
        End If

        If (winner) Then
            Dim player As String
            player = ""

            If (turn) Then
                player = "O"
            Else
                player = "X"
                MessageBox.Show("Congratulations Player " + player + "! You won the game!")
            End If
        Else
            If (count = 9) Then
                MessageBox.Show("It's a draw!", "Result")
            End If
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If flag = 0 = True Then
            flag = 1
            btnPlay.Text = "RESET"
            Reset()
        ElseIf flag = 1 = True Then
            flag = 0
            btnPlay.Text = "PLAY"
            Reset()
        End If

    End Sub

    Private Sub button_click(sender As Object, e As EventArgs) Handles btn33.Click, btn32.Click, btn31.Click, btn23.Click, btn22.Click, btn21.Click, btn13.Click, btn12.Click, btn11.Click
        Dim b As Button = CType(sender, Button)
        If (turn = True) Then
            b.Text = "X"
        Else
            b.Text = "O"
        End If

        turn = Not (turn)
        count += 1
        b.BackColor = Color.Khaki
        b.Enabled = False
        Checker()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
