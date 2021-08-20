
namespace CircodeApps3
{
    partial class FormConversorMoeda
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
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblDolar2 = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblEuro2 = new System.Windows.Forms.Label();
            this.lblLibra = new System.Windows.Forms.Label();
            this.lblLibra2 = new System.Windows.Forms.Label();
            this.lblIen = new System.Windows.Forms.Label();
            this.lblIen2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(185, 24);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 0;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(14, 11);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(94, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Digite um valor R$";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(16, 27);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(145, 20);
            this.txtValor.TabIndex = 2;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.ForeColor = System.Drawing.Color.White;
            this.lblDolar.Location = new System.Drawing.Point(26, 95);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(35, 13);
            this.lblDolar.TabIndex = 3;
            this.lblDolar.Text = "Dólar:";
            // 
            // lblDolar2
            // 
            this.lblDolar2.AutoSize = true;
            this.lblDolar2.Location = new System.Drawing.Point(115, 95);
            this.lblDolar2.Name = "lblDolar2";
            this.lblDolar2.Size = new System.Drawing.Size(0, 13);
            this.lblDolar2.TabIndex = 4;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.ForeColor = System.Drawing.Color.White;
            this.lblEuro.Location = new System.Drawing.Point(26, 132);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(32, 13);
            this.lblEuro.TabIndex = 5;
            this.lblEuro.Text = "Euro:";
            // 
            // lblEuro2
            // 
            this.lblEuro2.AutoSize = true;
            this.lblEuro2.Location = new System.Drawing.Point(115, 132);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(0, 13);
            this.lblEuro2.TabIndex = 6;
            // 
            // lblLibra
            // 
            this.lblLibra.AutoSize = true;
            this.lblLibra.ForeColor = System.Drawing.Color.White;
            this.lblLibra.Location = new System.Drawing.Point(26, 178);
            this.lblLibra.Name = "lblLibra";
            this.lblLibra.Size = new System.Drawing.Size(33, 13);
            this.lblLibra.TabIndex = 7;
            this.lblLibra.Text = "Libra:";
            // 
            // lblLibra2
            // 
            this.lblLibra2.AutoSize = true;
            this.lblLibra2.Location = new System.Drawing.Point(115, 178);
            this.lblLibra2.Name = "lblLibra2";
            this.lblLibra2.Size = new System.Drawing.Size(0, 13);
            this.lblLibra2.TabIndex = 8;
            // 
            // lblIen
            // 
            this.lblIen.AutoSize = true;
            this.lblIen.ForeColor = System.Drawing.Color.White;
            this.lblIen.Location = new System.Drawing.Point(26, 220);
            this.lblIen.Name = "lblIen";
            this.lblIen.Size = new System.Drawing.Size(31, 13);
            this.lblIen.TabIndex = 9;
            this.lblIen.Text = "Iene:";
            // 
            // lblIen2
            // 
            this.lblIen2.AutoSize = true;
            this.lblIen2.Location = new System.Drawing.Point(115, 220);
            this.lblIen2.Name = "lblIen2";
            this.lblIen2.Size = new System.Drawing.Size(0, 13);
            this.lblIen2.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(185, 58);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormConversorMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(285, 255);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblIen2);
            this.Controls.Add(this.lblIen);
            this.Controls.Add(this.lblLibra2);
            this.Controls.Add(this.lblLibra);
            this.Controls.Add(this.lblEuro2);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblDolar2);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnConverter);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConversorMoeda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Moeda";
            this.Load += new System.EventHandler(this.FormConversorMoeda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblDolar2;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblEuro2;
        private System.Windows.Forms.Label lblLibra;
        private System.Windows.Forms.Label lblLibra2;
        private System.Windows.Forms.Label lblIen;
        private System.Windows.Forms.Label lblIen2;
        private System.Windows.Forms.Button btnSair;
    }
}