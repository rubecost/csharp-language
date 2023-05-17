using System;

namespace Aula_13___Estrutura_de_Repetição_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do while com int

            /*int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;

            }while(i <= 50);*/

            // --------------------------------------------------------------

            // do while com string

            int i;

            do
            {
                Console.WriteLine("Digite um número:");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine("O número digitado foi: {0}", i.ToString());

            } while (i != 10);
        }
    }
}
// OBS: ( do while ) primeiro executa o bloco de código depois avalia se é para continuar