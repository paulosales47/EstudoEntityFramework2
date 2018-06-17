using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Negocio;
using Alura.Filmes.App.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var context = new FilmeContexto())
            {
                using (var contextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var atores = context.Atores
                            .Include(a => a.Filmes)
                            .OrderByDescending(a => a.Filmes.Count)
                            .Take(5);

                        foreach (var ator in atores)
                        {
                            Console.WriteLine(ator);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao realizar operação: {ex.Message}");
                        contextTransaction.Rollback();
                    }
                }
            }

            Console.ReadKey();
        }
    }
}