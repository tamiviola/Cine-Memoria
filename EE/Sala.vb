Public Class Sala

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

    Private vPiso As String
    Public Property Piso() As String
        Get
            Return vPiso
        End Get
        Set(ByVal value As String)
            vPiso = value
        End Set
    End Property

    Private vListaButacas As New List(Of Butaca)
    Public Property ListaButacas() As List(Of Butaca)
        Get
            Return vListaButacas
        End Get
        Set(ByVal value As List(Of Butaca))
            vListaButacas = value
        End Set
    End Property

    Private vListaHorarios As New List(Of Horario)
    Public Property ListaHorarios() As List(Of Horario)
        Get
            Return vListaHorarios
        End Get
        Set(ByVal value As List(Of Horario))
            vListaHorarios = value
        End Set
    End Property

End Class
