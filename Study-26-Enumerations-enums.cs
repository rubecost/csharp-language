using System;

namespace Aula_41___Enumerações_enums___35
{
    internal class Program
    { //enum PontoCardeal {Norte = 10, Sul, Rub = Sul, Leste, Oeste}; <- Opcional que podem ser usados
        enum PontoCardeal : byte { Norte, Sul, Leste, Oeste }; // Conteúdo na chave é chamado de Literal. 
        // Por padrão o enum é do tipo int mais posso usar outros tipos para economia de memória. Ex: byte, char e outros
        static void Main(string[] args)
        {
            //PontoCardeal direcao = PontoCardeal.Norte; // adicionando a enumerração no Main

            // Console.WriteLine("Ponto cardeal: " + direcao); // Exibe conteudo da enumeração

            // Console.WriteLine("Ponto cardeal: " + (int)direcao); // Exibe posição de indice do conteudo usando (cast)

            TodosPontos(); // Chamando o Método
        }
        static void TodosPontos() // Método para exibir todo conteúdo de enumeração
        {
            PontoCardeal Ponto = PontoCardeal.Norte; // Exibe a partir do indice 0 pois Norte é o primeiro da sequencia

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Ponto);
                Ponto++;
            }
            Console.WriteLine(Ponto);
        }
    }
}
