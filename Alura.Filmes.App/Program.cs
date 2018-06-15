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
                        var atores = context.Atores
                            .OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
                            .Take(10);

                        foreach (var ator in atores)
                        {
                            Console.WriteLine(ator + " -  "+ context.Entry(ator).Property("last_update").CurrentValue);
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