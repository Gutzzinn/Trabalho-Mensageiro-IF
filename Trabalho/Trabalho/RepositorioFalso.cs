using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class RepositorioFalso : IRepositorioDeMensagens
    {
        public int QuantidadeRecebida = 0;

        public void Guardar(Mensagem m)
        {
            QuantidadeRecebida++;
        }

        public List<Mensagem> Listar()
        {
            List<Mensagem> mensagens = new List<Mensagem>();
     
            mensagens.Add(new MensagemTexto());
            mensagens.Add(new MensagemSistema());

            return mensagens;
        }
    }
}
