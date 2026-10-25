using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class ProtocoloInvalidoException : Exception
    {
        public ProtocoloInvalidoException(string msg) : base(msg) { }
    }
    public class MensagemInvalidaException : Exception
    {
        public MensagemInvalidaException(string msg) : base(msg) { }
    }
}
