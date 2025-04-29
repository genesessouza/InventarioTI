using InventarioTI.Connection;
using InventarioTI.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioTI.View
{
    public partial class EdicaoProduto : Form
    {
        ControleProduto _controleProduto;

        Produto _produtoAEditar;

        public EdicaoProduto()
        {
            InitializeComponent();
        }

        public EdicaoProduto(ControleProduto controleProduto, Produto produtoAEditar)
        {
            InitializeComponent();
            _controleProduto = controleProduto;

            CenterToParent();

            _ = InicializarAsync();

            _produtoAEditar = produtoAEditar;

            tBox_EdicaoProdutoDescricao.Text = produtoAEditar.Descricao;

            tBox_EdicaoProdutoPreco.Text = Produto.ConverterFormatoDePreco(produtoAEditar.Preco);
        }

        private async Task InicializarAsync()
        {
            var marcas = await Marca.BuscarMarcasAsync();
            foreach (var marca in marcas)
                cBox_EdicaoProdutoMarca.Items.Add(marca.Nome);

            var modelos = await Modelo.BuscarModelosAsync();
            foreach (var modelo in modelos)
                cBox_EdicaoProdutoModelo.Items.Add(modelo.Nome);

            var situacoes = await Situacao.BuscarSituacoesAsync();
            foreach (var situacao in situacoes)
                cBox_EdicaoProdutoSituacao.Items.Add(situacao.Valor);

            cBox_EdicaoProdutoMarca.SelectedIndex = _produtoAEditar.IdMarca;
            cBox_EdicaoProdutoModelo.SelectedIndex = _produtoAEditar.IdModelo;
            cBox_EdicaoProdutoSituacao.SelectedIndex = _produtoAEditar.IdSituacao;
        }

        private async void bttn_EditarProduto_Click(object sender, EventArgs e)
        {
            var sucesso = await Produto.EditarProdutoAsync(_produtoAEditar.Id, cBox_EdicaoProdutoMarca.SelectedIndex, cBox_EdicaoProdutoModelo.SelectedIndex,
                cBox_EdicaoProdutoSituacao.SelectedIndex, tBox_EdicaoProdutoDescricao.Text, Produto.ConverterPrecoParaDecimal(tBox_EdicaoProdutoPreco.Text));

            if (sucesso)
                MessageBox.Show("Produto editado com sucesso!", "Cadastro de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao editar produto.", "Cadastro de Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);

            await _controleProduto.InicializarAsync();
        }

        private void tBox_EdicaoProdutoPreco_MouseClick(object sender, MouseEventArgs e)
        {
            tBox_EdicaoProdutoPreco.Text = "";
        }

        private void tBox_EdicaoProdutoPreco_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tBox_EdicaoProdutoPreco.Text))
                tBox_EdicaoProdutoPreco.Text = Produto.ConverterFormatoDePreco(Convert.ToDecimal(tBox_EdicaoProdutoPreco.Text));
        }

        private void tBox_EdicaoProdutoPreco_TextChanged(object sender, EventArgs e)
        {
            tBox_EdicaoProdutoPreco.Text = Regex.Replace(tBox_EdicaoProdutoPreco.Text, "[^0-9.,]", "");
        }
    }
}