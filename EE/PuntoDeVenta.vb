Public MustInherit Class PuntoDeVenta

    Private vId As Integer
    Public Property Id() As Integer
        Get
            Return vId
        End Get
        Set(ByVal value As Integer)
            vId = value
        End Set
    End Property

    Private vNumero As String
    Public Property Numero() As String
        Get
            Return vNumero
        End Get
        Set(ByVal value As String)
            vNumero = value
        End Set
    End Property

    Private vListaEntradas As New List(Of Entrada)
    Public Property ListaEntradas() As List(Of Entrada)
        Get
            Return vListaEntradas
        End Get
        Set(ByVal value As List(Of Entrada))
            vListaEntradas = value
        End Set
    End Property

    Private vLocacion As New Locacion
    Public Property Locacion() As Locacion
        Get
            Return vLocacion
        End Get
        Set(ByVal value As Locacion)
            vLocacion = value
        End Set
    End Property

    Public Function CantidadVendida() As Integer
        Return Me.ListaEntradas.Count
    End Function

End Class
