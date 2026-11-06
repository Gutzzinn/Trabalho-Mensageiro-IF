namespace MensageiroIF.Cliente
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabConversa = new System.Windows.Forms.TabPage();
            this.tabContatos = new System.Windows.Forms.TabPage();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.lstContatos = new System.Windows.Forms.ListBox();
            this.btnAdicionarContato = new System.Windows.Forms.Button();
            this.tabPrincipal.SuspendLayout();
            this.tabConversa.SuspendLayout();
            this.tabContatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabConversa);
            this.tabPrincipal.Controls.Add(this.tabContatos);
            this.tabPrincipal.Location = new System.Drawing.Point(0, -2);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(801, 453);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabConversa
            // 
            this.tabConversa.Controls.Add(this.dgvHistorico);
            this.tabConversa.Controls.Add(this.btnEnviar);
            this.tabConversa.Controls.Add(this.txtMensagem);
            this.tabConversa.Location = new System.Drawing.Point(4, 22);
            this.tabConversa.Name = "tabConversa";
            this.tabConversa.Padding = new System.Windows.Forms.Padding(3);
            this.tabConversa.Size = new System.Drawing.Size(793, 427);
            this.tabConversa.TabIndex = 0;
            this.tabConversa.Text = "Conversa";
            this.tabConversa.UseVisualStyleBackColor = true;
            this.tabConversa.Click += new System.EventHandler(this.tabConversa_Click);
            // 
            // tabContatos
            // 
            this.tabContatos.Controls.Add(this.btnAdicionarContato);
            this.tabContatos.Controls.Add(this.lstContatos);
            this.tabContatos.Location = new System.Drawing.Point(4, 22);
            this.tabContatos.Name = "tabContatos";
            this.tabContatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabContatos.Size = new System.Drawing.Size(793, 427);
            this.tabContatos.TabIndex = 1;
            this.tabContatos.Text = "Contatos";
            this.tabContatos.UseVisualStyleBackColor = true;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(58, 57);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(333, 187);
            this.txtMensagem.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(316, 250);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Location = new System.Drawing.Point(459, 57);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.Size = new System.Drawing.Size(289, 187);
            this.dgvHistorico.TabIndex = 2;
            // 
            // lstContatos
            // 
            this.lstContatos.FormattingEnabled = true;
            this.lstContatos.Location = new System.Drawing.Point(70, 49);
            this.lstContatos.Name = "lstContatos";
            this.lstContatos.Size = new System.Drawing.Size(227, 186);
            this.lstContatos.TabIndex = 0;
            // 
            // btnAdicionarContato
            // 
            this.btnAdicionarContato.Location = new System.Drawing.Point(153, 241);
            this.btnAdicionarContato.Name = "btnAdicionarContato";
            this.btnAdicionarContato.Size = new System.Drawing.Size(144, 23);
            this.btnAdicionarContato.TabIndex = 1;
            this.btnAdicionarContato.Text = "Adicionar contato";
            this.btnAdicionarContato.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.tabPrincipal.ResumeLayout(false);
            this.tabConversa.ResumeLayout(false);
            this.tabConversa.PerformLayout();
            this.tabContatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabConversa;
        private System.Windows.Forms.TabPage tabContatos;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.ListBox lstContatos;
        private System.Windows.Forms.Button btnAdicionarContato;
    }
}