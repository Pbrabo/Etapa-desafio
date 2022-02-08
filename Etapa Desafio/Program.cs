using System;
using Etapa_Desafio.src.Entities;

namespace Etapa_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
                Livros livro1 = new Livros("Harry Potter", 40, 50, "J. K. Rowling", "Fantasia", 300);
                Livros livro2 = new Livros("Senhor dos Anéis", 60, 30, "J. R. R. Toljien", "Fantasia", 500);
                Livros livro3 = new Livros("Java POO", 20, 50, "GFT", "Educativo", 500);

                VideoGames ps4 = new VideoGames("PS4", 1800, 100, "Sony", "Slim", false);
                VideoGames ps4Usado = new VideoGames("PS4", 1000, 7, "Sony", "Slim", true);
                VideoGames xbox = new VideoGames("XBOX", 1500, 500, "Microsoft", "One", false);

            Console.WriteLine(livro1);
            Console.WriteLine(livro2);
            Console.WriteLine(livro3);

            Console.WriteLine(ps4);
            Console.WriteLine(ps4Usado);
            Console.WriteLine(xbox);
        }
    }
}
