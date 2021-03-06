﻿using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Negocio;
using Alura.Filmes.App.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Data.SqlClient;

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
                        //var topAtores = context.VWAtorFilmes.ToList();

                        //foreach (var ator in topAtores)
                        //{
                        //    Console.WriteLine(ator);
                        //}

                        //var categ = "Action"; //36

                        //var paramCateg = new SqlParameter("category_name", categ);

                        //var paramTotal = new SqlParameter
                        //{
                        //    ParameterName = "@total_actors",
                        //    Size = 4,
                        //    Direction = System.Data.ParameterDirection.Output
                        //};

                        //        context.Database
                        //            .ExecuteSqlCommand("total_actors_from_given_category @category_name, @total_actors OUT", paramCateg, paramTotal);

                        //System.Console.WriteLine($"O total de atores na categoria {categ} é de {paramTotal.Value}.");


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