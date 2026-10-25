using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public interface IRepositorioDeMensagens
    {
        void Guardar(Mensagem m);
        List<Mensagem> Listar();
    }
    
}
