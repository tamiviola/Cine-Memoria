Public Class MaquinaExpendedora
    Inherits PuntoDeVenta

    Private vTecnico As New Tecnico
    Public Property Tecnico() As Tecnico
        Get
            Return vTecnico
        End Get
        Set(ByVal value As Tecnico)
            vTecnico = value
        End Set
    End Property

End Class
