using Alura.Filmes.App.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string AnoLancamento { get; set; }
        public Linguagem LinguagemDublada { get; set; }
        public Linguagem LinguagemOriginal { get; set; }
        public short? Duracao { get; set; }
        public ClassificacaoIndicativa Classificacao
        {
            get { return TextoClassificacao.ConverteClassificacaoString(); }
            set { TextoClassificacao = value.ConverteClassificacao();  }
        }
        public string TextoClassificacao { get; private set; }
        public IList<FilmeAtor> Atores { get; set; }
        public IList<FilmeCategoria> Categorias { get; set; }

        public Filme()
        {
            Atores = new List<FilmeAtor>();
            Categorias = new List<FilmeCategoria>();
        }

        public override string ToString()
        {
            return $"Id: {Id} " +
                   $", Titulo: {Titulo}" +
                   $", Descrição: {Descricao}" +
                   $", Ano de Lançamento: {AnoLancamento}" +
                   $", Duração: {Duracao}" +
                   $", Classificação: {TextoClassificacao}" +
                   $"\n";
        }


    }
}
