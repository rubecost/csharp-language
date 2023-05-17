using System;

namespace Aula_19___Arrays___Copiando_e_Clonando
{
    internal class Program
    {
        static void Main(string[] args)
        {  // COPIANDO CONTEÚDO COM LAÇO FOR

            int[] numeros = { 4, 8, 12, 16, 20 };
            int[] copiaNumeros = new int[numeros.Length]; // Definindo o tamanho do array "copiaNumeros" igua ao array "numeros" com Length

            for (int i = 0; i < numeros.Length; i++)
            {
                copiaNumeros[i] = numeros[i]; // Copiando elementos do array "numeros" para o array "copiaNumeros"
            }

            for (int i = 0; i < copiaNumeros.Length; i++)
            {
                Console.WriteLine(copiaNumeros[i].ToString()); // Exíbindo o conteúdo a partir da posição [0]
            }
            Console.ReadLine();
            //-----------------------------------------------------------

            // COPIANDO CONTEÚDO COM MÉTODO COPYTO
            // O método ( CopyTo ) passa o conteúdo de um array para outro a partir da posição expecíficada

           /* int[] numeros = { 3, 6, 9, 12, 15 };
            int[] copiaNumeros = new int[numeros.Length];

            numeros.CopyTo(copiaNumeros, 0); // Variável "numeros" copia seu conteúdo com método "CopyTo" na variável "copiaNumeros" a partir da posição 0 do array

            for (int i = 0; i < copiaNumeros.Length; i++)
            {
                Console.WriteLine(copiaNumeros[i]); // Exíbindo
            }
            Console.ReadLine();*/
            //-------------------------------------------------------------

            // COPIANDO CONTEÚDO COM A CLASSE ARRAY MAIS O MÉTODO COPY

           /* int[] numeros = { 3, 6, 9, 12, 15 };
            int[] copiaNumeros = new int[numeros.Length];

            Array.Copy(numeros, copiaNumeros, copiaNumeros.Length);
            // Usando a classe Array com método Copy é possível copiar o conteúdo de um array para outro...
            // Exemplo: Array.Copy( variável origem, variável destino, tamanho do conteúdo);

            for (int i = 0; i < copiaNumeros.Length; i++)
            {
                Console.WriteLine(copiaNumeros[i]); // Exíbindo
            }
            Console.ReadLine();*/
            //-------------------------------------------------------------

            // CLONANDO UM ARRAY, PARA OUTRO ARRAY, LOGO NO INÍCIO DE SUA DEFINIÇÃO COM MÉTODO CLONE

            /*int[] numeros = { 3, 6, 9, 12, 15 };
            int[] copiaNumeros = (int[])numeros.Clone(); // Clonando variável "numeros" e atribuindo seu valor a variável "copiaNumeros"
            // Usando o método casting (int[]) para converter o conteúdo para "int" pois a variável copiaNumeros é int

            for (int i = 0; i < copiaNumeros.Length; i++)
            {
                Console.WriteLine(copiaNumeros[i]); // Exíbindo
            }
            Console.ReadLine();*/
        }
    }
}
