namespace WindowsForms
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.Label();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(230, 94);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(169, 20);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(230, 158);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(169, 20);
            this.txtNumero2.TabIndex = 1;
            // 
            // txtN1
            // 
            this.txtN1.AutoSize = true;
            this.txtN1.Location = new System.Drawing.Point(152, 93);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(53, 13);
            this.txtN1.TabIndex = 2;
            this.txtN1.Text = "Numero 1";
            // 
            // txtN2
            // 
            this.txtN2.AutoSize = true;
            this.txtN2.Location = new System.Drawing.Point(157, 158);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(53, 13);
            this.txtN2.TabIndex = 3;
            this.txtN2.Text = "Numero 2";
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(188, 257);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(167, 52);
            this.btnSoma.TabIndex = 4;
            this.btnSoma.Text = "Soma";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(457, 257);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(213, 52);
            this.btnLimp.TabIndex = 5;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(796, 259);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(187, 49);
            this.BtnFechar.TabIndex = 6;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(300, 381);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(13, 13);
            this.LblResultado.TabIndex = 7;
            this.LblResultado.Text = "0";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(220, 381);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(55, 13);
            this.labelResultado.TabIndex = 8;
            this.labelResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1483, 609);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Name = "Form1";
            this.Text = "Teste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label txtN1;
        private System.Windows.Forms.Label txtN2;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label labelResultado;
    }
}

