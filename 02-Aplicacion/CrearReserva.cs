using _02_Aplicacion.DTOs;
using _03_Dominio.Entidades;
using _03_Dominio.Repositorios;

namespace _02_Aplicacion
{
    public class CrearReserva
    {
        private ReservaRepositorio repositorio;

        public CrearReserva(ReservaRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }   

        public void Ejecutar(ReservaDTO reservaDTO) 
        {
            this.repositorio.grabar(new Reserva(
                reservaDTO.Id(),
                reservaDTO.FechaReserva(),
                reservaDTO.EstadoReserva()
                ));
        }
    }
}
