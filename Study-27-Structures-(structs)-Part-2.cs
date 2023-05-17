using System;

namespace Aula_42___Estruturas__structs____Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horario relogio = new Horario(20, 20, 16); // Criando a variável relogio do tipo Horario e atribuindo o valor a ela

            relogio.SomaHora();

            // Console.WriteLine("Agora são: {0} horas.", relogio.HoraCompleta()); // Mostrando a método do objeto relogio do tipo Horario
        }
        struct Horario // Criação estrutura
        {
            private int hora, minuto, segundo; // Definindo valores privados por segurança
            public Horario(int h, int m, int s)
            {
                this.hora = h % 24; // Usando modulo para bloquear valores maiores do que o específicado
                this.minuto = m % 60;
                this.segundo = s % 60;
            }
            public int HoraCompleta()
            {
                int h, m, s;
                h = this.hora;
                m = this.minuto;
                s = this.segundo;

                return h; // Método horaCompleta() retornando a hora.
            }
            public void SomaHora()
            {
                string arrumaHora = this.hora.ToString() + ":" + this.minuto.ToString() + ":" + this.segundo.ToString();
                Console.WriteLine("Agora são: " + arrumaHora);
            }
        }

    }
}
