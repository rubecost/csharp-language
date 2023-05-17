using System;

namespace Aula_14___Declaração_break_em_estruturas_de_repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            while (true) // while irá executar em quanto for verdadeiro
            {
                Console.WriteLine("Digite um número; número 15 encerra o loop");
                numero = int.Parse(Console.ReadLine());
                if (numero == 15)
                {
                    break; // break finaliza o loop.
                }
                Console.WriteLine("Número digitado {0}", numero.ToString());
            }
            Console.WriteLine("Essa mensagem aparece após o encerramento do loop");

            Console.ReadLine();
        }
    }
}

