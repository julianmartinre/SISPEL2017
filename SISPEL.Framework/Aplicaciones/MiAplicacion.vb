Namespace Aplicaciones

    Public Class MiAplicacion

        Public Shared Function NombreAplicacion() As String
            Return My.Application.Info.AssemblyName
        End Function

        Public Shared Function DirectorioAplicacion() As String
            Return My.Application.Info.DirectoryPath
        End Function

    End Class

End Namespace

