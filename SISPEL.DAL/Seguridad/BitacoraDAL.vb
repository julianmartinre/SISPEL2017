Imports SISPEL.Biz
Imports SISPEL.DAL.Conexion

Namespace Seguridad

    Public Class BitacoraDAL
        Private Shared Sub CargarRegistro(unRegistro As BitacoraRegistro, pRow As DataRow)

            unRegistro.empleado = pRow("bitacora_empleado")
            unRegistro.fecha = pRow("bitacora_fecha")
            unRegistro.descripcion = pRow("bitacora_descripcion")

        End Sub


        Public Shared Sub GuardarRegistro(unRegistro As BitacoraRegistro)

            'Dim mCommand As String = "insert into Bitacora(bitacora_empleado, bitacora_fecha, bitacora_descripcion) 
            '                      values('" & unRegistro.empleado & "', '" & unRegistro.fecha.ToString("yyyy-MM-dd") & "', '" & unRegistro.descripcion & "');"

            Dim mCommand As String = "INSERT INTO Bitacora(bitacora_empleado, bitacora_fecha, bitacora_descripcion) " &
                                     "VALUES ('" & unRegistro.empleado & "', '" & unRegistro.fecha.ToString("yyyy-MM-dd") & "', '" & unRegistro.descripcion & "');"


            Try
                BD.ExecuteNonQuery(mCommand)
            Catch ex As Exception
                MsgBox("Error - Nuevo - BitacoraDAL")
                MsgBox(ex.Message)
            End Try

        End Sub


        Public Shared Function ListarRegistros() As List(Of BitacoraRegistro)
            Dim mLista As New List(Of BitacoraRegistro)
            Dim mCommand As String = "select bitacora_empleado, bitacora_fecha, bitacora_descripcion from Bitacora"
            Dim mDataSet As DataSet

            Try
                mDataSet = BD.ExecuteDataSet(mCommand)

                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim unRegistro As New BitacoraRegistro

                    CargarRegistro(unRegistro, mRow)

                    mLista.Add(unRegistro)
                Next

                Return mLista
            Catch ex As Exception
                MsgBox("Error - Listar - BitacoraDAL")
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

    End Class

End Namespace
