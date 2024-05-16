using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio.ValueObjects 
{ 
public class IdentificadorReserva

{
    private Guid valor;

    public IdentificadorReserva(Guid valor)
    {
       this.valor = valor;
    }
    public Guid Valor()
    {
        return this.valor;
    }
}
}