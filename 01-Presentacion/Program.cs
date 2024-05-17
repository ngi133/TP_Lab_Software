// See https://aka.ms/new-console-template for more information
using _02_Aplicacion;
using _02_Aplicacion.DTOs;
using _04_PersistenciaDeDatos;


ClienteDTO eduardo = new ClienteDTO(
    Guid.NewGuid(),
    "Eduardo",
    "Arizza",
    "edu@test.com",
    "123",
     DateTime.Parse("7/11/2002 16:14:44"),  //Fecha valida Realiza Reserva
     //DateTime.Parse("7/11/2008 16:14:44"),  Fecha Invalida Rompe todo
     "1234567890123"     //Cambiar despues a int
 );
CrearCliente casoDeUsoCrearCliente = new CrearCliente(new ClienteRepositorioEnMemoria());
casoDeUsoCrearCliente.Ejecutar(eduardo);


ReservaDTO eduardoReserva = new ReservaDTO(
    Guid.NewGuid(),
    DateTime.Now,
    "Activo"
 );
CrearReserva casoDeUsoCrearReserva = new CrearReserva(new ReservaRepositorioEnMemoria());
casoDeUsoCrearReserva.Ejecutar(eduardoReserva);

Console.WriteLine("Usted realizo una reserva el dia:"); 
Console.WriteLine(eduardoReserva.FechaReserva());
Console.WriteLine(eduardo.Nombre());
Console.WriteLine(eduardo.Apellido());
Console.WriteLine(">>>>>>>> MUCHAS GRACIAS <<<<<<<< ");