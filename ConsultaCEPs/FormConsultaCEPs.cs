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

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxbCEP.Text))
            {
                using(var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(TxbCEP.Text.Trim());
                        TxbLogradouro.Text = endereco.end;
                        TxbBairro.Text = endereco.bairro;
                        TxbCidade.Text = endereco.cidade;
                        TxbUF.Text = endereco.uf;
                    }
                    catch(Exception err)
                    {
                        string numberErr = err.HResult.GetHashCode().ToString();
                        string errMessage = err.Message;
                        string message = string.Concat("Ocorreu um erro inexperado. Erro Nº: ", numberErr, ". ", errMessage, dot);
                        if (err.Message == "CEP INVÁLIDO")
                        {
                            MessageBox.Show("CEP inválido!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (err.Message == "CEP NAO ENCONTRADO")
                        {
                            MessageBox.Show("CEP não encontrado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if(err.HResult == -2146233087)
                        {
                            MessageBox.Show("Falha na comunicação com o WS dos correios. Verifique sua conexão com a internet.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP para a consulta.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxbCEP.Focus();
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxbCEP.Text = string.Empty;
            TxbLogradouro.Text = string.Empty;
            TxbCidade.Text = string.Empty;
            TxbBairro.Text = string.Empty;
            TxbUF.Text = string.Empty;
            TxbCEP.Focus();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
