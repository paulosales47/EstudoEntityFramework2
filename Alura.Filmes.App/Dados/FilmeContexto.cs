using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados
{
    public class FilmeContexto: DbContext
    {
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Linguagem> Linguagens { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<FilmeAtor> FilmeAtor { get; set; }
        public DbSet<FilmeCategoria> FilmeCategoria { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database =FILME_MGT; Trusted_Connection = true;")
            .RalmsExtendFunctions();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AtorConfiguration());

            modelBuilder.ApplyConfiguration(new LinguagemConfiguration());

            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());

            modelBuilder.ApplyConfiguration(new FilmeConfiguration());

            modelBuilder.ApplyConfiguration(new FilmeAtorConfiguration());

            modelBuilder.ApplyConfiguration(new FilmeCategoriaConfiguration());
        }

    }
}
