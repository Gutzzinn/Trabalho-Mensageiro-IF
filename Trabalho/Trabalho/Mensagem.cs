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
        internal Usuario user;

        // "Mensagem.Exibir()" não pode declarar um corpo porque não está marcado como abstract
        // ; esperado
        public abstract void Exibir();
       
       
    }
    public class MensagemTexto : Mensagem
    {
        public MensagemTexto() { }
        public MensagemTexto(string c, Usuario r)
        {
            user = r;
            Corpo = c;
        }
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
