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
                        //var filme = context.Filmes
                        //    .Include(f => f.Atores)
                        //    .ThenInclude(fa => fa.Ator)
                        //    .Include(f => f.Categorias)
                        //    .ThenInclude(fc => fc.Categoria)
                        //    .First();

                        //Console.WriteLine($"FILME: {filme.Titulo}\n");

                        //Console.WriteLine($"ATORES: \n");
                        //foreach (var ator in filme.Atores)
                        //{
                        //    Console.WriteLine(ator.Ator);
                        //}

                        //Console.WriteLine($"\nCATEGORIA: \n");
                        //foreach (var categoria in filme.Categorias)
                        //{
                        //    Console.WriteLine(categoria.Categoria);
                        //}

                        var linguagens = context.Linguagens.ToList();

                        foreach (var linguagem in linguagens)
                        {
                            Console.WriteLine(linguagem);
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