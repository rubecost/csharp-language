using System;

namespace Aula_16___Arrays___Declarando_e_Instanciando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros_loteria; // Declaração do array
            numeros_loteria = new int[6]; // Alocando área na memória para o array

            int valor = int.Parse(Console.ReadLine());
            int[] valor2 = new int[valor]; // Alocando memória dinâmicamente com o tamanho da variável valor
        }
    }
}
