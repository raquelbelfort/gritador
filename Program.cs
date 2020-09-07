using System;

namespace gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Olá, usuário. Digite qualquer coisa, e eu o direi gritando!");
            string palavra = Console.ReadLine();
            Console.WriteLine (palavra.ToUpper());
        }
    }
}
