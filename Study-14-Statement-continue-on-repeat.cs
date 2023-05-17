using System;

namespace Aula_15____Declaração_continue_em_repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            while (true)
            {
                Console.WriteLine("Digite um número:");
                numero = int.Parse(Console.ReadLine());

                if ((numero < 10) || (numero > 20))
                    continue; // A declaração continue volta o loop while do começo.
                else
                {
                    if (numero == 15)
                    {
                        break; // break finaliza o loop while
                    }
                    Console.WriteLine("Número: {0}", numero);
                }
            }
        }
    }
}
