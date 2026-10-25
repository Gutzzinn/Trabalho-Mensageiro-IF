using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagem CriarMensagem(string linha){
                string[] linhaDiv = linha.Split('/');
                if (linhaDiv.Length < 3) {
                    throw new ProtocoloInvalidoException("Faltou Coisas");
                }
                else
                {
                    MensagemTexto m = new MensagemTexto()
                    {
                        Remetente = linhaDiv[0],
                        Data = DateTime.Parse(linhaDiv[1]),
                        Corpo = linhaDiv[2]
                    };
                    return m;
                }
            }
            string r = Console.ReadLine();
            DateTime d = DateTime.Parse(Console.ReadLine());
            string c = Console.ReadLine();
            string lnh = r + "/" + d.ToString("yyyy-MM-dd") + "/" + c;
            Mensagem msg = CriarMensagem(lnh);
            List<Mensagem> historico = new List<Mensagem>();
            historico.Add(msg);
            foreach(Mensagem m in historico)
            {
                m.Exibir();
                if(m is MensagemSistema min)
                {
                    Console.WriteLine(min.Prioridade);
                }
            }

            RepositorioEmMemoria memoria = new RepositorioEmMemoria();
            memoria.Guardar(msg);
            ServicoDeHistorico servico1 = new ServicoDeHistorico(memoria);

            Console.WriteLine("Memória: " + servico1.Resumo());

            RepositorioFalso falso = new RepositorioFalso();
            ServicoDeHistorico servico2 = new ServicoDeHistorico(falso);

            Console.WriteLine("Falso: " + servico2.Resumo());
        }
    }
}
