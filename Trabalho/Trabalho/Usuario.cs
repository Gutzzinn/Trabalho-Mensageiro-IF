using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Usuario
    {
        public Usuario(string nome)
        {
            Apelido = nome;
        }
        public string Apelido;
        public override bool Equals(object obj)
        {
            if (obj is Usuario outro)
                return this.Apelido == outro.Apelido;
            return false;
        }
        public override int GetHashCode()
        {
            return Apelido.GetHashCode();
        }
    }
}
