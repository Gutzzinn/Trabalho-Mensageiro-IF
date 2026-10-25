using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    internal class Usuario
    {
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
