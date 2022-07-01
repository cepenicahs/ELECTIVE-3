Imports QRCoder
Public Class frmGenerate
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(txtInput.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        PictureBox1.Image = code.GetGraphic(6)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtInput.Text = "Name: " + txtFirstName.Text + " " + txtLastName.Text & vbNewLine &
            "Full Address: " + txtAddress.Text & vbNewLine &
            "Contact Number: " + txtContactNumber.Text & vbNewLine &
            "Age: " + txtAge.Text & vbNewLine &
            "Fever: " + txtFever.Text & vbNewLine &
            "Cough: " + txtCough.Text & vbNewLine &
            "Loss of taste or smell: " + txtLoss.Text & vbNewLine &
            "Sore throat: " + txtSore.Text & vbNewLine &
             "Close contact: " + txtContact.Text



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub lblInput_Click(sender As Object, e As EventArgs)

    End Sub
End Class