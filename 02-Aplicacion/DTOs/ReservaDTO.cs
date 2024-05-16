using _03_Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Aplicacion.DTOs
{
    public class ReservaDTO
    {
        private Guid id;
        private DateTime fechaReserva;
        private string estadoReserva;



        public ReservaDTO( Guid id, DateTime fechaReserva, string estadoReserva)
        {
            this.id = id;
            this.fechaReserva = fechaReserva;
            this.estadoReserva = estadoReserva;

        }

        public Guid Id()
        { 
            return this.id;
        }
 
        public DateTime FechaReserva()
        {
            return this.fechaReserva;
        }
        public string EstadoReserva()
        {
            return this.estadoReserva;
        }

    }
}
