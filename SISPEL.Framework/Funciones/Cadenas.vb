Imports System.IO
Imports System.Text

Namespace Funciones

    Public Class Cadenas

        Public Function DecorarLista(unaLista As List(Of String), decoradoIzquierdo As String, decoradoDerecho As String) As List(Of String)

            Dim resultado As New List(Of String)

            For Each item In unaLista
                resultado.Add(decoradoIzquierdo & item & decoradoDerecho)
            Next

            Return resultado

        End Function

        ''' <summary>
        ''' Texto sin basura a la derecha
        ''' </summary>
        ''' <param name="Texto">Texto</param>
        ''' <param name="Marca">Marca en la cual a partir de la misma se borrara todo lo que siga a la derecha</param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Shared Function TextoSinBasuraDerecha(ByVal Texto As String, ByVal Marca As String) As String

            Dim ListaSeparada As List(Of String) = Split(Texto, Marca).ToList

            Return ListaSeparada(0)

        End Function

        ''' <summary>
        ''' Texto sin basura a la izquierda
        ''' </summary>
        ''' <param name="Texto">Texto</param>
        ''' <param name="Marca">Marca en la cual a partir de la misma se borrara todo lo que siga a la derecha</param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Shared Function TextoSinBasuraIzquierda(ByVal Texto As String, ByVal Marca As String) As String

            Dim ListaSeparada As List(Of String) = Split(Texto, Marca).ToList

            Return ListaSeparada(1)

        End Function

        ''' <summary>
        ''' Reemplazar texto
        ''' </summary>
        ''' <param name="Texto">Texto original</param>
        ''' <param name="Buscar">Texto que se quiere colocar</param>
        ''' <param name="pReemplazar">Reemplazo del texto</param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Shared Function ReemplazarTexto(ByVal Texto As String, ByVal Buscar As String, ByVal pReemplazar As String) As String

            Return Replace(Texto, Buscar, pReemplazar)

        End Function

        ''' <summary>
        ''' Texto entre marcas
        ''' </summary>
        ''' <param name="Texto">Texto original</param>
        ''' <param name="mIzq">Marca izquierda</param>
        ''' <param name="mDer">Marca derecha</param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Shared Function TextoEntreMarcas(ByVal Texto As String, ByVal mIzq As String, ByVal mDer As String) As String

            Dim Resultado As String

            Resultado = TextoSinBasuraDerecha(Texto, mDer)
            Resultado = TextoSinBasuraIzquierda(Resultado, mIzq)


            Return Resultado

        End Function

        Public Shared Function ObtenerParametrosEnQuery(ByVal pConsulta As String) As List(Of String)

            Dim resultado As New List(Of String)

            Dim inicio As Integer = InStr(pConsulta, "@")

            Do While inicio > 0

                Dim arrayFinal(4) As Integer
                arrayFinal(0) = InStr(inicio, pConsulta, " ")
                arrayFinal(1) = InStr(inicio, pConsulta, ",")
                arrayFinal(2) = InStr(inicio, pConsulta, ")")
                arrayFinal(3) = InStr(inicio, pConsulta, ";")
                arrayFinal(4) = InStr(inicio, pConsulta, vbNewLine)

                Array.Sort(arrayFinal)

                Dim valorMinimo As Integer = Int32.MinValue
                If arrayFinal(4) > 0 Then valorMinimo = arrayFinal(4)
                If arrayFinal(3) > 0 Then valorMinimo = arrayFinal(3)
                If arrayFinal(2) > 0 Then valorMinimo = arrayFinal(2)
                If arrayFinal(1) > 0 Then valorMinimo = arrayFinal(1)
                If arrayFinal(0) > 0 Then valorMinimo = arrayFinal(0)
                If arrayFinal(0) = 0 And arrayFinal(1) = 0 And arrayFinal(2) = 0 And arrayFinal(3) = 0 And arrayFinal(4) = 0 Then valorMinimo = pConsulta.Length + 1

                resultado.Add(Mid(pConsulta, inicio, valorMinimo - inicio))

                inicio = InStr(valorMinimo + 1, pConsulta, "@")

            Loop

            Return resultado

        End Function

        Public Shared Function StreamACadena(stream As Stream) As String

            Dim bytes(stream.Length) As Byte

            stream.Position = 0
            stream.Read(bytes, 0, stream.Length)

            Return BytesACadena(bytes)

        End Function

        Public Shared Function CadenaABytes(cadena As String) As Byte()

            Return Encoding.ASCII.GetBytes(cadena)

        End Function

        Public Shared Function BytesACadena(bytes As Byte()) As String

            Return Encoding.ASCII.GetString(bytes)

        End Function

    End Class

End Namespace
