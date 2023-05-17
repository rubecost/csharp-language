using System;

namespace Aula_17___Arrays___Atribuição_e_leitura_de_valores
{
    internal class Program
    {
        static void Main(string[] args)
        {   // RECEBENDO VALOR DO ARRAY

            /*int[] numeros_loteria = new int[6] { 2, 23, 34, 12, 29, 44 };
            int valor;
            valor = numeros_loteria[3]; // Recebendo um valor do array de posição 3
            Console.WriteLine("O elemento é {0}", valor.ToString());*/

            //------------------------------------------------------------------------------

            // DANDO UM VALOR PARA O ARRAY EM POSIÇÃO EXPECÍFICA

            /*int[] numeros_loteria = new int[6] { 2, 23, 34, 12, 29, 44 };
            int valor = 40;
            numeros_loteria[4] = valor; // Atribuindo o conteúdo da variável valor, a posição de número 4 do array numeros_loteria
            Console.WriteLine("O elemento é {0}", numeros_loteria[4].ToString());*/

            //------------------------------------------------------------------------------

            // CAPTURANDO UM VALOR DIGITADO NO CONSOLE E ATRIBUINDO A UMA POSIÇÃO DO ARRAY

            int[] numeros_loteria = new int[6] { 2, 23, 34, 12, 29, 44 };
            int valor;
            Console.WriteLine("Digíte um número:");
            valor = int.Parse(Console.ReadLine());
            numeros_loteria[4] = valor; // Atribuindo o conteúdo da variável valor, a posição de número 4 do array numeros_loteria
            Console.WriteLine("O elemento é {0}", numeros_loteria[4].ToString());
        }
    }
}
