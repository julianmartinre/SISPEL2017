Imports SISPEL.Biz
Imports SISPEL.DAL.Conexion

Public Class IdiomaDAL

    Private Shared Function CargarIdioma(unIdioma As Idioma, pRow As DataRow) As Idioma

        unIdioma.id = pRow("idioma_id")
        unIdioma.nombre = pRow("idioma_nombre")

        CargarDiccionario(unIdioma)

        Return unIdioma

    End Function

    Public Shared Function ObtenerIdioma(nombreIdioma As String) As Idioma

        Dim unIdioma As New Idioma
        Dim mCommand As String = "SELECT idioma_id, idioma_nombre FROM Idioma WHERE idioma_nombre LIKE '" & nombreIdioma & "';"

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                unIdioma = CargarIdioma(unIdioma, mDataSet.Tables(0).Rows(0))
                Return unIdioma
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - IdiomaDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Sub GuardarNuevo(unIdioma As Idioma)
        Dim mCommand As String = "INSERT INTO Idioma(idioma_nombre) " &
                                 "VALUES ('" & unIdioma.nombre & "');"

        Dim mCommandTraduccion As String

        Try
            BD.ExecuteNonQuery(mCommand)

            For Each mTraduccion As KeyValuePair(Of String, String) In unIdioma.Diccionario
                mCommandTraduccion = "insert into TextoIdioma(textoIdioma_texto, textoIdioma_idioma, textoIdioma_traduccion) " &
                                     "values( " &
                                     "(select texto_id from texto where texto_texto like '" & mTraduccion.Key & "'), " &
                                     "(select max(idioma_id) from idioma), " &
                                     "'" & mTraduccion.Value & "')"

                BD.ExecuteNonQuery(mCommandTraduccion)
            Next

        Catch ex As Exception
            MsgBox("Error - Nuevo - IdiomaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub GuardarModificacion(unIdioma As Idioma)
        Dim mCommand As String = "UPDATE Idioma SET " &
                                 "Idioma_nombre = '" & unIdioma.nombre &
                                 " WHERE Idioma_id = " & unIdioma.id

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - IdiomaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub ModificarTraducciones(unIdioma As Idioma)
        Dim mCommandEliminacion As String = "delete from textoIdioma where textoIdioma_idioma = " & unIdioma.id
        Dim mCommand As String

        Try
            BD.ExecuteNonQuery(mCommandEliminacion)

            For Each mTraduccion As KeyValuePair(Of String, String) In unIdioma.Diccionario
                mCommand = "insert into TextoIdioma(textoIdioma_texto, textoIdioma_idioma, textoIdioma_traduccion) " &
                           "values( " &
                           "(select texto_id from texto where texto_texto like '" & mTraduccion.Key & "'), " & unIdioma.id & ", " &
                           "'" & mTraduccion.Value & "')"

                BD.ExecuteNonQuery(mCommand)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub Eliminar(unIdioma As Idioma)
        Dim mCommand As String = "DELETE FROM Idioma WHERE Idioma_id = " & unIdioma.id
        Dim mCommandElimTraducciones As String = "delete from textoIdioma where textoIdioma_idioma = " & unIdioma.id

        Try
            BD.ExecuteNonQuery(mCommand)
            BD.ExecuteNonQuery(mCommandElimTraducciones)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - IdiomaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Function ListarIdiomas() As List(Of Idioma)
        Dim mLista As New List(Of Idioma)
        Dim mCommand As String = "SELECT Idioma_id, idioma_nombre FROM Idioma"
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim unIdioma As New Idioma

                    unIdioma = CargarIdioma(unIdioma, mRow)

                    mLista.Add(unIdioma)
                Next

                Return mLista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - IdiomaDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Sub CargarDiccionario(unIdioma As Idioma)
        Dim mCommand As String = "select texto_texto, textoIdioma_traduccion from Texto inner join TextoIdioma on texto_id = textoIdioma_texto where textoIdioma_idioma = " & unIdioma.id
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    unIdioma.Diccionario.Add(mRow("texto_texto"), mRow("textoIdioma_traduccion"))
                Next
            End If

        Catch ex As Exception
            MsgBox("Error - Carga Diccionario - IdiomaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
