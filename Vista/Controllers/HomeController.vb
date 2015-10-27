Public Class HomeController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Home

    Function Index() As ActionResult
        Dim locacion As New EE.Locacion
        locacion.Id = 1
        locacion.Nombre = "Hoyts Abasto"

        Dim sala As New EE.Sala
        sala.Id = 1
        sala.Numero = 1
        sala.Piso = 1

        locacion.ListaSalas.Add(sala)

        Dim cajero As New EE.Cajero
        cajero.Id = 1
        cajero.Nombre = "Pedro"
        cajero.Apellido = "Alvarez"
        cajero.Cargo = "Cajero"

        Dim ventanilla As New EE.Ventanilla
        ventanilla.Id = 1
        ventanilla.Numero = 1
        ventanilla.Cajero = cajero

        locacion.ListaPuntoVentas.Add(ventanilla)

        Dim pelicula As New EE.Pelicula
        pelicula.Id = 1
        pelicula.Nombre = "Lo que el viento se llevó"

        Dim butaca As New EE.Butaca
        butaca.Id = 1
        butaca.Codigo = "H10"
        butaca.Estado = False

        Dim butaca2 As New EE.Butaca
        butaca2.Id = 2
        butaca2.Codigo = "H11"
        butaca2.Estado = False

        Dim horario As New EE.Horario
        horario.Id = 1
        horario.Inicio = New DateTime(2015, 7, 26, 18, 30, 0)
        horario.Fin = New DateTime(2015, 7, 26, 20, 0, 0)
        horario.Pelicula = pelicula

        Dim pelicula2 As New EE.Pelicula
        pelicula2.Id = 2
        pelicula2.Nombre = "Actividad Paranormal 7"

        Dim horario2 As New EE.Horario
        horario2.Id = 2
        horario2.Inicio = New DateTime(2015, 8, 14, 15, 35, 0)
        horario2.Fin = New DateTime(2015, 8, 14, 17, 0, 0)
        horario2.Pelicula = pelicula2

        sala.ListaHorarios.Add(horario)
        sala.ListaHorarios.Add(horario2)
        sala.ListaButacas.Add(butaca)
        sala.ListaButacas.Add(butaca2)

        Dim entrada As New EE.Entrada
        entrada.Id = 1
        entrada.Horario = horario
        entrada.Butaca = butaca
        entrada.Sala = sala
        entrada.PuntoVenta = ventanilla

        Dim entrada2 As New EE.Entrada
        entrada2.Id = 2
        entrada2.Horario = horario
        entrada2.Butaca = butaca2
        entrada2.Sala = sala
        entrada2.PuntoVenta = ventanilla

        ventanilla.ListaEntradas.Add(entrada)
        ventanilla.ListaEntradas.Add(entrada2)

        Return View(locacion)
    End Function

    
End Class