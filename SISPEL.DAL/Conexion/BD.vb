Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager

Namespace Conexion

    Public Class BD
        Private Shared mConnection As SqlConnection


        ''' <summary>
        ''' Ejecuta una Query en la BD y devuelve un objeto DataSet con los datos obtenidos
        ''' </summary>
        ''' <param name="pCommand">Comando SQL a ejecutar</param>
        ''' <returns></returns>
        Public Shared Function ExecuteDataSet(pCommand As String) As DataSet
            Try
                mConnection = New SqlConnection(ConnectionStrings("BDConnection").ConnectionString)
                Dim mDataSet As New DataSet
                Dim mDataAdapter As New SqlDataAdapter(pCommand, mConnection)

                mConnection.Open()
                mDataAdapter.Fill(mDataSet)

                Return mDataSet
            Catch ex As Exception
                MsgBox("Error en DataSet - BD")
                MsgBox(ex.Message)
                Return Nothing
            Finally
                mConnection.Close()
                mConnection.Dispose()
            End Try
        End Function


        ''' <summary>
        ''' Ejecuta un cambio en la BD y devuelve el numero de filas afectadas
        ''' </summary>
        ''' <param name="pCommand">Comando SQL a ejecutar</param>
        ''' <returns>Numero de filas afectadas</returns>
        Public Shared Function ExecuteNonQuery(pCommand As String) As Integer
            Try
                mConnection = New SqlConnection(ConnectionStrings("BDConnection").ConnectionString)
                Dim mCommand As New SqlCommand(pCommand, mConnection)

                mConnection.Open()
                Return mCommand.ExecuteNonQuery
            Catch ex As Exception
                MsgBox("Error - NonQuery - BD")
                MsgBox(ex.Message)
                Return Nothing
            Finally
                mConnection.Close()
                mConnection.Dispose()
            End Try
        End Function


        ''' <summary>
        ''' Ejecuta un cambio en la BD y devuelve el numero de filas afectadas
        ''' </summary>
        ''' <param name="pCommand">Comando SQL a ejecutar</param>
        ''' <param name="pConnection">String de conexion en el que ejecutar el comando</param>
        ''' <returns></returns>
        Public Shared Function ExecuteNonQuery(pCommand As String, pConnection As String) As Integer
            Try
                mConnection = New SqlConnection(pConnection)
                Dim mCommand As New SqlCommand(pCommand, mConnection)

                mConnection.Open()
                Return mCommand.ExecuteNonQuery
            Catch ex As Exception
                MsgBox("Error - NonQuery - BD")
                MsgBox(ex.Message)
                Return Nothing
            Finally
                mConnection.Close()
                mConnection.Dispose()
            End Try
        End Function


        '??
        Public Shared Function ExecuteReader(pCommandStr As String) As SqlDataReader
            Dim mReader As SqlDataReader = Nothing

            Try
                mConnection = New SqlConnection(ConnectionStrings("BDConnection").ConnectionString)
                Dim mCommand As New SqlCommand(pCommandStr, mConnection)

                mConnection.Open()
                mReader = mCommand.ExecuteReader

                Return mReader
            Catch ex As Exception
                MsgBox("Error - Reader - BD")
                MsgBox(ex.Message)
                Return Nothing
            Finally
                mReader.Close()
                mConnection.Close()
                mConnection.Dispose()
            End Try
        End Function


        ''' <summary>
        ''' Ejecuta una query en la BD y devuelve solo el primer resultado
        ''' </summary>
        ''' <remarks>Solo sirve para queries que devuelvan resultados numericos</remarks>
        ''' <param name="pCommandStr">Comando SQL a ejecutar</param>
        ''' <returns></returns>
        Public Shared Function ExecuteScalar(pCommandStr As String) As Integer
            Try
                mConnection = New SqlConnection(ConnectionStrings("BDConnection").ConnectionString)
                Dim mCommand As New SqlCommand(pCommandStr, mConnection)

                mConnection.Open()
                Return mCommand.ExecuteScalar
            Catch ex As Exception
                MsgBox("Error - Scalar - BD")
                MsgBox(ex.Message)
                Return Nothing
            Finally
                mConnection.Close()
                mConnection.Dispose()
            End Try
        End Function
    End Class

End Namespace