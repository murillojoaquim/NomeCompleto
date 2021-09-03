using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Digite seu primeiro nome: ");
            
            string primeironome = Console.ReadLine();

            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Digite seu sobrenome: ");

            string sobrenome = Console.ReadLine();

            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Nome Completo: ");
            Console.WriteLine($"{primeironome} {sobrenome}");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Nome de Catálogo: ");
            Console.Write(sobrenome.ToUpper());
            Console.Write(", ");
            Console.WriteLine(primeironome);

            Console.ResetColor();

        }
    }
}
