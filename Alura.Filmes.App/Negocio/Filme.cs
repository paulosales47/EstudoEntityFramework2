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
        public byte IdLinguagem { get; set; }
        public byte? IdLinguagemOriginal { get; set; }
        public short? Duracao { get; set; }
        public string Classificacao { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} " +
                   $", Titulo: {Titulo}" +
                   $", Descrição: {Descricao}" +
                   $", Ano de Lançamento: {AnoLancamento}" +
                   $", Id Linguagem: {IdLinguagem}" +
                   $", Id Linguagem Original: {IdLinguagemOriginal}" +
                   $", Duração: {Duracao}" +
                   $", Classificação: {Classificacao}" +
                   $"\n";
        }


    }
}
