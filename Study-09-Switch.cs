using System;

namespace Aula_10___Declaração_Condicional_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diaSemana;
            string nome;
            Console.WriteLine("Digite o dia da semana, de 1  a  7:");
            diaSemana = int.Parse(Console.ReadLine());

            switch (diaSemana) // verificando o conteudo da variável diaSemana
            {
                // case 7:  <- Poderia adicionar outros cases. Para usar como se fosse ( ou || ou ) e dar o mesmo resultado se digitado o numero de um dos cases
                case 1: // se o conteúdo for igual a 1
                    nome = "Domingo"; // variável nome recebe a palavra Domingo
                    break; // O break sai da instrução switch
                case 2:
                    nome = "Segunda-feira";
                    break;
                case 3:
                    nome = "Terça-feira";
                    break;
                case 4:
                    nome = "Quarta-feira";
                    break;
                case 5:
                    nome = "Quinta-feira";
                    break;
                case 6:
                    nome = "Sexta-feira";
                    break;
                case 7:
                    nome = "Sábado";
                    break;
                default: // se nenhum valor for igual aos específicados nos cases acima.
                    nome = "Dia inválido!";
                    break;
            }
            Console.WriteLine("O dia escolhido foi {0}", nome); // imprime na tela
            Console.ReadLine();
        }
    }
}