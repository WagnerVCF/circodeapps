
namespace CircodeApps3
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lblConversordeMoeda = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.picboxConversordeMoeda = new System.Windows.Forms.PictureBox();
            this.picboxGeradordeSenha = new System.Windows.Forms.PictureBox();
            this.lblGeradordeSenha = new System.Windows.Forms.Label();
            this.picboxIMC = new System.Windows.Forms.PictureBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.picboxPoupança = new System.Windows.Forms.PictureBox();
            this.lblPoupança = new System.Windows.Forms.Label();
            this.picboxMegaSena = new System.Windows.Forms.PictureBox();
            this.lblMegaSena = new System.Windows.Forms.Label();
            this.picboxGasolina = new System.Windows.Forms.PictureBox();
            this.lblGasolina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxConversordeMoeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGeradordeSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPoupança)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMegaSena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGasolina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConversordeMoeda
            // 
            this.lblConversordeMoeda.AutoSize = true;
            this.lblConversordeMoeda.BackColor = System.Drawing.Color.Transparent;
            this.lblConversordeMoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversordeMoeda.ForeColor = System.Drawing.Color.White;
            this.lblConversordeMoeda.Location = new System.Drawing.Point(9, 145);
            this.lblConversordeMoeda.Name = "lblConversordeMoeda";
            this.lblConversordeMoeda.Size = new System.Drawing.Size(124, 13);
            this.lblConversordeMoeda.TabIndex = 0;
            this.lblConversordeMoeda.Text = "Conversor de Moeda";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(566, 280);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(113, 40);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // picboxConversordeMoeda
            // 
            this.picboxConversordeMoeda.BackColor = System.Drawing.Color.Transparent;
            this.picboxConversordeMoeda.Image = global::CircodeApps3.Properties.Resources.conversor_moeda;
            this.picboxConversordeMoeda.Location = new System.Drawing.Point(12, 12);
            this.picboxConversordeMoeda.Name = "picboxConversordeMoeda";
            this.picboxConversordeMoeda.Size = new System.Drawing.Size(118, 130);
            this.picboxConversordeMoeda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxConversordeMoeda.TabIndex = 2;
            this.picboxConversordeMoeda.TabStop = false;
            this.picboxConversordeMoeda.Click += new System.EventHandler(this.picboxConversordeMoeda_Click);
            // 
            // picboxGeradordeSenha
            // 
            this.picboxGeradordeSenha.BackColor = System.Drawing.Color.Transparent;
            this.picboxGeradordeSenha.Image = global::CircodeApps3.Properties.Resources.gerador_senha;
            this.picboxGeradordeSenha.Location = new System.Drawing.Point(220, 12);
            this.picboxGeradordeSenha.Name = "picboxGeradordeSenha";
            this.picboxGeradordeSenha.Size = new System.Drawing.Size(118, 130);
            this.picboxGeradordeSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxGeradordeSenha.TabIndex = 4;
            this.picboxGeradordeSenha.TabStop = false;
            this.picboxGeradordeSenha.Click += new System.EventHandler(this.picboxGeradordeSenha_Click);
            // 
            // lblGeradordeSenha
            // 
            this.lblGeradordeSenha.AutoSize = true;
            this.lblGeradordeSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblGeradordeSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeradordeSenha.ForeColor = System.Drawing.Color.White;
            this.lblGeradordeSenha.Location = new System.Drawing.Point(228, 145);
            this.lblGeradordeSenha.Name = "lblGeradordeSenha";
            this.lblGeradordeSenha.Size = new System.Drawing.Size(110, 13);
            this.lblGeradordeSenha.TabIndex = 3;
            this.lblGeradordeSenha.Text = "Gerador de Senha";
            // 
            // picboxIMC
            // 
            this.picboxIMC.BackColor = System.Drawing.Color.Transparent;
            this.picboxIMC.Image = global::CircodeApps3.Properties.Resources.imc;
            this.picboxIMC.Location = new System.Drawing.Point(411, 12);
            this.picboxIMC.Name = "picboxIMC";
            this.picboxIMC.Size = new System.Drawing.Size(118, 130);
            this.picboxIMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxIMC.TabIndex = 6;
            this.picboxIMC.TabStop = false;
            this.picboxIMC.Click += new System.EventHandler(this.picboxIMC_Click);
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.BackColor = System.Drawing.Color.Transparent;
            this.lblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.ForeColor = System.Drawing.Color.White;
            this.lblIMC.Location = new System.Drawing.Point(453, 145);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(29, 13);
            this.lblIMC.TabIndex = 5;
            this.lblIMC.Text = "IMC";
            // 
            // picboxPoupança
            // 
            this.picboxPoupança.BackColor = System.Drawing.Color.Transparent;
            this.picboxPoupança.Image = global::CircodeApps3.Properties.Resources.poupanca;
            this.picboxPoupança.Location = new System.Drawing.Point(12, 190);
            this.picboxPoupança.Name = "picboxPoupança";
            this.picboxPoupança.Size = new System.Drawing.Size(118, 130);
            this.picboxPoupança.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPoupança.TabIndex = 8;
            this.picboxPoupança.TabStop = false;
            // 
            // lblPoupança
            // 
            this.lblPoupança.AutoSize = true;
            this.lblPoupança.BackColor = System.Drawing.Color.Transparent;
            this.lblPoupança.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoupança.ForeColor = System.Drawing.Color.White;
            this.lblPoupança.Location = new System.Drawing.Point(6, 323);
            this.lblPoupança.Name = "lblPoupança";
            this.lblPoupança.Size = new System.Drawing.Size(146, 13);
            this.lblPoupança.TabIndex = 7;
            this.lblPoupança.Text = "Rentabilidade Poupança";
            // 
            // picboxMegaSena
            // 
            this.picboxMegaSena.BackColor = System.Drawing.Color.Transparent;
            this.picboxMegaSena.Image = global::CircodeApps3.Properties.Resources.megasena;
            this.picboxMegaSena.Location = new System.Drawing.Point(220, 190);
            this.picboxMegaSena.Name = "picboxMegaSena";
            this.picboxMegaSena.Size = new System.Drawing.Size(118, 130);
            this.picboxMegaSena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxMegaSena.TabIndex = 10;
            this.picboxMegaSena.TabStop = false;
            this.picboxMegaSena.Click += new System.EventHandler(this.picboxMegaSena_Click);
            // 
            // lblMegaSena
            // 
            this.lblMegaSena.AutoSize = true;
            this.lblMegaSena.BackColor = System.Drawing.Color.Transparent;
            this.lblMegaSena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMegaSena.ForeColor = System.Drawing.Color.White;
            this.lblMegaSena.Location = new System.Drawing.Point(243, 323);
            this.lblMegaSena.Name = "lblMegaSena";
            this.lblMegaSena.Size = new System.Drawing.Size(71, 13);
            this.lblMegaSena.TabIndex = 9;
            this.lblMegaSena.Text = "Mega Sena";
            // 
            // picboxGasolina
            // 
            this.picboxGasolina.BackColor = System.Drawing.Color.Transparent;
            this.picboxGasolina.Image = global::CircodeApps3.Properties.Resources.media_consumo;
            this.picboxGasolina.Location = new System.Drawing.Point(411, 190);
            this.picboxGasolina.Name = "picboxGasolina";
            this.picboxGasolina.Size = new System.Drawing.Size(118, 130);
            this.picboxGasolina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxGasolina.TabIndex = 12;
            this.picboxGasolina.TabStop = false;
            // 
            // lblGasolina
            // 
            this.lblGasolina.AutoSize = true;
            this.lblGasolina.BackColor = System.Drawing.Color.Transparent;
            this.lblGasolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasolina.ForeColor = System.Drawing.Color.White;
            this.lblGasolina.Location = new System.Drawing.Point(415, 323);
            this.lblGasolina.Name = "lblGasolina";
            this.lblGasolina.Size = new System.Drawing.Size(114, 13);
            this.lblGasolina.TabIndex = 11;
            this.lblGasolina.Text = "Média de Consumo";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(691, 352);
            this.Controls.Add(this.picboxGasolina);
            this.Controls.Add(this.lblGasolina);
            this.Controls.Add(this.picboxMegaSena);
            this.Controls.Add(this.lblMegaSena);
            this.Controls.Add(this.picboxPoupança);
            this.Controls.Add(this.lblPoupança);
            this.Controls.Add(this.picboxIMC);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.picboxGeradordeSenha);
            this.Controls.Add(this.lblGeradordeSenha);
            this.Controls.Add(this.picboxConversordeMoeda);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblConversordeMoeda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circo de Apps";
            ((System.ComponentModel.ISupportInitialize)(this.picboxConversordeMoeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGeradordeSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPoupança)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMegaSena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGasolina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConversordeMoeda;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox picboxConversordeMoeda;
        private System.Windows.Forms.PictureBox picboxGeradordeSenha;
        private System.Windows.Forms.Label lblGeradordeSenha;
        private System.Windows.Forms.PictureBox picboxIMC;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.PictureBox picboxPoupança;
        private System.Windows.Forms.Label lblPoupança;
        private System.Windows.Forms.PictureBox picboxMegaSena;
        private System.Windows.Forms.Label lblMegaSena;
        private System.Windows.Forms.PictureBox picboxGasolina;
        private System.Windows.Forms.Label lblGasolina;
    }
}

