using System;

namespace Váriaveis_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 5.0;
            double b = 0.0;

            Console.WriteLine("Valor dividido por zero: " + (a / b).ToString()); // infinito
            Console.WriteLine("Zero dividido por um valor qualquer: " + (b / a).ToString()); // NaN não existe
            Console.WriteLine("Zero dividido por zero: " + (b / b).ToString()); // Resultado é 0
            Console.WriteLine("Soma de NaN com um valor qualquer, como 15: " + (15 + (b / b)).ToString()); // NaN não existe
            Console.WriteLine("Soma de infinito com um valor qualquer, como 15: " + (15 + (a / b)).ToString()); // infinito
            Console.WriteLine("Zero vezes infinito: " + (0 * (a / b)).ToString()); // NaN não existe
            Console.WriteLine("Zero vezes NaN: " + (0 * (b / b)).ToString()); // NaN não existe

            Console.ReadLine();
        } // OBS: Ordem de Precedência.. O programa ler primeiro o valor dentro dos parênteses: (), depois: * / %, e por ultimo: + - .
    }
}
