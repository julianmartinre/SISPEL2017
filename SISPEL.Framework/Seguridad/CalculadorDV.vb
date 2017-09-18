Namespace Seguridad

    Public Class CalculadorDV

    ''' <summary>
    ''' Calcula el DV para un String de datos
    ''' </summary>
    ''' <param name="pString">Datos con los que calcular el DV</param>
    ''' <returns>DV calculado</returns>
    Public Shared Function CalcularDV(pString As String) As Integer
        Dim mDV As Integer

        pString = pString.ToUpper

        Dim mTotal As Integer

        For i As Integer = 0 To pString.Length - 1
            Dim mChar As Char = pString.Chars(pString.Length - i - 1)

            Dim mDigito As Integer = Asc(mChar) - 48

            Dim mValor As Integer

            If i Mod 2 = 0 Then
                mValor = (2 * mDigito) - CInt(mDigito / 5) * 9
            Else
                mValor = mDigito
            End If

            mTotal += mValor
        Next

        mTotal = Math.Abs(mTotal) + 10

        mDV = (10 - (mTotal Mod 10)) Mod 10

        Return mDV
    End Function


    ''' <summary>
    ''' Valida los datos con su DV
    ''' </summary>
    ''' <param name="pString">Datos que se quieren verificar</param>
    ''' <param name="pDV">DV qeu verifica esos datos</param>
    ''' <returns></returns>
    Public Shared Function VerificarDV(pString As String, pDV As Integer) As Boolean
        If CalcularDV(pString) = pDV Then
            Return True
        Else
            Return False
        End If
    End Function

End Class

End Namespace
