Namespace Funciones

    Public Class Fechas

        ''' <summary>
        ''' Fecha de hoy
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Shared Function Hoy() As String
            Return Date.Today
        End Function

        ''' <summary>
        ''' Devuelve fecha y hora del momento
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Shared Function Ahora() As String
            Return Date.Now
        End Function

        Public Shared Function UltimoDiaDelMesEnFecha(Mes As Integer, Anio As Integer) As Date
            Return New DateTime(Anio, Mes, 1).AddMonths(1).AddDays(-1)
        End Function

    End Class

End Namespace
