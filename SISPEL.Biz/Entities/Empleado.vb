Namespace Entities

    ''' <summary>
    ''' Clase que representa a los empleados del negocio (peluqueria).
    ''' </summary>
    ''' <remarks>Descripción de sus propiedades.</remarks>
    Public Class Empleado
        Inherits Persona

        Private _idEmpleado As Integer
        Private _usuario As String
        Private _contrasenia As String
        Private _fechaDeNacimiento As Date
        Private _telefono As Integer
        Private _domicilio As String

        Public Property idEmpleado() As Integer
            Get
                Return _idEmpleado
            End Get
            Set(ByVal value As Integer)
                _idEmpleado = value
            End Set
        End Property

        Public Property usuario() As String
            Get
                Return _usuario
            End Get
            Set(ByVal value As String)
                _usuario = value
            End Set
        End Property

        Public Property contrasenia() As String
            Get
                Return _contrasenia
            End Get
            Set(ByVal value As String)
                _contrasenia = value
            End Set
        End Property

        Public Property fechaDeNacimiento() As Date
            Get
                Return _fechaDeNacimiento
            End Get
            Set(ByVal value As Date)
                _fechaDeNacimiento = value
            End Set
        End Property

        Public Property telefono() As Integer
            Get
                Return _telefono
            End Get
            Set(ByVal value As Integer)
                _telefono = value
            End Set
        End Property

        Public Property domicilio() As String
            Get
                Return _domicilio
            End Get
            Set(ByVal value As String)
                _domicilio = value
            End Set
        End Property

    End Class

End Namespace