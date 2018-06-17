using System;

namespace Alura.Filmes.App.Negocio
{
    public class VWAtorFilme 
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public int QuantidadeFilmesRealizados { get; set; }
        public DateTime DataAlteracao { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id}" +
                   $", Primeiro nome: {PrimeiroNome}" +
                   $", Ultimo nome: {UltimoNome}" +
                   $", Quantidade de filmes realizados: {QuantidadeFilmesRealizados}";
        }
    }
}
