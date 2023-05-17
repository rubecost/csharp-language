using System;

namespace Aula_20___Métodos___Declarando_e_Invocando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma;
            int valor1;
            int valor2;
            Console.WriteLine("Digite um número:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            valor2 = int.Parse(Console.ReadLine());
            soma = SomaNumeros(valor1, valor2);
            Console.WriteLine("A soma é: {0}", soma.ToString());

            Console.ReadLine();
        }
        static int SomaNumeros(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
        
    }
}