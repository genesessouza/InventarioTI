using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioTI.View
{
    public partial class ControleEstoque : Form
    {
        public ControleEstoque()
        {
            InitializeComponent();

            CenterToScreen();

            cBox_EstoqueSituacao.Items.Insert(0, "Inativo");
            cBox_EstoqueSituacao.Items.Insert(1, "Ativo");
            cBox_EstoqueSituacao.SelectedIndex = 1;
        }

        private void bttn_MarcaFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}