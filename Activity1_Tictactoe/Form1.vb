Public Class frmTicTacToe
    Dim flag = 0
    Private Sub frmTicTacToe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If flag = 0 = True Then
            flag = 1
            btnPlay.Text = "Reset"
        ElseIf flag = 1 = True Then
            flag = 0
            btnPlay.Text = "Start"
        End If

    End Sub
End Class
