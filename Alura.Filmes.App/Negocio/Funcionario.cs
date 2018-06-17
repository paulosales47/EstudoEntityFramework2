using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
    public class Funcionario : Pessoa
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public override string ToString()
        {
            return
                base.ToString()
                + $", Login: {Login}"
                + $", Senha: {Senha}";
        }

    }
}
