Namespace Persistencia

    Public Interface IProveedorBD

        Sub ConexionIniciar()
        Sub ConexionFinalizar()
        Sub TransaccionIniciar()
        Sub TransaccionCancelar()
        Sub TransaccionAceptar()

        Sub EjecutarSinResultado(query As String, parametros As List(Of Parametro))
        Function EjecutarEscalar(Of T)(query As String, parametros As List(Of Parametro)) As T
        Function EjecutarTupla(Of T As New)(query As String, parametros As List(Of Parametro)) As List(Of T)

    End Interface

End Namespace
