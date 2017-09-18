Imports System.Security.Cryptography
Imports System.Text

Namespace Seguridad

    Public Class Encriptador

#Region "Singleton"
        Private Shared mInstance As Encriptador = Nothing

        Private Sub New()

        End Sub

        ''' <summary>
        ''' Se encarga de devolver la unica instancia de Encriptador existente en el Sistema
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function GetInstance() As Encriptador
            If mInstance Is Nothing Then
                mInstance = New Encriptador
            End If
            Return mInstance
        End Function
#End Region


        ''' <summary>
        ''' Encripta el String ingresado por parametro
        ''' </summary>
        ''' <param name="pTexto">String que se desea encriptar</param>
        ''' <returns>String resultante de la encriptacion</returns>
        Public Function Encriptar(pTexto As String) As String
            Dim mMD5Hash As MD5 = MD5.Create
            Dim mBytes As Byte() = mMD5Hash.ComputeHash(Encoding.UTF8.GetBytes(pTexto))
            Dim mStringBuilder As New StringBuilder

            For i = 0 To mBytes.Length - 1
                mStringBuilder.Append(mBytes(i).ToString("X2"))
            Next

            Return mStringBuilder.ToString
        End Function


        ''' <summary>
        ''' Valida que un String sin encriptar sea igual a otro encriptado anteroirmente
        ''' </summary>
        ''' <param name="pTexto">Texto a comparar</param>
        ''' <param name="pEncriptado">Texto encriptado</param>
        ''' <returns>Boolean indicando la igualdad de los Strings</returns>
        Public Function ValidarHash(pTexto As String, pEncriptado As String) As Boolean
            Dim mNuevoHash As String = Encriptar(pTexto)
            If mNuevoHash = pEncriptado Then
                Return True
            Else
                Return False
            End If
        End Function

    End Class

End Namespace
