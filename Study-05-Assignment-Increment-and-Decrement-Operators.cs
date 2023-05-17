using System;

namespace Operadores_de_Atribuição__Incremento_e_Decremento___06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------------------------
            // OPERADORES DE ATRIBUIÇÃO

            // =, +=, -=, *=, /=
            // Atribuição normal:          num1 = num1 + num2;
            // Com operador de atribuição: num1 += num2;

            int var01;
            var01 = 50;
            Console.WriteLine("Atribuição {0} " + var01.ToString());
            var01 += 20;
            Console.WriteLine("Acumulando {0} " + var01.ToString());
            var01 *= 2;
            Console.WriteLine("Multiplicando {0} " + var01.ToString());
            //----------------------------------------------------------------------------

            //----------------------------------------------------------------------------
            // OPERADORES DE INCREMENTO E DECREMENTO

            // Incremento e Decremento Pré-fixos

            // Normal:                        variável = variável + 1   |  variável = variável - 1
            // Com Operador de Atribuição:    variável += 1             |  variável -= 1
            // Com Incremento:              ++variável
            // Com Decremento:              --variável

            // Incremento e Decremento Pós-fixos

            // Normal:                        variável = variável + 1  |  variável = variável - 1
            // Com Operador de Atribuição:    variável += 1            |  variável -= 1
            // Com Incremento:                variável++
            // Com Decremento:                variável--

            Console.WriteLine("\n");

            int contador;
            contador = 50;
            Console.WriteLine(contador.ToString());
            Console.WriteLine((++contador).ToString()); // Pré-Fixos // Adiciona 1 na variável atual // Pois Ler primeiro o operador
            Console.WriteLine(contador.ToString());

            Console.WriteLine("\n");

            contador = 50;
            Console.WriteLine(contador.ToString());
            Console.WriteLine(contador++.ToString()); // Pós-Fixos // Adiciona 1 na proxíma variável // Pois Ler primeiro a variável
            Console.WriteLine(contador.ToString());

            Console.ReadLine();
            //----------------------------------------------------------------------------
        }
    }
}