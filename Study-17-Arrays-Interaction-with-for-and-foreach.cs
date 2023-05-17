using System;

namespace Aula_18___Arrays___Iteração_com_for_e_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {  // EXIBINDO O CONTEÚDO ARRAY COM FOR E LENGTH

            int[] meuarray = { 2, 4, 6, 3, 5, 9 };

            for (int i = 0; i < meuarray.Length; i++) // Uso de Length
            {
                Console.WriteLine(meuarray[i]);
            }
			Console.ReadLine();

            //----------------------------------------------------------

            // CAPTURANDO VALOR DIGITADO NO CONSOLE E ATRIBUINDO A TODAS AS POSIÇÕES DO ARRAY COM FOR

            /*int[] meuarray = new int[5];

            for (int i = 0; i < meuarray.Length; i++)
            {
                Console.WriteLine("Digíte um número:");
                meuarray[i] = Convert.ToInt32(Console.ReadLine()); // ( Convert.ToInt32 ) converte o valor recebido para int, e da a meuarray
            }

            for (int i = 0; i < meuarray.Length; i++)
            {
                Console.WriteLine("Posição {0}: {1}", i, meuarray[i]);
            }
			
			Console.ReadLine();*/

            //----------------------------------------------------------

            // USANDO LAÇO FOREACH PARA EXIBIR CONTEÚDO DO ARRAY

            /*int[] meuarray = { 2, 4, 6, 3, 5, 9 };

            foreach (int elemento in meuarray) // foreach é usado somente para exíbir o conteúdo pois não é possível usa-lo para alterar
            {
                Console.WriteLine(elemento.ToString());
            }
			Console.ReadLine();
			*/
        }
    }
}
// OBS: (int.Parse) e (Convert.ToInt32) são dois métodos para converter uma string em um número inteiro.
// A principal diferença é que passar um valor nulo para (int.Parse) lançará um ArgumentNullException enquanto
// passar um valor nulo para (Convert.ToInt32) será zero.
