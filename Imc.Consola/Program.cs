using Imc.Models;

Console.WriteLine("Aplicacion que calcula el indice de masa corporal de una persona");
Console.WriteLine();

decimal peso  = ReadDecimal("Proporcione su peso en kilogramos:");
decimal estatura = ReadDecimal("Proporcione su estatura en metros:");


decimal imc = CalculadoraImc.IndiceDeMasaCorporal(peso, estatura);
var estadoNutricional = CalculadoraImc.EstadoNutricional(imc);
Console.WriteLine($"El indice de masa corporal de la persona es {imc:F4} ");
Console.WriteLine($"El estado nutricional de la persona es {estadoNutricional}");

static decimal ReadDecimal(string Indicacion)
{
    string entrada;
    bool entradaEsValida;
    decimal valor;

    do
    {
        Console.Write(Indicacion);
        entrada = Console.ReadLine();
        entradaEsValida = decimal.TryParse(entrada, out valor);
        if (!entradaEsValida)
        {
            Console.WriteLine("La entrada debe ser numerica");

        }
    } while (!entradaEsValida);
    return valor;
}


