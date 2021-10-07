using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Modelo;


namespace WinFormsApp1.Apresentacao
{
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            CadastreSe c = new CadastreSe();
            Controle controle = new Controle();
           String mensagem = controle.cadastrar(txbLogin.Text, txbSenha.Text, txbConfirmSenha.Text);
            if (controle.tem)//mesagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show(controle.mensagem);//mensagem de erro
            }

            

        }
    }
}
