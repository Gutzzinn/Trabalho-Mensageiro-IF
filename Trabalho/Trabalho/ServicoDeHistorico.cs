using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class ServicoDeHistorico
    {
        private IRepositorioDeMensagens repo;
        public ServicoDeHistorico(IRepositorioDeMensagens r)
        {
            repo = r;
        }

        public int Resumo()
        {
            return repo.Listar().Count;
        }

        public void Registrar(string texto, Usuario autor)
        {
            if (string.IsNullOrWhiteSpace(texto))
                throw new MensagemInvalidaException("A mensagem esta vazia.");

            if (texto.Length > 250)
                throw new MensagemInvalidaException("A mensagem passa de 250 caracteres.");

            repo.Guardar(new MensagemTexto(texto, autor));
        }

        public List<Mensagem> ObterHistorico()
        {
            return repo.Listar();
        }
    }
}
