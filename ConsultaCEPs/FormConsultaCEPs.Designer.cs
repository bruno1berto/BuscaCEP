using ConsultaCEPs.Properties;
namespace ConsultaCEPs
{
    partial class FormConsultaCEPs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaCEPs));
            this.label1 = new System.Windows.Forms.Label();
            this.TxbCEP = new System.Windows.Forms.TextBox();
            this.GrbDadosCEP = new System.Windows.Forms.GroupBox();
            this.TxbUF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbLogradouro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GrbDadosCEP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP:";
            // 
            // TxbCEP
            // 
            this.TxbCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbCEP.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxbCEP.Location = new System.Drawing.Point(25, 35);
            this.TxbCEP.Name = "TxbCEP";
            this.TxbCEP.Size = new System.Drawing.Size(89, 20);
            this.TxbCEP.TabIndex = 1;
            this.TxbCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GrbDadosCEP
            // 
            this.GrbDadosCEP.Controls.Add(this.TxbUF);
            this.GrbDadosCEP.Controls.Add(this.label5);
            this.GrbDadosCEP.Controls.Add(this.TxbCidade);
            this.GrbDadosCEP.Controls.Add(this.label4);
            this.GrbDadosCEP.Controls.Add(this.TxbBairro);
            this.GrbDadosCEP.Controls.Add(this.label3);
            this.GrbDadosCEP.Controls.Add(this.TxbLogradouro);
            this.GrbDadosCEP.Controls.Add(this.label2);
            this.GrbDadosCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbDadosCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.GrbDadosCEP.Location = new System.Drawing.Point(27, 77);
            this.GrbDadosCEP.Name = "GrbDadosCEP";
            this.GrbDadosCEP.Size = new System.Drawing.Size(527, 219);
            this.GrbDadosCEP.TabIndex = 2;
            this.GrbDadosCEP.TabStop = false;
            this.GrbDadosCEP.Text = "Dados do CEP:";
            // 
            // TxbUF
            // 
            this.TxbUF.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxbUF.Enabled = false;
            this.TxbUF.Location = new System.Drawing.Point(24, 175);
            this.TxbUF.Name = "TxbUF";
            this.TxbUF.Size = new System.Drawing.Size(480, 20);
            this.TxbUF.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "UF:";
            // 
            // TxbCidade
            // 
            this.TxbCidade.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxbCidade.Enabled = false;
            this.TxbCidade.Location = new System.Drawing.Point(24, 132);
            this.TxbCidade.Name = "TxbCidade";
            this.TxbCidade.Size = new System.Drawing.Size(480, 20);
            this.TxbCidade.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cidade";
            // 
            // TxbBairro
            // 
            this.TxbBairro.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxbBairro.Enabled = false;
            this.TxbBairro.Location = new System.Drawing.Point(24, 87);
            this.TxbBairro.Name = "TxbBairro";
            this.TxbBairro.Size = new System.Drawing.Size(480, 20);
            this.TxbBairro.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bairro:";
            // 
            // TxbLogradouro
            // 
            this.TxbLogradouro.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxbLogradouro.Enabled = false;
            this.TxbLogradouro.Location = new System.Drawing.Point(24, 43);
            this.TxbLogradouro.Name = "TxbLogradouro";
            this.TxbLogradouro.Size = new System.Drawing.Size(480, 20);
            this.TxbLogradouro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Logradouro:";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackgroundImage = global::ConsultaCEPs.Properties.Resources.busca_cep;
            this.BtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultar.Location = new System.Drawing.Point(127, 13);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(193, 57);
            this.BtnConsultar.TabIndex = 3;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.Blue;
            this.BtnLimpar.Image = global::ConsultaCEPs.Properties.Resources.limpar;
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.Location = new System.Drawing.Point(413, 310);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(70, 35);
            this.BtnLimpar.TabIndex = 4;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.Color.Blue;
            this.BtnFechar.Image = global::ConsultaCEPs.Properties.Resources.sair;
            this.BtnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFechar.Location = new System.Drawing.Point(488, 310);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(67, 35);
            this.BtnFechar.TabIndex = 5;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FormConsultaCEPs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 359);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.GrbDadosCEP);
            this.Controls.Add(this.TxbCEP);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormConsultaCEPs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar CEPs (WS Correios)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrbDadosCEP.ResumeLayout(false);
            this.GrbDadosCEP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbCEP;
        private System.Windows.Forms.GroupBox GrbDadosCEP;
        private System.Windows.Forms.TextBox TxbUF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxbCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbLogradouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnFechar;
    }
}

