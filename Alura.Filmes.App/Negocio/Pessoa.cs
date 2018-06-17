﻿namespace Alura.Filmes.App.Negocio
{
    public class Pessoa
    {
        public byte Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}" +
                   $", Primeiro nome: {PrimeiroNome}" +
                   $", Ultimo nome: {UltimoNome}" +
                   $", Email: {Email}" +
                   $", Ativo: {Ativo}";
        }

    }
}
