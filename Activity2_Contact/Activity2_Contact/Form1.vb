Imports System.Data.OleDb
Public Class Form1

    Private Sub TblContactsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblContactsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ContactDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ContactDataSet.tblContacts' table. You can move, or remove it, as needed.
        Me.TblContactsTableAdapter.Fill(Me.ContactDataSet.tblContacts)

    End Sub

    Private Sub AgeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TblContactsBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            TblContactsBindingSource.EndEdit()
            TblContactsTableAdapter.Update(ContactDataSet.tblContacts)
            MessageBox.Show("Recorded!")
        Catch ex As Exception
            MessageBox.Show("Failed to save!")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TblContactsBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TblContactsBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TblContactsBindingSource.RemoveCurrent()
    End Sub
End Class
