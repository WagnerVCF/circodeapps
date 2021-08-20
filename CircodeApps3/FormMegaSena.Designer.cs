
namespace CircodeApps3
{
    partial class FormMegaSena
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
            this.lbNumeros = new System.Windows.Forms.ListBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSortear = new System.Windows.Forms.Button();
            this.lblNúmeros = new System.Windows.Forms.Label();
            this.cbxJogo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbNumeros
            // 
            this.lbNumeros.BackColor = System.Drawing.Color.White;
            this.lbNumeros.ForeColor = System.Drawing.Color.Black;
            this.lbNumeros.FormattingEnabled = true;
            this.lbNumeros.Location = new System.Drawing.Point(12, 38);
            this.lbNumeros.Name = "lbNumeros";
            this.lbNumeros.Size = new System.Drawing.Size(140, 147);
            this.lbNumeros.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(177, 162);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSortear
            // 
            this.btnSortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortear.Location = new System.Drawing.Point(177, 119);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(75, 23);
            this.btnSortear.TabIndex = 2;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // lblNúmeros
            // 
            this.lblNúmeros.AutoSize = true;
            this.lblNúmeros.BackColor = System.Drawing.Color.Black;
            this.lblNúmeros.ForeColor = System.Drawing.Color.White;
            this.lblNúmeros.Location = new System.Drawing.Point(13, 13);
            this.lblNúmeros.Name = "lblNúmeros";
            this.lblNúmeros.Size = new System.Drawing.Size(100, 13);
            this.lblNúmeros.TabIndex = 3;
            this.lblNúmeros.Text = "Números Sorteados";
            // 
            // cbxJogo
            // 
            this.cbxJogo.FormattingEnabled = true;
            this.cbxJogo.Items.AddRange(new object[] {
            "Megasena",
            "Lotofácil"});
            this.cbxJogo.Location = new System.Drawing.Point(158, 38);
            this.cbxJogo.Name = "cbxJogo";
            this.cbxJogo.Size = new System.Drawing.Size(115, 21);
            this.cbxJogo.TabIndex = 4;
            // 
            // FormMegaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(281, 200);
            this.Controls.Add(this.cbxJogo);
            this.Controls.Add(this.lblNúmeros);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lbNumeros);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMegaSena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNumeros;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.Label lblNúmeros;
        private System.Windows.Forms.ComboBox cbxJogo;
    }
}