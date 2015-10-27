Public Class Entrada

    Private vId As Integer
    Public Property Id() As Integer
        Get
            Return vId
        End Get
        Set(ByVal value As Integer)
            vId = value
        End Set
    End Property


    Private vHorario As New Horario
    Public Property Horario() As Horario
        Get
            Return vHorario
        End Get
        Set(ByVal value As Horario)
            vHorario = value
        End Set
    End Property

    Private VButaca As New Butaca
    Public Property Butaca() As Butaca
        Get
            Return VButaca
        End Get
        Set(ByVal value As Butaca)
            VButaca = value
        End Set
    End Property

    Private vPuntoVenta As PuntoDeVenta
    Public Property PuntoVenta() As PuntoDeVenta
        Get
            Return vPuntoVenta
        End Get
        Set(ByVal value As PuntoDeVenta)
            vPuntoVenta = value
        End Set
    End Property

    Private vSala As New Sala
    Public Property Sala() As Sala
        Get
            Return vSala
        End Get
        Set(ByVal value As Sala)
            vSala = value
        End Set
    End Property

End Class
