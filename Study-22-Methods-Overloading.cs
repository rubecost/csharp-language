using System;

namespace Aula_23___Métodos___Sobrecarga__Overloading_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            int num1, num2;
            Console.WriteLine("Digite um número para calcular seu quadrado:");
            num1 = int.Parse(Console.ReadLine());
            resultado = potencia(num1); // Uso do método com uma variével apenas. Ele Eleva ao quadrado.
            Console.WriteLine("O quadrado de {0} é {1}", num1, resultado);
            Console.WriteLine();
            Console.WriteLine("Digite dois números para calcular x ^ y");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            resultado = potencia(num1, num2); // Uso do método com duas variéveis. Ele calcula a potência.
            Console.WriteLine("{0} elevado a {1} é {2}", num1, num2, resultado);
        }
        public static double potencia(int valor1) // Um método dividido em duas partes com dois possíveis resultados.
        {
            return valor1 * valor1; // Elevado ao quadrado
        }
        public static double potencia(int valor1, int valor2)
        {
            return Math.Pow(valor1, valor2); // Potência primeiro número elevado ao segundo
        }

    }
}
