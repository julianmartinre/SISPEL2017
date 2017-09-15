Imports System.Data.SqlClient

Namespace Persistencia

     Class ProveedorSQLServer
        Implements IProveedorBD

        Private _SqlConnection As SqlConnection
        Private _SqlTransaction As SqlTransaction
        Private _servidor As String
        Private _catalogo As String
        Private _usuario As String
        Private _clave As String

        Public Sub New(Servidor As String, Catalogo As String)
            Me._servidor = Servidor
            Me._catalogo = Catalogo
        End Sub

        Public Sub New(Servidor As String, Catalogo As String, Usuario As String, Clave As String)
            Me._servidor = Servidor
            Me._catalogo = Catalogo
            Me._usuario = Usuario
            Me._clave = Clave
        End Sub

        Public Sub ConexionIniciar() Implements IProveedorBD.ConexionIniciar
            _SqlConnection = New SqlConnection(Me.ObtenerCadenaConexion(_servidor, _catalogo))
            _SqlConnection.Open()
        End Sub

        Public Sub ConexionFinalizar() Implements IProveedorBD.ConexionFinalizar
            _SqlConnection.Close()
        End Sub

        Public Sub TransaccionIniciar() Implements IProveedorBD.TransaccionIniciar
            _SqlTransaction = _SqlConnection.BeginTransaction()
        End Sub

        Public Sub TransaccionAceptar() Implements IProveedorBD.TransaccionAceptar
            _SqlTransaction.Commit()
        End Sub

        Public Sub TransaccionCancelar() Implements IProveedorBD.TransaccionCancelar
            _SqlTransaction.Rollback()
        End Sub

        Public Sub EjecutarSinResultado(query As String, parametros As List(Of Parametro)) Implements IProveedorBD.EjecutarSinResultado

            Dim unComando As New SqlCommand
            unComando.Connection = _SqlConnection
            unComando.Transaction = _SqlTransaction

            unComando.CommandType = CommandType.Text
            unComando.CommandText = query

            For Each item In parametros

                Dim unParametro As New SqlParameter(item.NombreParametro, item.Valor)
                unComando.Parameters.Add(unParametro)

            Next

            unComando.ExecuteNonQuery()

        End Sub

        Public Function EjecutarEscalar(Of T)(query As String, parametros As List(Of Parametro)) As T Implements IProveedorBD.EjecutarEscalar
            Dim unComando As New SqlCommand

            unComando.Connection = _SqlConnection
            unComando.Transaction = _SqlTransaction

            unComando.CommandType = CommandType.Text
            unComando.CommandText = query

            For Each item In parametros

                Dim unParametro As New SqlParameter(item.NombreParametro, item.Valor)
                unComando.Parameters.Add(unParametro)

            Next

            Return CType(unComando.ExecuteScalar(), T)
        End Function

        Public Function EjecutarTupla(Of T As New)(query As String, parametros As List(Of Parametro)) As List(Of T) Implements IProveedorBD.EjecutarTupla

            Dim unComando As New SqlCommand

            'Preconfig...
            unComando.Connection = _SqlConnection
            unComando.Transaction = _SqlTransaction

            unComando.CommandType = CommandType.Text
            unComando.CommandText = query

            For Each item In parametros

                Dim unParametro As New SqlParameter(item.NombreParametro, item.Valor)
                unComando.Parameters.Add(unParametro)

            Next

            'Ejecucion...
            Dim resultadoDataReader = unComando.ExecuteReader()

            Return MappearResultado(Of T)(resultadoDataReader)

        End Function

        Private Function MappearResultado(Of T As New)(resultadoDataReader As SqlDataReader) As List(Of T)

            Dim resultado As New List(Of T)

            'Recorro todos los rows.
            Do While resultadoDataReader.Read()

                'Creo un T.
                Dim unT As New T

                'Recorro las columnas de la tabla.
                For i = 0 To resultadoDataReader.FieldCount - 1

                    'A una instancia de T, pegarle cada una de estas propiedades...
                    Dim nombreColumna = resultadoDataReader.GetName(i)

                    'Obtengo la property
                    Dim propiedadInfo = unT.GetType().GetProperty(nombreColumna)

                    'Le pego el valor a esa property.
                    propiedadInfo.SetValue(unT, resultadoDataReader.GetValue(i))

                Next

                resultado.Add(unT)

            Loop

            resultadoDataReader.Close()

            Return resultado

        End Function

        Private Function ObtenerCadenaConexion(server As String, catalogo As String, usuario As String, clave As String) As String

            Return String.Format("Server={0};Database={1};User Id={2};Password={3};", server, catalogo, usuario, clave)

        End Function

        Private Function ObtenerCadenaConexion(server As String, catalogo As String) As String

            Return String.Format("Server={0};Database={1};Trusted_Connection=True;", server, catalogo)

        End Function
    End Class


End Namespace
