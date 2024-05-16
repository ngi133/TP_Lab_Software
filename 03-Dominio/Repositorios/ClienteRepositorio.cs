using _03_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio.Repositorios
{
    public interface ClienteRepositorio
    {
        public  List<Cliente> listar();
        public void grabar(Cliente cliente);
    }
}
