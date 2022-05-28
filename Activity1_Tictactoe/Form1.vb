Public Class frmTicTacToe
    Dim flag = 0
    Private randNum As Integer = 1
    Private buttonID As Integer = 0
    Private Sub frmTicTacToe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Startgame()
        Reset()

        buttonID = 1
        Timer1.Start()
    End Sub

    Private Sub Reset()
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
