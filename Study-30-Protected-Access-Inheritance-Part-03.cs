using System;

namespace Aula_45___Acesso_Protegido___Herança___Parte_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovel carro = new Automovel();
            carro.DadosAutomovel();
            carro.MostrarChassis();
            Console.WriteLine("Número de portas é: " + carro.portas);
        }
    }
    class Veiculo // Classe Base
    {
        // CAMPOS ------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Campo privado
        private string _chassis; // O campo chassi só acessível na propria classe veiculo pois é privado

        // Campo protegido  
        protected string _placa;  // O Campo placa só acessível na classe veiculo e nas classes derivada de veiculo           

        // Campo público
        public int portas; // O campo portas por ser publico é acessível de qualquer lugar

        // CONSTRUTOR ------------------------------------------------------------------------------------------------------------------------------------------------------------

        public Veiculo() // Método construtor atribuindo valor
        {
            this._placa = "AAA-0000"; // A palavra ( this ) faz referência aos campos da propria classe.
            this._chassis = "000000000000000000000000";
            this.portas = 4;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void MostrarChassis() // Criando esse método para acessar o valor do campo chassis que acessível somente na propria classe.
        {
            Console.WriteLine("O chassis é: {0}", this._chassis);
        }
    }
    class Automovel : Veiculo // Classe derivada da classe Veiculo. Ela herda o conteúdo da classe Veiculo
    {
        public void DadosAutomovel()
        {
            Console.WriteLine("A placa do auto é: {0}", this._placa);
        }
    }
}
// OBS: O anderline ( _ ) antes do nome da variavel é usado opcionalmente para identificar um campo privado ou protegido.

/* Boa Prática
 * Sempre declarar membros como privados
 * E somente quando for absolutamente necessário criar membros com acesso protegido
 */