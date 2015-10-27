Public Class Ventanilla
    Inherits PuntoDeVenta

    Private vCajero As New Cajero
    Public Property Cajero() As Cajero
        Get
            Return vCajero
        End Get
        Set(ByVal value As Cajero)
            vCajero = value
        End Set
    End Property

End Class
