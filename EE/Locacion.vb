Public Class Locacion

    Private vId As Integer
    Public Property Id() As Integer
        Get
            Return vId
        End Get
        Set(ByVal value As Integer)
            vId = value
        End Set
    End Property

    Private vNombre As String
    Public Property Nombre() As String
        Get
            Return vNombre
        End Get
        Set(ByVal value As String)
            vNombre = value
        End Set
    End Property

    Private vListaSalas As New List(Of Sala)
    Public Property ListaSalas() As List(Of Sala)
        Get
            Return vListaSalas
        End Get
        Set(ByVal value As List(Of Sala))
            vListaSalas = value
        End Set
    End Property

    Private vListaPuntoVentas As New List(Of PuntoDeVenta)
    Public Property ListaPuntoVentas() As List(Of PuntoDeVenta)
        Get
            Return vListaPuntoVentas
        End Get
        Set(ByVal value As List(Of PuntoDeVenta))
            vListaPuntoVentas = value
        End Set
    End Property

    Public Function CantidadEntradasVendidas() As Integer
        Dim cantidad As Integer = 0
        For Each p As PuntoDeVenta In Me.ListaPuntoVentas
            cantidad = cantidad + p.CantidadVendida
        Next
        Return cantidad
    End Function

    Public Function ObtenerEstadoSalas() As String
        Dim estado As String = ""
        For Each s As Sala In Me.ListaSalas
            estado += "<ul>Sala: Numero " + s.Numero + " Piso " + s.Piso
            For Each h As Horario In s.ListaHorarios
                estado += "<li><ul>Horario: " + h.Inicio.ToString("dd/MM/yyyy HH:mm") + " - " + h.Fin.ToString("dd/MM/yyyy HH:mm") + " - " + h.Pelicula.Nombre
                Dim cantidadOcupado As Integer = 0
                Dim cantidadLibre As Integer = 0
                For Each b As Butaca In s.ListaButacas
                    b.Estado = Me.EstaVendida(s, h, b)
                    If b.Estado Then
                        estado += "<li>Butaca " + b.Codigo + " Ocupada" + "</li>"
                        cantidadOcupado += 1
                    Else
                        estado += "<li>Butaca " + b.Codigo + " Disponible" + "</li>"
                        cantidadLibre += 1
                    End If
                Next
                estado += "(Cantidad Ocupado = " + cantidadOcupado.ToString() + ", Cantidad Libre = " + cantidadLibre.ToString() + ")</ul></li>"
            Next
            estado += "</ul>"
        Next
        Return estado
    End Function

    Public Function EstaVendida(ByVal s As Sala, ByVal h As Horario, ByVal b As Butaca) As Boolean
        For Each p As PuntoDeVenta In Me.ListaPuntoVentas
            For Each e As Entrada In p.ListaEntradas
                If e.Sala.Id = s.Id And e.Horario.Id = h.Id And e.Butaca.Id = b.Id Then
                    Return True
                End If
            Next
        Next
        Return False
    End Function
End Class
