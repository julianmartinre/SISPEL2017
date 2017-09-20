Imports SISPEL.DAL.Conexion
Imports System.IO

Namespace Backup

    Public Class GestorBackup

        Public Sub CrearBackup(bupNombre As String)
            If (Not Directory.Exists("D:\SispelBACKUP")) Then
                Directory.CreateDirectory("D:\SispelBACKUP")
            End If

            'concatenar bupNombre.
            Dim mCommand As String = "backup database [SISPELDB2017] to disk = 'D:\SispelBACKUP\SispelBACKUP.bak' with noFormat, noInit, name = 'Backup_SISPELDB2017', skip, noRewind, noUnload, stats = 10;"

            Try
                BD.ExecuteNonQuery(mCommand)
            Catch ex As Exception
                MsgBox("Error - Crear Backup")
                MsgBox(ex.Message)
            End Try
        End Sub


        ''' <summary>
        ''' Restaura la BD usando un archivo .bak
        ''' </summary>
        ''' <param name="pDireccion">Direccion en la que esta el archivo .bak necesario para la restauracion</param>
        Public Sub RestaurarBD(pDireccion As String)
            Dim mDataSources As DataTable = Sql.SqlDataSourceEnumerator.Instance.GetDataSources

            Dim mConnection As String = "Data Source=" & mDataSources.Rows(0).Item(0) & "\" & mDataSources.Rows(0).Item(1) & ";Initial Catalog=master;Integrated Security=true"
            Dim mCommand As String = "restore database [SISPELDB2017] from disk = '" & pDireccion & "';"

            Try
                BD.ExecuteNonQuery(mCommand, mConnection)
            Catch ex As Exception
                MsgBox("Error - Restaurar BD")
                MsgBox(ex.Message)
            End Try
        End Sub

    End Class

End Namespace