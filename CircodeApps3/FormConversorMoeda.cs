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
    public partial class FormConversorMoeda : Form
    {
        public FormConversorMoeda()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double dolar, euro, libra, iene, dolarc, euroc, librac, ienec, valor;
            dolar = 5.25;
            euro = 6.19;
            libra = 7.28;
            iene = 0.048;
            valor = Convert.ToDouble(txtValor.Text);
            dolarc = valor / dolar;
            euroc = valor / euro;
            librac = valor / libra;
            ienec = valor / iene;
            lblDolar2.Text = dolarc.ToString("n2");
            lblEuro2.Text = euroc.ToString("n2");
            lblLibra2.Text = librac.ToString("n2");
            lblIen2.Text = ienec.ToString("n2");
        }

        private void FormConversorMoeda_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtValor;
            txtValor.Focus();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar !=(char)8 && e.KeyChar !=(char)44)
            {
                e.Handled = true;
            }
        }
    }
}
