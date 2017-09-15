Namespace Persistencia

    Public Class Conexion

        Public Enum EstrategiasDbEnum
            SqlServer
            MySql
        End Enum

        Private _estrategiaConexion As IProveedorBD

        Public Sub New(estrategiaElegida As EstrategiasDbEnum, servidor As String, catalogo As String)

            Select Case estrategiaElegida

                Case EstrategiasDbEnum.SqlServer
                    _estrategiaConexion = New ProveedorSqlServer(servidor, catalogo)

                Case EstrategiasDbEnum.MySql
                    _estrategiaConexion = New ProveedorMySql()

            End Select

        End Sub


        Public Sub ConexionIniciar()

            _estrategiaConexion.ConexionIniciar()

        End Sub


        Public Sub ConexionFinalizar()

            _estrategiaConexion.ConexionFinalizar()

        End Sub

        Public Sub TransaccionIniciar()

            _estrategiaConexion.TransaccionIniciar()

        End Sub

        Public Sub TransaccionAceptar()

            _estrategiaConexion.TransaccionAceptar()

        End Sub

        Public Sub TransaccionCancelar()

            _estrategiaConexion.TransaccionCancelar()

        End Sub

        Public Sub EjecutarSinResultado(query As String, parametros As List(Of Parametro))

            _estrategiaConexion.EjecutarSinResultado(query, parametros)

        End Sub

        Public Function EjecutarEscalar(Of T)(query As String, parametros As List(Of Parametro)) As T

            Return _estrategiaConexion.EjecutarEscalar(Of T)(query, parametros)

        End Function

        Public Function EjecutarTupla(Of T As New)(query As String, parametros As List(Of Parametro)) As List(Of T)

            Return _estrategiaConexion.EjecutarTupla(Of T)(query, parametros)

        End Function

    End Class

End Namespace
