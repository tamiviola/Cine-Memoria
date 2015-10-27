Public Class Butaca

    Private vId As Integer
    Public Property Id() As Integer
        Get
            Return vId
        End Get
        Set(ByVal value As Integer)
            vId = value
        End Set
    End Property

    Private vCodigo As String
    Public Property Codigo() As String
        Get
            Return vCodigo
        End Get
        Set(ByVal value As String)
            vCodigo = value
        End Set
    End Property

    Private vEstado As Boolean
    Public Property Estado() As Boolean
        Get
            Return vEstado
        End Get
        Set(ByVal value As Boolean)
            vEstado = value
        End Set
    End Property

End Class
