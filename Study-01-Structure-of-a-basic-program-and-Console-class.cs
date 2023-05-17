using System; 
using System.Windows.Forms; // Class necessária para a exíbição do MessageBox

namespace Olá_Mundo 
{ 
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Olá Mundo!!!"); // Imprime uma mensagem na tela (mesmo que printf em c)
            Console.ReadLine(); // Pausa console e espera digitar enter para continuar. 
            MessageBox.Show("Aprendendo a utilizar referências"); // Exibe um caixa de mensagem
        }
    }
}
