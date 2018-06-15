using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Negocio;
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
                        var elenco = context.FilmeAtor.ToList();

                        foreach (var filmeAtor in elenco)
                        {
                            var entidade = context.Entry(filmeAtor);
                            var filmeId = entidade.Property("film_id").CurrentValue;
                            var atorId = entidade.Property("actor_id").CurrentValue;

                            Console.WriteLine($"{filmeId} - {atorId}");
                        }

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