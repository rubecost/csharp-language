using System;

namespace Aula_43___Herança___Parte_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mamifero animal = new Mamifero(); // Classe Base

            animal.Respirar();
            animal.Mamar();

            Humano homem = new Humano(); // instânciando e criando o objeto homem

            homem.Respirar(); // Herdou da classe Mamifero
            homem.Mamar();   // Herdou da classe Mamifero
            homem.Falar();

            Gato bixano = new Gato();
            bixano.Respirar(); // Herdou da classe Mamifero
            bixano.Mamar();   // Herdou da classe Mamifero
            bixano.Arranhar();

        }
    }
    class Mamifero // Classe Base
    {
        public void Respirar()
        {
            Console.WriteLine("Eu Respiro!");
        }
        public void Mamar()
        {
            Console.WriteLine("Eu mamo!");
        }
    }
    class Humano : Mamifero // Adicionando o ( : Mamifero ) essa classe está herdando os métodos da classe Mamifero
    {
        public void Falar()
        {
            Console.WriteLine("Eu falo!");
        }
    }
    class Gato : Mamifero // Adicionando o ( : Mamifero ) essa classe está herdando os métodos da classe Mamifero
    {
        public void Arranhar()
        {
            Console.WriteLine("Eu arranho!");
        }
    }
}
// Classes só podem herdar componentes de outras classes 
