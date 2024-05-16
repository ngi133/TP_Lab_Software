using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _03_Dominio.ValueObjects
{
    public class Nombre

    {
        private string valor;

        public Nombre(string valor)
        {
            this.debeContenerNombre(valor);
            this.valor = valor;
        }
        private void debeContenerNombre(string nombre)
        {
            if (nombre == "")
            {
                throw new Exception("El nombre no debe ser vacio");
            }
        }
        public string Valor()
        {
            return this.valor; 
        }
    }
}
