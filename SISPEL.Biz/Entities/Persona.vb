Namespace Entities

    Public MustInherit Class Persona

        Private _nombre As String
        Private _apellido As String
        Private _dni As Integer
        Private _activo As Boolean

        Public Property nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Public Property apellido() As String
            Get
                Return _apellido
            End Get
            Set(ByVal value As String)
                _apellido = value
            End Set
        End Property

        Public Property dni() As Integer
            Get
                Return _dni
            End Get
            Set(ByVal value As Integer)
                _dni = value
            End Set
        End Property

        Public Property activo() As Boolean
            Get
                Return _activo
            End Get
            Set(ByVal value As Boolean)
                _activo = value
            End Set
        End Property

    End Class

End Namespace
