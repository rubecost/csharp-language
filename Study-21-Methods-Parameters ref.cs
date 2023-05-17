using System;

namespace Aula_22___Métodos___Parâmetros_ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número:");
            numero = int.Parse(Console.ReadLine());

            incrementa(ref numero); // passando uma referência ao local onde está a variável "numero"
            // Utilizando ref o conteúdo da variável "numero" é alterado.
            Console.WriteLine("O valor incrementado é: {0}", numero);

            Console.ReadLine();
        }
        static void incrementa(ref int valor)
        {
            valor++; // incrementando 1 a referência
        }
    }
}
