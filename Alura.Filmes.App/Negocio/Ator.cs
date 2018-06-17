using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alura.Filmes.App.Negocio
{   
    
    public class Ator
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public IList<FilmeAtor> Filmes { get; set; }

        public Ator()
        {
            Filmes = new List<FilmeAtor>();
        }

        public override string ToString()
        {
            return $"Id: {this.Id}" +
                   $", Primeiro nome: {PrimeiroNome}" +
                   $", Ultimo nome: {UltimoNome}" +
                   $", Quantidade de filmes realizados: {Filmes.Count}";
        }
    }
}
