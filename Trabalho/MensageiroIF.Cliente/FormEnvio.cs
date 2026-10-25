using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho;

namespace MensageiroIF.Cliente
{
    public partial class FormEnvio : Form
    {   
        private readonly ServicoDeHistorico servico;
        private readonly Usuario usuarioAtual;

        public FormEnvio(ServicoDeHistorico servico, Usuario usuarioAtual)
        {
            InitializeComponent();
            this.servico = servico;
            this.usuarioAtual = usuarioAtual;
        }

        private void FormEnvio_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                servico.Registrar(txtMensagem.Text, usuarioAtual);   // CHAMA 
                AtualizarHistorico();
                txtMensagem.Clear();
            }
            catch (MensagemInvalidaException ex)                  // TRATA 
            {
                MessageBox.Show(ex.Message, "Nao foi possivel enviar");
            }
        }
        private void AtualizarHistorico()
        {
            lstHistorico.Items.Clear();

            foreach (Mensagem m in servico.ObterHistorico())
                lstHistorico.Items.Add(m.ToString());
        }
    }
}
