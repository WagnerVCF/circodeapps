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
    public partial class FormSenha : Form
    {
        public FormSenha()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string Letras = "abcdefghijlmnopqrstuvwxz";
            string Especial = "@#$&*!-";
            Random random = new Random();
            string Gerar = "";
            Gerar = Letras[random.Next(0, Letras.Length - 1)].ToString().ToUpper();
            Gerar += Especial[random.Next(0, Especial.Length - 1)].ToString();
            Gerar += random.Next(0, 9).ToString();
            Gerar += Letras[random.Next(0, Letras.Length - 1)].ToString().ToLower();
            Gerar += random.Next(0, 9).ToString();
            Gerar += Letras[random.Next(0, Letras.Length - 1)].ToString().ToUpper();
            Gerar += Letras[random.Next(0, Letras.Length - 1)].ToString().ToLower();
            txtSenha.Text = Gerar;
        }
    }
}
