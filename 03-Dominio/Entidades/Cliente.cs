
using _03_Dominio.ValueObjects;

namespace _03_Dominio.Entidades
{
    public class Cliente
    {
        Identificador id;
        Nombre nombre;
        Apellido apellido;
        Email email;
        Clave clave;
        FechaNacimiento fechaNacimiento;
        Tarjeta tarjeta;

        public Cliente(Guid id, string nombre, string apellido, string email, string clave, DateTime fechaNacimiento,string tarjeta)
        {
            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.apellido = new Apellido(apellido); 
            this.email = new Email(email);
            this.clave = new Clave(clave);
            this.fechaNacimiento = new FechaNacimiento(fechaNacimiento);
            this.tarjeta = new Tarjeta(tarjeta);

        }

        public Guid Id()
        {
            return this.id.Valor();
        }
        public string Nombre()
        {
            return this.nombre.Valor();
        }
        public string Apellido()
        {
            return this.apellido.Valor();
        }
        public string Email()
        {
            return this.email.Valor();
        }
        public string Clave()
        {
            return this.clave.Valor();
        }
        public DateTime FechaNacimiento()
        {
            return this.fechaNacimiento.Valor();
        }

        public string Tarjeta()
        {
            return this.tarjeta.Valor();
        }
    }
}