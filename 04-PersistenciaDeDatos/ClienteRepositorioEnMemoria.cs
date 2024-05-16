using _03_Dominio.Entidades;
using _03_Dominio.Repositorios;

namespace _04_PersistenciaDeDatos
{
    public class ClienteRepositorioEnMemoria : ClienteRepositorio
    {
        private List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> listar()
        {
            return this.clientes;
        }
        public void grabar(Cliente cliente)
        {
            this.clientes.Add (cliente);
        }

       
    }
}
