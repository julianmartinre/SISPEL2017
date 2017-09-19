

Imports SISPEL.Biz
Imports SISPEL.DAL.Seguridad
''' <summary>
''' Clase Singleton
''' </summary>
Public Class Bitacora

#Region "Singleton"
    Private Shared mInstance As Bitacora


    Private Sub New()

    End Sub


    ''' <summary>
    ''' Devuelve la unica instancia de Bitacora que hay en el sistema
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function GetInstance() As Bitacora
        If IsNothing(mInstance) Then
            mInstance = New Bitacora
        End If

        Return mInstance
    End Function
#End Region

    Public Sub GuardarRegistro(unEmpleado As String, fecha As Date, descripcion As String)
        Dim unRegistro As New BitacoraRegistro
        unRegistro.empleado = unEmpleado
        unRegistro.fecha = fecha
        unRegistro.descripcion = descripcion

        'mRegistro.DV = CalculadorDV.CalcularDV(mRegistro.Usuario & mRegistro.Fecha.ToString("yyyymmdd") & mRegistro.Descripcion)

        BitacoraDAL.GuardarRegistro(unRegistro)

        'ControladorDVV.ModificarDigito("Bitacora", ControladorDVV.CalcularDVV("Bitacora"))

    End Sub


    ''' <summary>
    ''' Lista todo lo que haya registrado en la bitacora
    ''' </summary>
    ''' <returns>Lista con los datos de las acciones registradas</returns>
    Public Shared Function ListarRegistros() As List(Of BitacoraRegistro)
        Dim mLista As List(Of BitacoraRegistro) = BitacoraDAL.ListarRegistros
        Dim mVerif As Boolean
        mVerif = True

        'For Each mRegistro As BitacoraRegistro In mLista
        '    If Not (CalculadorDV.VerificarDV(mRegistro.Usuario & mRegistro.fecha.ToString("yyyymmdd") & mRegistro.descripcion, mRegistro.DV)) Then
        '        mVerif = False
        '        Exit For
        '    Else
        '        mVerif = True
        '    End If
        'Next

        If mVerif Then
            Return mLista
        Else
            MsgBox("Unos de los registros fue cambiado - Bitacora")
            Return Nothing
        End If
    End Function

End Class
