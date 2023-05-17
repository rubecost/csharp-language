using System;

namespace Aula_25___Métodos___Argumentos_Nomeados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parametro01;
            string parametro02;

            Console.WriteLine("Digite o parâmetro número 02 (Texto) ");
            parametro02 = Console.ReadLine();
            Console.WriteLine("Digite o parâmetro número 01 (Número) ");
            parametro01 = int.Parse(Console.ReadLine());

            ParamOpcional(par2: parametro02, par1: parametro01);
            // Invertendo a ordem de chamada de exibição com ( par2 e par1 ) definidos antes do nome da string seguido por ( : ).
        }
        static void ParamOpcional(int par1, string par2 = "Inserido pelo método")
        {
            string resultado = "Parâmetro 01: " + par1.ToString() + " Parâmetro 02: " + par2;
            Console.WriteLine(resultado);
        }
    }
}
