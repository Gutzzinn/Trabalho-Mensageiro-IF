using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Mensagem
    {
        internal string Remetente;
        internal DateTime Data;
        internal string Corpo;

        public virtual void Exibir()
        {
            Console.WriteLine($"{Remetente}: {Corpo}");
        }
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
    // public class MensagemArquivo : Mensagem { }

}
