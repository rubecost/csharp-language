using System;

namespace Variáveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20; // Declaração de variável de tipo inteiro
            bool a = true; // Declaração de variável de tipo booliano
            int y;
            y = x; // variável y recebe valor de x
            Console.WriteLine("O número é " + x.ToString()); // O método .ToString() converte os tipos para String.
            Console.WriteLine("O número é " + y.ToString());
            Console.WriteLine("E o valor Lógico é: " + a.ToString()); // O sinal de mais + é chamado de operador de concatenação porque é usado para concatenar variáveis
            Console.ReadLine(); // pausa
        }
    }
}

