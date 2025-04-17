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

            CenterToScreen();
        }

        private void menu_ControleMarca_Click(object sender, EventArgs e)
        {
            ControleMarca controleMarca = new ControleMarca();
            controleMarca.Show();
        }

        private void menu_ControleModelo_Click(object sender, EventArgs e)
        {
            ControleModelo controleModelo = new ControleModelo();
            controleModelo.Show();
        }

        private void menu_ControleProduto_Click(object sender, EventArgs e)
        {
            ControleProduto controleProduto = new ControleProduto();
            controleProduto.Show();
        }

        private void menu_ControleEstoque_Click(object sender, EventArgs e)
        {
            ControleEstoque controleEstoque = new ControleEstoque();
            controleEstoque.Show();
        }

        private void menu_ControleSituacao_Click(object sender, EventArgs e)
        {
            ControleSituacao controleSituacao = new ControleSituacao();
            controleSituacao.Show();
        }
    }
}