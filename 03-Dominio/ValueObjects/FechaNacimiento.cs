﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio.ValueObjects 
{ 
public class FechaNacimiento
    {
    private DateTime valor;

    public FechaNacimiento(DateTime valor)
    {
        this.debeSerMayorA18Anios(valor);
        this.valor = valor;
    }
    private void debeSerMayorA18Anios(DateTime nombre)
    {
        
    }
    public DateTime Valor()
    {
        return this.valor;
    }
}
}