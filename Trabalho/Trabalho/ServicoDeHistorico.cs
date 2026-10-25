using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class ServicoDeHistorico 
    {
        private IRepositorioDeMensagens repositorio;
        public ServicoDeHistorico(IRepositorioDeMensagens r)
        {
            repositorio = r;
        }

        public int Resumo()
        {
            return repositorio.Listar().Count;
        }

    }
}
