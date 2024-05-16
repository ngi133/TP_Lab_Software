using _03_Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Aplicacion.DTOs
{
    public class ClienteDTO
    {
        private Guid id;
        private string nombre;
        private string apellido;
        private string email;
        private string clave;
        private DateTime fechaNacimiento;
        private string tarjeta;


        public ClienteDTO( Guid id,string nombre, string apellido, string email, string clave, DateTime fechaNacimiento, string tarjeta)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.clave = clave; 
            this.fechaNacimiento = fechaNacimiento;
            this.tarjeta = tarjeta;
        }

        public Guid Id()
        { 
            return this.id;
        }
        public string Nombre()
        {
            return this.nombre;
        }
        public string Apellido()
        {
            return this.apellido;
        }
        public string Email()
        {
            return this.email;
        }

        public string Clave()
        {
            return this.clave;
        }

        public DateTime FechaNacimiento()
        {
            return this.fechaNacimiento;
        }
        public string Tarjeta()
        {
            return this.tarjeta;
        }
    }
}
