using System.Collections.Generic;

namespace Alura.Filmes.App.Negocio
{
    public class Linguagem
    {
        public byte Id { get; set; }
        public string Nome { get; set; }
        public IList<Filme> FilmesDublados { get; set; }
        public IList<Filme> FilmesOriginais { get; set; }

        public Linguagem()
        {
            FilmesDublados = new List<Filme>();
            FilmesOriginais = new List<Filme>();
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}";
        }
    }
}
