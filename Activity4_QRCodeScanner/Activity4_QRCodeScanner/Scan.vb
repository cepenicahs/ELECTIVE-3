Imports WebCam_Capture
Imports MessagingToolkit.QRCode.Codec
Public Class frmScan
    WithEvents myWebcam As WebCamCapture
    Dim reader As QRCodeDecoder

    Private Sub StartWebCam()
        Try
            StopWebCam()
            myWebcam = New WebCamCapture
            myWebcam.Start(0)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub StopWebCam()
        Try


        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click

        Form1.Show()
    End Sub


    Private Sub myWebcam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles myWebcam.ImageCaptured
        PictureBox1.Image = e.WebCamImage
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartWebCam()
        txtInput.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StopWebCam()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            StopWebCam()
            reader = New QRCodeDecoder
            txtInput.Text = reader.Decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MsgBox("QR Code is detected!")
        Catch ex As Exception

        End Try
    End Sub
End Class