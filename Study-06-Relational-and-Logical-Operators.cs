using System;

namespace Operadores_Relacionais_e_Lógicos___07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Testando &&
            int idade;
            bool idadeValida;
            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());  // Console.ReadLine -> captura todas as teclas digitadas entes de apertar enter. Int.Parse -> converte teclas digita para int. E por fim variavel recebe valor.
            idadeValida = (idade > 0) && (idade <= 120); // Se for maior que zero e menor que 120, o resutado é True
            Console.WriteLine(idadeValida.ToString()); // Exibe o resultado True ou False

            // Testando ||: (Pipe)
            int temperatura;
            bool temperaturaInvalida;
            Console.WriteLine("Digite a temperatura em graus Celsius para verificar se a água é sólida ou gasosa:");
            temperatura = int.Parse(Console.ReadLine());
            temperaturaInvalida = (temperatura < 0) || (temperatura > 100);
            Console.WriteLine(temperaturaInvalida.ToString());

            // Testando !
            bool valorLogico;
            valorLogico = true;
            valorLogico = !valorLogico; // Invertendo o valor lógico para false com: !
            Console.WriteLine(valorLogico.ToString());

            Console.ReadLine();
        }
    }
}
