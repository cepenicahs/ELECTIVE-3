Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmGenerate.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmScan.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
