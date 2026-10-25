using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho;

namespace MensageiroIF.Cliente
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            var usuario = new Usuario("ana");
            var repositorio = new RepositorioEmMemoria();
            var servico = new ServicoDeHistorico(repositorio);
            Application.Run(new FormEnvio(servico, usuario));
        }
    }
}
