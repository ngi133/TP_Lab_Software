using _03_Dominio.Entidades;
using _03_Dominio.Repositorios;

namespace _04_PersistenciaDeDatos
{
    public class ReservaRepositorioEnMemoria : ReservaRepositorio
    {
        private List<Reserva> reserva = new List<Reserva>();

        public List<Reserva> listar()
        {
            return this.reserva;
        }
        public void grabar(Reserva reserva)
        {
            this.reserva.Add (reserva);
        }

       
    }
}
