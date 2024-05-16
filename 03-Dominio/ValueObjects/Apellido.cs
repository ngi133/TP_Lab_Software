using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _03_Dominio.ValueObjects
{
    public class Apellido

    {
        private string valor;

        public Apellido(string valor)
        {
            this.debeContenerApellido(valor);
            this.valor = valor;
        }
        private void debeContenerApellido(string apellido)
        {
            if (apellido == "")
            {
                throw new Exception("El apellido no debe ser vacio");
            }
        }
        public string Valor()
        {
            return this.valor;
        }
    }
}
