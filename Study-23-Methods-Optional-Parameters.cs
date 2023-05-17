using System;

namespace Aula_24___Métodos___Parâmetros_Opcionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parametro01;
            string parametro02;

            Console.WriteLine("Sem passar o parâmetro opcional");
            Console.WriteLine("Digite o parâmetro obrigatório (número): ");
            parametro01 = int.Parse(Console.ReadLine());
            ParamOpcional(parametro01);
            Console.WriteLine();

            Console.WriteLine("Passando o parâmetro opcional");
            Console.WriteLine("Digite o parâmetro obrigatório (número): ");
            parametro01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o parâmetro opcional (Texto): ");
            parametro02 = Console.ReadLine();
            ParamOpcional(parametro01, parametro02);

            Console.ReadLine();

        }
        static void ParamOpcional(int part1, string part2 = "Inserido pelo método") // Valor ( string ) definido no método ( ParamOpcional )
        // ( string part2 ) tem um valor inserido caso ela não seja preenchida posteriormente será usado esse valor padrão.
        {
            string resultado = "Parâmetro obrigatório: " + part1.ToString() + " Parâmetro opcional: " + part2;
            Console.WriteLine(resultado);
        }

    }
}
