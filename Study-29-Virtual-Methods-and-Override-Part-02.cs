using System;

namespace Aula_43___Herança___Parte_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mamifero animal = new Mamifero();
            animal.Lutar(); // Classe lutar base

            Console.WriteLine("");

            Humano homem = new Humano();
            homem.Lutar(); // Classe lutar herdada e modificada

            Console.WriteLine("");

            Gato bixano = new Gato();
            bixano.Lutar(); // Classe lutar herdada mais não modificada
        }
    }
    class Mamifero // Classe Base
    {
        public virtual void Lutar()  // O método lutar quando herdado por outras classes, pode ser modificado por ser virtual
        {
            Console.WriteLine("Mamiferos lutam entre si!");
        }
    }
    class Humano : Mamifero // Herdando classe Mamifero
    {
        public override void Lutar() // Classe lutar herdada e sendo modificada com override 
        {
            Console.WriteLine("Eu luto com armas!");
        }
    }
    class Gato : Mamifero // Herdando classe Mamifero
    {

    }
}