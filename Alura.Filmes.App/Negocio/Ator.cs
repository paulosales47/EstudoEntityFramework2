using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alura.Filmes.App.Negocio
{   
    
    public class Ator
    {
        public int Id { get; set; }

        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }

        public override string ToString()
        {
            return $"ID: {this.Id}, PRIMEIRO NOME: {this.PrimeiroNome}, ULTIMO NOME: {this.UltimoNome}";
        }
    }
}
