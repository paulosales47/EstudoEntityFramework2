﻿// <auto-generated />
using System;
using Alura.Filmes.App.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Alura.Filmes.App.Migrations
{
    [DbContext(typeof(FilmeContexto))]
    [Migration("20180615180418_FilmeAtorFilmeCategoria")]
    partial class FilmeAtorFilmeCategoria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Alura.Filmes.App.Negocio.Ator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("actor_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PrimeiroNome")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("varchar(45)");

                    b.Property<string>("UltimoNome")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("varchar(45)");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.ToTable("actor");
                });

            modelBuilder.Entity("Alura.Filmes.App.Negocio.Categoria", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnName("category_id");

                    b.Property<string>("Nome")
                        .HasColumnName("name")
                        .HasColumnType("varchar(25)");

                    b.Property<DateTime>("last_update")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("Alura.Filmes.App.Negocio.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("film_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnoLancamento")
                        .HasColumnName("release_year")
                        .HasColumnType("varchar(4)");

                    b.Property<string>("Classificacao")
                        .HasColumnName("rating")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descricao")
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<short?>("Duracao")
                        .HasColumnName("length");

                    b.Property<byte>("IdLinguagem")
                        .HasColumnName("language_id");

                    b.Property<byte?>("IdLinguagemOriginal")
                        .HasColumnName("original_language_id");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.ToTable("film");
                });

            modelBuilder.Entity("Alura.Filmes.App.Negocio.FilmeAtor", b =>
                {
                    b.Property<int>("actor_id");

                    b.Property<int>("film_id");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("actor_id", "film_id");

                    b.HasIndex("film_id");

                    b.ToTable("film_actor");
                });

            modelBuilder.Entity("Alura.Filmes.App.Negocio.FilmeCategoria", b =>
                {
                    b.Property<int>("film_id");

                    b.Property<byte>("category_id");

                    b.Property<DateTime>("last_update")
                        .HasColumnType("datetime");

                    b.HasKey("film_id", "category_id");

                    b.HasIndex("category_id");

                    b.ToTable("film_category");
                });

            modelBuilder.Entity("Alura.Filmes.App.Negocio.FilmeAtor", b =>
                {
                    b.HasOne("Alura.Filmes.App.Negocio.Ator", "Ator")
                        .WithMany("Filmes")
                        .HasForeignKey("actor_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Alura.Filmes.App.Negocio.Filme", "Filme")
                        .WithMany("Atores")
                        .HasForeignKey("film_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Alura.Filmes.App.Negocio.FilmeCategoria", b =>
                {
                    b.HasOne("Alura.Filmes.App.Negocio.Categoria", "Categoria")
                        .WithMany("Filmes")
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Alura.Filmes.App.Negocio.Filme", "Filme")
                        .WithMany("Categorias")
                        .HasForeignKey("film_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
