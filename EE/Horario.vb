Public Class Horario

    Private vId As Integer
    Public Property Id() As Integer
        Get
            Return vId
        End Get
        Set(ByVal value As Integer)
            vId = value
        End Set
    End Property

    Private vInicio As DateTime
    Public Property Inicio() As DateTime
        Get
            Return vInicio
        End Get
        Set(ByVal value As DateTime)
            vInicio = value
        End Set
    End Property

    Private vFin As DateTime
    Public Property Fin() As DateTime
        Get
            Return vFin
        End Get
        Set(ByVal value As DateTime)
            vFin = value
        End Set
    End Property

    Private vPelicula As Pelicula
    Public Property Pelicula() As Pelicula
        Get
            Return vPelicula
        End Get
        Set(ByVal value As Pelicula)
            vPelicula = value
        End Set
    End Property

End Class
