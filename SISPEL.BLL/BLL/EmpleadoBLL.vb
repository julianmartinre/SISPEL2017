Imports SISPEL.Biz.Entities
Imports SISPEL.DAL.DAL

Namespace BLL

    Public Class EmpleadoBLL

        Public Property nombre As String
        Public Property apellido As String
        Public Property dni As Integer
        Public Property activo As Boolean
        Public Property id As Integer
        Public Property user As String
        Public Property password As String
        Public Property fechaDeNacimiento As DateTime
        Public Property telefono As Integer
        Public Property domicilio As String

        Sub New()

        End Sub

        Sub New(propEmpleado As String)
            CargarPropiedades(propEmpleado)
        End Sub
        Sub New(propEmpleado As Empleado)
            CargarPropiedades(propEmpleado)
        End Sub

        Private Sub CargarPropiedades(propEmpleado As String)
            Dim unEmpleado As Empleado = EmpleadoDAL.ObtenerEmpleado(propEmpleado)

            If Not IsNothing(unEmpleado) Then
                'If CalculadorDV.VerificarDV(mBE.ID & mBE.UserName & mBE.Nombre & mBE.Apellido & mBE.Password & mBE.Rol, mBE.DV) Then
                Me.nombre = unEmpleado.nombre
                Me.apellido = unEmpleado.apellido
                Me.dni = unEmpleado.dni
                Me.activo = unEmpleado.activo
                Me.id = unEmpleado.idEmpleado
                Me.user = unEmpleado.usuario
                Me.password = unEmpleado.contrasenia
                Me.fechaDeNacimiento = unEmpleado.fechaDeNacimiento
                Me.telefono = unEmpleado.telefono
                Me.domicilio = unEmpleado.domicilio
                'Else
                '    MsgBox("Error - DV - Usuario - CargarPropieades(String)")
                'End If
            End If
        End Sub

        Private Sub CargarPropiedades(propEmpleado As Empleado)
            If Not IsNothing(propEmpleado) Then
                Me.nombre = propEmpleado.nombre
                Me.apellido = propEmpleado.apellido
                Me.dni = propEmpleado.dni
                Me.activo = propEmpleado.activo
                Me.id = propEmpleado.idEmpleado
                Me.user = propEmpleado.usuario
                Me.password = propEmpleado.contrasenia
                Me.fechaDeNacimiento = propEmpleado.fechaDeNacimiento
                Me.telefono = propEmpleado.telefono
                Me.domicilio = propEmpleado.domicilio
            End If
        End Sub

        Private Sub CargarEmpleado(unEmpleado As Empleado)

            unEmpleado.nombre = Me.nombre
            unEmpleado.apellido = Me.apellido
            unEmpleado.dni = Me.dni
            unEmpleado.activo = Me.activo
            unEmpleado.idEmpleado = Me.id
            unEmpleado.usuario = Me.user
            unEmpleado.contrasenia = Me.password
            unEmpleado.fechaDeNacimiento = Me.fechaDeNacimiento
            unEmpleado.telefono = Me.telefono
            unEmpleado.domicilio = Me.domicilio

        End Sub


        ''' <summary>
        ''' Persiste en la base los datos de la instancia
        ''' </summary>
        Public Sub Guardar()
            Dim unEmpleado As New Empleado

            'Me.DV = CalculadorDV.CalcularDV(Me.id & Me.UserName & Me.nombre & Me.apellido & Me.password & Me.Rol)

            If Me.id = 0 Then
                CargarEmpleado(unEmpleado)
                EmpleadoDAL.GuardarNuevo(unEmpleado)
            Else
                CargarEmpleado(unEmpleado)
                EmpleadoDAL.GuardarModificacion(unEmpleado)
            End If

            'ControladorDVV.ModificarDigito("Usuario", ControladorDVV.CalcularDVV("Usuario"))

        End Sub


        '''' <summary>
        '''' Elimina los datos de esta instancia de la BD
        '''' </summary>
        'Public Sub Eliminar()
        '    Dim mBE As New UsuarioBE

        '    CargarBE(mBE)

        '    UsuarioDAL.Eliminar(mBE)

        '    ControladorDVV.ModificarDigito("Usuario", ControladorDVV.CalcularDVV("Usuario"))
        'End Sub


        '''' <summary>
        '''' Instancia y guarda en un lista objetos BLL con los datos de cada usuario guardado en la BD
        '''' </summary>
        '''' <returns>List(Of UsuarioBLL) con datos de cada usuario</returns>
        'Public Shared Function ListarUsuarios() As List(Of UsuarioBLL)
        '    Dim mLista As New List(Of UsuarioBLL)
        '    Dim mListaBE As List(Of UsuarioBE) = UsuarioDAL.ListarUsuarios

        '    If Not IsNothing(mListaBE) Then
        '        For Each mBE As UsuarioBE In mListaBE
        '            If CalculadorDV.VerificarDV(mBE.ID & mBE.UserName & mBE.Nombre & mBE.Apellido & mBE.Password & mBE.Rol, mBE.DV) Then
        '                Dim mUsuario As New UsuarioBLL(mBE)

        '                mLista.Add(mUsuario)
        '            Else
        '                MsgBox("Error - DV - Usuario - Listar")
        '            End If
        '        Next
        '    End If


        '    Return mLista
        'End Function


        Public Overrides Function ToString() As String
            Return Me.user
        End Function

        Public Sub insertarEmpleado(unEmpleado As Empleado)
            Dim empleadoDAL As New EmpleadoDAL
            EmpleadoDAL.GuardarNuevo(unEmpleado)
        End Sub

    End Class

End Namespace
