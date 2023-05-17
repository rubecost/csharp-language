using System;

namespace Aula_42___Estruturas__structs_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horario agora; 

            agora.hora = 18; // Atribuindo valor as posições do struct
            agora.minuto = 20;
            agora.segundo = 14;

            Console.WriteLine("Horário: {0}:{1}:{2}", agora.hora, agora.minuto, agora.segundo);

        }
        struct Horario // Nome da struct
        {
            public int hora, minuto, segundo; // Conteúdo
        }
    }
}
