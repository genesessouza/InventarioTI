using InventarioTI.Connection;
using InventarioTI.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioTI.View.Cadastro
{
    public partial class EdicaoEstoque : Form
    {
        private ControleEstoque _controleEstoque;

        public EdicaoEstoque()
        {
            InitializeComponent();

            CenterToScreen();
        }

        public EdicaoEstoque(ControleEstoque controleEstoque, Estoque estoqueAEditar)
        {
            InitializeComponent();

            CenterToScreen();
            _controleEstoque = controleEstoque;

            _ = InicializarAsync(estoqueAEditar);
        }

        private async Task InicializarAsync(Estoque estoqueAEditar)
        {
            var produtos = await Produto.BuscarProdutosAsync();
            foreach (var produto in produtos)
                cBox_EdicaoEstoqueProduto.Items.Add(produto.Descricao);

            cBox_EdicaoEstoqueProduto.SelectedIndex = estoqueAEditar.Id;
            tBox_EdicaoEstoqueQuantidade.Text = estoqueAEditar.Quantidade.ToString();
        }

        private async void bttn_EdicaoEstoqueSalvar_Click(object sender, EventArgs e)
        {
            var quantidade = Convert.ToInt32(tBox_EdicaoEstoqueQuantidade.Text);

            var sucesso = await Estoque.EditarEstoqueAsync(cBox_EdicaoEstoqueProduto.SelectedIndex, quantidade);
            if (sucesso)
                MessageBox.Show("Estoque editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao editar estoque!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            await _controleEstoque.InicializarAsync();
        }
    }
}