using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeApps3
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picboxConversordeMoeda_Click(object sender, EventArgs e)
        {
            FormConversorMoeda conversor = new FormConversorMoeda();
            conversor.Show();
        }

        private void picboxIMC_Click(object sender, EventArgs e)
        {
            FormIMC imc = new FormIMC();
            imc.Show();
        }

        private void picboxMegaSena_Click(object sender, EventArgs e)
        {
            FormMegaSena mega = new FormMegaSena();
            mega.Show();
        }

        private void picboxGeradordeSenha_Click(object sender, EventArgs e)
        {
            FormSenha senha = new FormSenha();
            senha.Show();
        }
    }
}
