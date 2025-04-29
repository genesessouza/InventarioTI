using InventarioTI.View.Cadastro;
using InventarioTI.View.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioTI.View.Controle
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            CenterToScreen();
        }

        private void menu_ControleMarca_Click(object sender, EventArgs e)
        {
            ControleMarca controleMarca = new ControleMarca();
            controleMarca.TopMost = true;
            controleMarca.Show();
        }

        private void menu_ControleModelo_Click(object sender, EventArgs e)
        {
            ControleModelo controleModelo = new ControleModelo();
            controleModelo.TopMost = true;
            controleModelo.Show();
        }

        private void menu_ControleProduto_Click(object sender, EventArgs e)
        {
            ControleProduto controleProduto = new ControleProduto();
            controleProduto.TopMost = true;
            controleProduto.Show();
        }

        private void menu_ControleEstoque_Click(object sender, EventArgs e)
        {
            ControleEstoque controleEstoque = new ControleEstoque();
            controleEstoque.TopMost = true;
            controleEstoque.Show();
        }

        private void menu_ControleSituacao_Click(object sender, EventArgs e)
        {
            ControleSituacao controleSituacao = new ControleSituacao();
            controleSituacao.TopMost = true;
            controleSituacao.Show();
        }
    }
}