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
            this.txbCEP = new System.Windows.Forms.TextBox();
            this.grbDadosCEP = new System.Windows.Forms.GroupBox();
            this.txbUF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLogradouro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grbDadosCEP.SuspendLayout();
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
            // txbCEP
            // 
            this.txbCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCEP.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txbCEP.Location = new System.Drawing.Point(25, 35);
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(89, 20);
            this.txbCEP.TabIndex = 1;
            this.txbCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbDadosCEP
            // 
            this.grbDadosCEP.Controls.Add(this.txbUF);
            this.grbDadosCEP.Controls.Add(this.label5);
            this.grbDadosCEP.Controls.Add(this.txbCidade);
            this.grbDadosCEP.Controls.Add(this.label4);
            this.grbDadosCEP.Controls.Add(this.txbBairro);
            this.grbDadosCEP.Controls.Add(this.label3);
            this.grbDadosCEP.Controls.Add(this.txbLogradouro);
            this.grbDadosCEP.Controls.Add(this.label2);
            this.grbDadosCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbDadosCEP.Location = new System.Drawing.Point(27, 77);
            this.grbDadosCEP.Name = "grbDadosCEP";
            this.grbDadosCEP.Size = new System.Drawing.Size(527, 219);
            this.grbDadosCEP.TabIndex = 2;
            this.grbDadosCEP.TabStop = false;
            this.grbDadosCEP.Text = "Dados do CEP:";
            // 
            // txbUF
            // 
            this.txbUF.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txbUF.Enabled = false;
            this.txbUF.Location = new System.Drawing.Point(24, 175);
            this.txbUF.Name = "txbUF";
            this.txbUF.Size = new System.Drawing.Size(480, 20);
            this.txbUF.TabIndex = 10;
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
            // txbCidade
            // 
            this.txbCidade.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txbCidade.Enabled = false;
            this.txbCidade.Location = new System.Drawing.Point(24, 132);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(480, 20);
            this.txbCidade.TabIndex = 8;
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
            // txbBairro
            // 
            this.txbBairro.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txbBairro.Enabled = false;
            this.txbBairro.Location = new System.Drawing.Point(24, 87);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(480, 20);
            this.txbBairro.TabIndex = 6;
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
            // txbLogradouro
            // 
            this.txbLogradouro.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txbLogradouro.Enabled = false;
            this.txbLogradouro.Location = new System.Drawing.Point(24, 43);
            this.txbLogradouro.Name = "txbLogradouro";
            this.txbLogradouro.Size = new System.Drawing.Size(480, 20);
            this.txbLogradouro.TabIndex = 4;
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
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImage = global::ConsultaCEPs.Properties.Resources.busca_cep;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Location = new System.Drawing.Point(127, 13);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(193, 57);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Image = global::ConsultaCEPs.Properties.Resources.limpar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(413, 310);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(70, 35);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::ConsultaCEPs.Properties.Resources.sair;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(488, 310);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(67, 35);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormConsultaCEPs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 359);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grbDadosCEP);
            this.Controls.Add(this.txbCEP);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormConsultaCEPs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar CEPs (WS Correios)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDadosCEP.ResumeLayout(false);
            this.grbDadosCEP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCEP;
        private System.Windows.Forms.GroupBox grbDadosCEP;
        private System.Windows.Forms.TextBox txbUF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLogradouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}

