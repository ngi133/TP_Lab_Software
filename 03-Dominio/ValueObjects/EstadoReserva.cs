using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio.ValueObjects 
{ 
public class EstadoReserva
    {
    private string valor;

    public EstadoReserva(string valor)
    {
        this.valor = valor;
    }

    public string Valor()
    {
        return this.valor;
    }
}
}