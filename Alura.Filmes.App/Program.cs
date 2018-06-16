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
                        var filme = context.Filmes.First();

                        Console.WriteLine(filme);

                        filme.Classificacao = ClassificacaoIndicativa.NC17;

                        Console.WriteLine(filme);

                        context.Add(filme);
                        context.SaveChanges();
                        contextTransaction.Commit();
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