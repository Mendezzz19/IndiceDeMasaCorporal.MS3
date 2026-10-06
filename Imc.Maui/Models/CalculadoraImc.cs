using System;
using System.Collections.Generic;
using System.Text;

namespace Imc.Maui.Models
{
    public static class CalculadoraImc
    {
        public static decimal indiceDeMasaCorporal(
            decimal peso, 
            decimal estatura)
            => peso / (estatura * estatura);

        public static string EstadoNutricional(decimal imc)
        {
            if (imc < 18.5m)
                return "Peso bajo";
            else if (imc >= 18.5m && imc < 25m)
                return "Normal";
            else if (imc >= 25m && imc < 30m)
                return "Sobrepeso";
            else if (imc >= 30m && imc < 40m)
                return "Obesidad";
            else
                return "Obesidad extrema";
        }

    }
}
