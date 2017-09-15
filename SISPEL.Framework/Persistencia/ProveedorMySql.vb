Namespace Persistencia

    Public Class ProveedorMySql
        Implements IProveedorBD

        Public Sub ConexionFinalizar() Implements IProveedorBD.ConexionFinalizar

        End Sub

        Public Sub ConexionIniciar() Implements IProveedorBD.ConexionIniciar

        End Sub

        Public Function EjecutarEscalar(Of T)(query As String, parametros As List(Of Parametro)) As T Implements IProveedorBD.EjecutarEscalar

        End Function

        Public Sub EjecutarSinResultado(query As String, parametros As List(Of Parametro)) Implements IProveedorBD.EjecutarSinResultado

        End Sub

        Public Function EjecutarTupla(Of T As New)(query As String, parametros As List(Of Parametro)) As List(Of T) Implements IProveedorBD.EjecutarTupla
            Return Nothing
        End Function

        Public Sub TransaccionAceptar() Implements IProveedorBD.TransaccionAceptar

        End Sub

        Public Sub TransaccionCancelar() Implements IProveedorBD.TransaccionCancelar

        End Sub

        Public Sub TransaccionIniciar() Implements IProveedorBD.TransaccionIniciar

        End Sub

    End Class

End Namespace