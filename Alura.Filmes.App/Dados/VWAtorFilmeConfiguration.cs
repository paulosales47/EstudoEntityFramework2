using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados
{
    public class VWAtorFilmeConfiguration : IQueryTypeConfiguration<VWAtorFilme>
    {
        public void Configure(QueryTypeBuilder<VWAtorFilme> builder)
        {
            builder
                .ToView<VWAtorFilme>("VW_TOP_ATORES_FILMES");

            builder
                .Property(vw => vw.Id).HasColumnName("actor_id");

            builder
                .Property(vw => vw.PrimeiroNome).HasColumnName("first_name");

            builder
                .Property(vw => vw.UltimoNome).HasColumnName("last_name");

            builder
                .Property(vw => vw.QuantidadeFilmesRealizados).HasColumnName("count_film");

            builder
                .Property(vw => vw.DataAlteracao).HasColumnName("last_update");

        }
    }
}
