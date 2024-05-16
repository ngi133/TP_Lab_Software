using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _03_Dominio.ValueObjects
{
    public class Tarjeta

    {
        private string valor;

        public Tarjeta(string valor)
        {
            this.debeContenerTarjetaValida(valor);
            this.valor = valor;
        }
        private void debeContenerTarjetaValida(string tarjeta)
        {

        }
        public string Valor()
        {
            return this.valor;
        }
    }
}
