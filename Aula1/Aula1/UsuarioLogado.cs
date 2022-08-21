﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
    public sealed class UsuarioLogado
    {
        static UsuarioLogado _instancia;

        public static UsuarioLogado Instancia
        {
            get { return _instancia ?? (_instancia = new UsuarioLogado()); }

        }
        private UsuarioLogado() { }
        public string Login { get; set; }



    }
}
