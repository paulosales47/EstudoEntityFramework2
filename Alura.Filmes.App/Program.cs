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
                        var clientes = context.Clientes.ToList();

                        foreach (var cliente in clientes)
                        {
                            Console.WriteLine(cliente);
                        }

                        var funcionarios = context.Funcionarios.ToList();

                        foreach (var functionario in funcionarios)
                        {
                            Console.WriteLine(functionario);
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