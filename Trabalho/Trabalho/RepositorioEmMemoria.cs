using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class RepositorioEmMemoria : IRepositorioDeMensagens
    {
        private List<Mensagem> mensagens = new List<Mensagem>();

        public void Guardar(Mensagem m)
        {
            mensagens.Add(m);
        }

        public List<Mensagem> Listar()
        {
            return mensagens;
        }
    }
}
