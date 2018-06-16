using Alura.Filmes.App.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alura.Filmes.App.Extensions
{
    public static class ClassificaoIndicativaExtensions
    {
        private static Dictionary<string, ClassificacaoIndicativa> mapa =
        new Dictionary<string, ClassificacaoIndicativa>
        {
                {"G", ClassificacaoIndicativa.G }
                ,
                {"PG", ClassificacaoIndicativa.PG }
                ,
                {"PG-13", ClassificacaoIndicativa.PG13 }
                ,
                {"R", ClassificacaoIndicativa.R }
                ,
                {"NC-17", ClassificacaoIndicativa.NC17 }
        };
        public static string ConverteClassificacao(this ClassificacaoIndicativa valor)
        {
            return mapa.First(c => c.Value == valor).Key;
        }

        public static ClassificacaoIndicativa ConverteClassificacaoString(this string chave)
        {
            try
            {
                var classificacao = mapa.First(c => c.Key.Equals(chave)).Value;
                return classificacao;
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("O valor informado não consta dentro da lista de classificação");
            }
        }
    }
}
