using _02_Aplicacion.DTOs;
using _03_Dominio.Entidades;
using _03_Dominio.Repositorios;

namespace _02_Aplicacion
{
    public class CrearCliente
    {
        private ClienteRepositorio repositorio;

        public CrearCliente(ClienteRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }   

        public void Ejecutar(ClienteDTO clienteDTO) 
        {
            this.repositorio.grabar(new Cliente(
                clienteDTO.Id(),
                clienteDTO.Nombre(),
                clienteDTO.Apellido(),
                clienteDTO.Email(),
                clienteDTO.Clave(),
                clienteDTO.FechaNacimiento(),
                clienteDTO.Tarjeta()
                ));
        }
    }
}
