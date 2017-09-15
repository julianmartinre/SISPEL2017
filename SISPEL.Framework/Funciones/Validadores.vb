Namespace Funciones

    Public Class Validadores

        ''' <summary>
        ''' ValidarTextoVacio
        ''' </summary>
        ''' <param name="Texto">Texto a validar.</param>
        ''' <returns>Verdadero si el texto está vacio.</returns>
        ''' <remarks></remarks>
        Public Shared Function ValidarTextoVacio(Texto As String) As Boolean
            If Texto = Nothing Then
                Return True
            Else
                Return False
            End If
        End Function

    End Class

End Namespace