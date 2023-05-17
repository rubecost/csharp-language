using System;

namespace Aula___08___Estruturas_de_Decisão_Simples_e_Composta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Condicional Simples
            /*int num1;
            int num2;
            Console.WriteLine("Digite um número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Os números são iguais.");
            }*/

            // Condicional Composto
            int num1;
            int num2;
            Console.WriteLine("Digite um número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Os números são iguais.");
            }
            else
            {
                Console.WriteLine("Os números são diferentes.");
            }
            Console.ReadLine();
        }
    }
}