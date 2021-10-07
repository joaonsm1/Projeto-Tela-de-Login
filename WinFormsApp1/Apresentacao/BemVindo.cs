using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Apresentacao
{
    public partial class BemVindo : Form
    {
        public BemVindo()
        {
            InitializeComponent();
        }

        private void optionControle_Click(object sender, EventArgs e)
        {
            Controle_de_usuarios controlUser = new Controle_de_usuarios();
            controlUser.Show();

        }

        private void optionInventario_Click(object sender, EventArgs e)
        {
            Inventario invent = new Inventario();
            invent.Show();
        }

        private void optionCompra_Click(object sender, EventArgs e)
        {
            Compras compra = new Compras();
            compra.Show();
        }

        private void optionSair_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
