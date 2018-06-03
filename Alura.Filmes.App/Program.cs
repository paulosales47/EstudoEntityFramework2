using Alura.Filmes.App.Dados;
using System;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new FilmeContexto())
            {
                foreach (var atores in context.Atores)
                {
                    System.Console.WriteLine(atores.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}