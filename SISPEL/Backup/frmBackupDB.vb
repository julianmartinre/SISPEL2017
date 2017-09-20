Imports RodriguezEscobedo.Framework.Backup

Public Class frmBackupDB

    Dim gestorBup As New GestorBackup
    Dim direccion As String

    'Test

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        gestorBup.CrearBackup(txtNombreBackup.Text)

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click

        If System.IO.Directory.Exists("D:\") Then
            OpenFileDialog1.InitialDirectory = "D:\"
        End If

        OpenFileDialog1.ShowDialog()

        direccion = OpenFileDialog1.FileName
        txtDireccionBackup.Text = direccion

    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click

        gestorBup.RestaurarBD(direccion)

    End Sub

End Class