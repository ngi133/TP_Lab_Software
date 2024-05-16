
using _03_Dominio.ValueObjects;

namespace _03_Dominio.Entidades
{
    public class Reserva
    {
        IdentificadorReserva id;
        FechaReserva fechaReserva;
        EstadoReserva estadoReserva;


        public Reserva(Guid id, DateTime fechaReserva,string estadoReserva)
        {
            this.id = new IdentificadorReserva(id);
            this.fechaReserva = new FechaReserva(fechaReserva);

        }

        public Guid Id()
        {
            return this.id.Valor();
        }

        public DateTime FechaReserva()
        {
            return this.fechaReserva.Valor();
        }

        public string EstadoReserva()
        {
            return this.estadoReserva.Valor();
        }


    }
}