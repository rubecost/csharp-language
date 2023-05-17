using System;


namespace Aula_9___Estruturas_de_Decisão_Condicional_Aninhadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diaSemana;
            string nome;
            Console.WriteLine("Digite o dia da semana, de 1 a 7:");

            diaSemana = int.Parse(Console.ReadLine());

            if (diaSemana == 1)
            {
                nome = "Domingo";
            }
            else if (diaSemana == 2)
            {
                nome = "Segunda-feira";
            }
            else if (diaSemana == 3)
            {
                nome = "Terça-feira";
            }
            else if (diaSemana == 4)
            {
                nome = "Quarta-feira";
            }
            else if (diaSemana == 5)
            {
                nome = "Quinta-feira";
            }
            else if (diaSemana == 6)
            {
                nome = "Sexta-feira";
            }
            else if (diaSemana == 7)
            {
                nome = "Sabado";
            }
            else
            {
                Console.WriteLine("Dia inválido!"); // Número diferente digítado encerra programa.
                return;
            }        
            Console.WriteLine("O Dia escolhido foi {0}", nome);

            Console.ReadLine();
        }
    }
}

