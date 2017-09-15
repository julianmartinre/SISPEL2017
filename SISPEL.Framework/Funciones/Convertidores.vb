Namespace Funciones

    Public Class Convertidores

        Public Shared Function ObjetoABooleano(Texto As Object) As Boolean
            If (Texto = "si") Or (Texto <= 1) Or (Texto = "true") Or (Texto = "t") Then
                Return True
            Else
                Return False
            End If
        End Function


        Public Shared Function CeroALaIzquierda(Numero As Integer, Longitud As Integer) As String
            Return Numero.ToString.PadLeft(Longitud, "0")
        End Function

    End Class

End Namespace

