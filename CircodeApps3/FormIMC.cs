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
    public partial class FormIMC : Form
    {
        public FormIMC()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIMC_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtAltura;
            txtAltura.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double peso, altura, resultado;
            if (txtAltura.Text == "" || txtPeso.Text == "")
            {
                MessageBox.Show("Não ha resultado sem valores! Por favor digite a altura e o peso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                altura = Convert.ToDouble(txtAltura.Text);
                peso = Convert.ToDouble(txtPeso.Text);
                resultado = peso / (altura * altura);
                lblIMC.Text = resultado.ToString("F");
                txtAltura.Text = "";
                txtPeso.Text = "";
                if (resultado < 18)
                {
                    MessageBox.Show("Magreza, não precisa fazer regime!", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado <= 24)
                {
                    MessageBox.Show("Normal, não precisa fazer regime!", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado <= 29)
                {
                    MessageBox.Show("Sobrepeso, você precisa se cuidar mais!", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado <= 39)
                {
                    MessageBox.Show("Obesidade, você precisa fazer regime!", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Obesidade Grave, você precisa fazer regime urgente!", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
