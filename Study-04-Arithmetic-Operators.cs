using System;

namespace Variáveis__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 11;

            Console.WriteLine("Soma " + (num1 + num2).ToString()); // Método ToString conversão implícita
            Console.WriteLine("Subtração " + (num1 - num2).ToString());
            Console.WriteLine("Multiplicação " + (num1 * num2).ToString());
            Console.WriteLine("Divisão " + (num1 / num2).ToString());
            Console.WriteLine("Módulo " + (num1 % num2).ToString());

            Console.ReadLine();
        }
    }
}
