Public Class BitacoraRegistro

    Private _empleado As String
    Public Property empleado() As String
        Get
            Return _empleado
        End Get
        Set(ByVal value As String)
            _empleado = value
        End Set
    End Property

    Private _fecha As Date
    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Private _desripcion As String
    Public Property descripcion() As String
        Get
            Return _desripcion
        End Get
        Set(ByVal value As String)
            _desripcion = value
        End Set
    End Property

End Class
