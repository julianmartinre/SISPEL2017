Imports System
Imports System.Diagnostics

Namespace Sistema

    Public Class EventViewer

        Public Enum TipoEvento
            _Warning
            _Error
            _Information
        End Enum

        Private Property Tipo As EventLogEntryType
        Property Mensaje As String

        Sub New(sSource As String, sLog As String, sEvent As String, sMachine As String, sType As TipoEvento)

            '///Verificamos el tipo evento que vamos a Registrar
            Select Case sType
                Case TipoEvento._Error
                    Tipo = EventLogEntryType.Error
                Case TipoEvento._Warning
                    Tipo = EventLogEntryType.Warning
                Case TipoEvento._Information
                    Tipo = EventLogEntryType.Information
            End Select




            '///En caso de existir el Source se crea dentro del registro de Windows: HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\eventlog
            Try
                If Not EventLog.SourceExists(sSource, sMachine) Then
                    EventLog.CreateEventSource(sSource, sLog, sMachine)
                End If
            Catch ex As Security.SecurityException
                Mensaje = "No tiene Acceso al Registro del Sistema, por Favor Ejecute la aplicacion como Administrador"
            End Try




            '///Creo un evento y le envio los parametros ya cargados
            Try
                Dim ELog As New EventLog(sLog, sMachine, sSource)
                ELog.WriteEntry(sEvent, Tipo)
                Mensaje = "Registro creado OK"

            Catch Ex As Security.SecurityException
                Mensaje = "No tiene Acceso al Visor de Eventos, por Favor Ejecute la aplicacion como Administrador"

            Catch ex As System.ArgumentException
                Dim ELog As New EventLog("Application", ".", Me.ToString)
                ELog.WriteEntry("El Origen de Datos ya se encuentra creado para otro Tipo de Log" & vbCrLf & vbCrLf & ex.ToString, EventLogEntryType.Error)
                Mensaje = "Vea el visor de eventos, Seccion Application"
            End Try

        End Sub

        Public Shared Sub RegistrarError(Origen As String, Tipo As String, Texto As String, TipoDeError As TipoEvento)

            Dim Evento As EventViewer
            Evento = New EventViewer(Origen, Tipo, Texto, ".", TipoDeError)

        End Sub

    End Class

End Namespace
