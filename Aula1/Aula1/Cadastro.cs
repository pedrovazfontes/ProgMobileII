using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
    public sealed class Cadastro
    {

        static Cadastro _instancia2;
        public static Cadastro Instancia2
        {
            get { return _instancia2 ?? (_instancia2 = new Cadastro()); }

        }
        private Cadastro() { }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }

    }

}
