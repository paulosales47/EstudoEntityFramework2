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
            //using (var context = new FilmeContexto())
            //{
            //    foreach (var atores in context.Atores)
            //    {
            //        System.Console.WriteLine(atores.ToString());
            //    }
            //}

            using (var context = new FilmeContexto())
            {
                using (var contextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var ator = new Ator
                        {
                            PrimeiroNome = "Paulo Henrique"
                            ,
                            UltimoNome = "Sales Sampaio"
                        };

                        context.Entry(ator).Property("last_update").CurrentValue = DateTime.Now;

                        context.Atores.Add(ator);

                        context.SaveChanges();

                        contextTransaction.Commit();

                        Console.WriteLine("Registro salvo com sucesso");
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