Namespace Funciones

    Public Class Matematicas

        ''' <summary>
        ''' Ingreso un numero y lo redondea a la cantidad de decimales deseada.
        ''' </summary>
        ''' <param name="unNumero">Ingrese cualquier numero.</param>
        ''' <param name="cantidadDecimales">Ingrese la cantidad de decimales.</param>
        ''' <returns>Devuelve el numero redondeado.</returns>
        ''' <remarks></remarks>
        Public Shared Function Redondear(unNumero As Decimal, cantidadDecimales As Integer) As Decimal

            Return Math.Round(unNumero, cantidadDecimales)

        End Function

        Private Shared rnd As New Random

        ''' <summary>
        ''' Ingreso un rango de números y devuelve un número aleatorio.
        ''' </summary>
        ''' <param name="desde">Desde que numero va a devolver.</param>
        ''' <param name="hasta">Hasta que numero va a devolver</param>
        ''' <returns>Numero aleatorio</returns>
        ''' <remarks></remarks>
        Public Shared Function obtenerNumeroAleatorio(desde As Integer, hasta As Integer) As Integer

            Dim resultado As Integer = rnd.Next(desde, hasta + 1)
            Return resultado

        End Function

        Public Shared Function ObtenerPorcentaje(ByVal Total As Integer, ByVal Porciento As Integer) As Integer

            Dim Porcentaje As Integer

            Porcentaje = (Porciento * Total) / 100

            Return porcentaje

        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="Valor"></param>
        ''' <param name="Procentaje"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function AplicarDescuento(Valor As Double, Procentaje As Double) As Double
            Return Valor - (Valor * 20 / 100)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="Valor"></param>
        ''' <param name="Procentaje"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function AplicarRecargo(Valor As Double, Procentaje As Double) As Double
            Return Valor + (Valor * 20 / 100)
        End Function

    End Class

End Namespace
