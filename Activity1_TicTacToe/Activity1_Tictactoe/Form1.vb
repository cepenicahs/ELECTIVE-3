Public Class frmTicTacToe
    Dim flag = 0
    Dim player As Boolean = True
    Dim turn As Integer = 0

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

        turn = 0
        btnPlay.Enabled = True

    End Sub

    Private Sub Checker()
        Dim Winner As Boolean = False

        'horizontal
        If btn11.Text = btn21.Text And btn21.Text = btn31.Text And Not btn11.Enabled Then
            Winner = True

        ElseIf btn12.Text = btn22.Text And btn22.Text = btn32.Text And Not btn12.Enabled Then
            Winner = True

        ElseIf btn13.Text = btn23.Text And btn23.Text = btn33.Text And Not btn13.Enabled Then
            Winner = True

            'vertical
        ElseIf btn11.Text = btn22.Text And btn22.Text = btn33.Text And Not btn11.Enabled Then
            Winner = True

        ElseIf btn13.Text = btn22.Text And btn22.Text = btn31.Text And Not btn13.Enabled Then
            Winner = True

        ElseIf btn11.Text = btn12.Text And btn12.Text = btn13.Text And Not btn11.Enabled Then
            Winner = True

            'diagonal
        ElseIf btn21.Text = btn22.Text And btn22.Text = btn23.Text And Not btn21.Enabled Then
            Winner = True

        ElseIf btn31.Text = btn32.Text And btn31.Text = btn33.Text And Not btn31.Enabled Then
            Winner = True

        End If

        If Winner Then
            forButton()
            Dim wins As String = ""

            If player Then
                wins = "Player 0"
            Else
                wins = "Player X"
            End If

            MessageBox.Show(wins + ", you win! Congratulations!")
            Reset()
        Else
            If turn = 9 Then
                MessageBox.Show("Game is Draw!")
            End If

        End If

    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If flag = 0 Then
            flag = 1
            btnPlay.Text = "RESET"
            Reset()
        ElseIf flag = 1 Then
            flag = 0
            btnPlay.Text = "PLAY"
            Reset()
        End If

    End Sub

    Private Sub forButton()
        Dim ctrl As Control
        Try
            For Each ctrl In Controls
                Dim x As Button = ctrl
                x.Enabled = False
            Next
        Catch ex As Exception

        End Try

    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click, btn32.Click, btn31.Click, btn23.Click, btn22.Click, btn21.Click, btn13.Click, btn12.Click, btn11.Click
        Dim b As Button = sender
        If player Then
            b.Text = "X"
        Else
            b.Text = "O"
        End If

        player = Not player
        b.BackColor = Color.Khaki
        b.Enabled = False
        turn += 1
        Checker()
    End Sub
End Class
