using System;

namespace Aula_26___Métodos___Modificadores_de_Acesso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            double peso;

            Animal bicho = new Animal(); // Intânciando a class animal para usa-lá no projeto. 
            idade = bicho.ObterIdade(); // Atribuindo o valor do método ( ObterIdade ), da classe ( animal ), para minha variável (idade).
            peso = bicho.ObterPeso; // Atribuindo o valor da variável ( ObterPeso ), da classe ( animal ), para minha variável ( peso ).

            Console.WriteLine("A idade é {0}", idade.ToString()); 
            Console.WriteLine("O peso é {0:F}", peso);
            // O {0:F} foi usado para a formatação correta, pois peso é double não int.

            Console.ReadLine();
        }


    }
}
