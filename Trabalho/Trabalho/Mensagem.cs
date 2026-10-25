using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public abstract class Mensagem
    {
        internal string Remetente;
        internal DateTime Data;
        internal string Corpo;

        // "Mensagem.Exibir()" não pode declarar um corpo porque não está marcado como abstract
        // ; esperado
        public abstract void Exibir();
       
       
    }
    public class MensagemTexto : Mensagem
    {
        public override void Exibir()
        {
            Console.WriteLine($"{Remetente}: {Corpo}");
        }
    }
    public class MensagemSistema : Mensagem
    {
        internal int Prioridade;
        public override void Exibir()
        {
            Console.WriteLine($"[SISTEMA] {Corpo}");
        }
    }
    public class ProtocoloInvalidoException : Exception
    {
        public ProtocoloInvalidoException(string msg) : base(msg) {}
    }

}
