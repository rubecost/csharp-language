using System;

namespace Aula_21___Métodos___Parâmetros_de_valor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número:");
            numero = int.Parse(Console.ReadLine());

            quadrado(numero); // chamando método

            Console.WriteLine("O número digítado foi: {0}", numero); // Mostrando a variável original não foi alterada

        }
        public static void quadrado(int num1) // Tipo void executa e já imprime não retorna nada.
        {
            int quad = num1 * num1;
            Console.WriteLine(quad.ToString());
        }
    }
}

