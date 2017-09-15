Namespace Persistencia

    Public Class Parametro

        Sub New(nombreParametro As String, valor As Object)

            Me.NombreParametro = nombreParametro
            Me.Valor = valor

        End Sub

        Property NombreParametro As String

        Property Valor As Object

    End Class

End Namespace
