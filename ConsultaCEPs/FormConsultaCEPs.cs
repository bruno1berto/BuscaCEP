using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCEPs
{
    public partial class FormConsultaCEPs : Form
    {
        private const string dot = ".";

        public FormConsultaCEPs()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbCEP.Text))
            {
                using(var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txbCEP.Text.Trim());
                        txbLogradouro.Text = endereco.end;
                        txbBairro.Text = endereco.bairro;
                        txbCidade.Text = endereco.cidade;
                        txbUF.Text = endereco.uf;
                    }
                    catch(Exception err)
                    {
                        if (err.Message == "CEP INVÁLIDO")
                        {
                            MessageBox.Show("CEP inválido!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (err.Message == "CEP NAO ENCONTRADO")
                        {
                            MessageBox.Show("CEP não encontrado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string hashErr = err.GetHashCode().ToString();
                            string errMessage = err.Message;
                            string message = string.Concat("Ocorreu um erro inexperado. HashError: ", hashErr, ". ", errMessage, dot);
                            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP para a consulta.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbCEP.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbCEP.Text = string.Empty;
            txbLogradouro.Text = string.Empty;
            txbCidade.Text = string.Empty;
            txbBairro.Text = string.Empty;
            txbUF.Text = string.Empty;
            txbCEP.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
