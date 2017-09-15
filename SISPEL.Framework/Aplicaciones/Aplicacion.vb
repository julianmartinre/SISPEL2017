Namespace Aplicaciones

    Public Class Aplicacion

        'AplicacionEstaCorriendo(Nombre aplicacion) Consultar al TaskManager si la aplicacion esta corriendo Devuelve  bool
        'LanzarAplicacion(Path de la aplicacion)
        'CerrarAplicacion(Nombre de la aplicacion)

        ''' <summary>
        ''' Lanza una aplicacion
        ''' </summary>
        ''' <param name="Aplicacion">Ruta donde se encuentra la aplicacion</param>
        ''' <remarks></remarks>

        Public Shared Sub LanzarAplicacion(ByVal Aplicacion As String)
            Shell(Aplicacion)
        End Sub

        ''' <summary>
        ''' Se fija si una aplicacion esta coriendo
        ''' </summary>
        ''' <param name="NombreProceso">Nombre del proceso</param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Shared Function AplicacionEstaCoriendo(NombreProceso As String) As Boolean

            Return System.Diagnostics.Process.GetProcessesByName(NombreProceso).Length > 0

        End Function

    End Class

End Namespace
