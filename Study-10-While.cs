using System;

namespace Aula_11___Estrutura_de_Repetição_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Looping while como int

            /* int i = 1;
 
             while(i <= 50)
             {
                 Console.WriteLine(i);
                 i++;
             }*/

            //--------------------------------------

            // Looping while com string

            string letra;

            Console.WriteLine("Digite uma letra: Ou \"a\" para finalizar");
            letra = Console.ReadLine(); // letra recebe string digitada

            while (letra != "a")
            {
                Console.WriteLine("Digite uma letra: Ou \"a\" para finalizar");
                letra = Console.ReadLine();
                Console.WriteLine(letra);
                
            }
        }
    }
}
