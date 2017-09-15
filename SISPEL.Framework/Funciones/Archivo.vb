Imports System.IO

Namespace Funciones

    Public Class Archivo

        Public Shared Sub GuardarEnString(ruta As String, contenido As String)

            Dim escritor As StreamWriter
            escritor = File.AppendText(ruta)
            escritor.Write(contenido)
            escritor.Flush()
            escritor.Close()

        End Sub

    End Class

End Namespace
