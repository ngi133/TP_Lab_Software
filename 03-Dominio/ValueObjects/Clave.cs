using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _03_Dominio.ValueObjects
{
    public class Clave

    {
        private string valor;

        public Clave(string valor)
        {
            this.debeContenerClaveValida(valor);
            this.valor = valor;
        }
        private void debeContenerClaveValida(string clave)
        {
            
        }
        public string Valor()
        {
            return this.valor; 
        }
    }
}
