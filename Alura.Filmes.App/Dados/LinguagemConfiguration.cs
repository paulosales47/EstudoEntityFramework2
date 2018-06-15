using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Alura.Filmes.App.Dados
{
    public class LinguagemConfiguration : IEntityTypeConfiguration<Linguagem>
    {
        public void Configure(EntityTypeBuilder<Linguagem> builder)
        {
            builder
                .ToTable("language");

            builder
                .Property(l => l.Id)
                .HasColumnName("language_id");

            builder
                .Property(l => l.Nome)
                .HasColumnName("name")
                .HasColumnType("char(20)")
                .IsRequired();

            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
