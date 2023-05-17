using System;

namespace Método_Int32.Parse___05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String valor01 = "25";
            int num1 = Int32.Parse(valor01); // Int32.Parse converte uma String em Inteiro de 32bits
            int resultado = num1 * 2;
            Console.WriteLine("Resultado: " + resultado.ToString());
            Console.ReadLine();
        }
    }
}
