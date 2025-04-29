using InventarioTI.Connection;
using InventarioTI.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioTI.View
{
    public partial class CadastroProduto : Form
    {
        ControleProduto _controleProduto;
        private int _ultimoIdCadastrado = 0;

        public CadastroProduto()
        {
            InitializeComponent();
        }

        public CadastroProduto(ControleProduto controleProduto)
        {
            InitializeComponent();
            _controleProduto = controleProduto;

            CenterToParent();

            tBox_CadastroProdutoPreco.Text = Produto.ConverterFormatoDePreco(0);

            _ = InicializarAsync();
        }

        private async Task InicializarAsync()
        {
            var marcas = await Marca.BuscarMarcasAsync();
            foreach (var marca in marcas)
            {
                if (!cBox_CadastroProdutoMarca.Items.Contains(marca.Nome))
                    cBox_CadastroProdutoMarca.Items.Add(marca.Nome);
            }

            var modelos = await Modelo.BuscarModelosAsync();
            foreach (var modelo in modelos)
            {
                if (!cBox_CadastroProdutoModelo.Items.Contains(modelo.Nome))
                    cBox_CadastroProdutoModelo.Items.Add(modelo.Nome);
            }

            var situacoes = await Situacao.BuscarSituacoesAsync();
            foreach (var situacao in situacoes)
            {
                if (!cBox_CadastroProdutoSituacao.Items.Contains(situacao.Valor))
                    cBox_CadastroProdutoSituacao.Items.Add(situacao.Valor);
            }
        }

        private async void bttn_CadastrarProduto_Click(object sender, EventArgs e)
        {
            var produtos = await Produto.BuscarProdutosAsync();
            foreach (var produto in produtos)
                if (produto.Id > _ultimoIdCadastrado)
                    _ultimoIdCadastrado = produto.Id;

            var precoConvertido = Convert.ToDecimal(tBox_CadastroProdutoPreco.Text, System.Globalization.CultureInfo.CurrentCulture);

            var sucesso = await Produto.CadastrarProdutoAsync(_ultimoIdCadastrado + 1, cBox_CadastroProdutoMarca.SelectedIndex, cBox_CadastroProdutoModelo.SelectedIndex,
                cBox_CadastroProdutoSituacao.SelectedIndex, tBox_CadastroProdutoDescricao.Text, precoConvertido);

            if (sucesso)
            {
                MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tBox_CadastroProdutoDescricao.Clear();
                tBox_CadastroProdutoPreco.Clear();
                cBox_CadastroProdutoMarca.SelectedItem = null;
                cBox_CadastroProdutoModelo.SelectedItem = null;
                cBox_CadastroProdutoSituacao.SelectedItem = null;
            }
            else
                MessageBox.Show("Erro ao cadastrar produto.", "Cadastro de Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);

            await InicializarAsync();
            await _controleProduto.InicializarAsync();
        }

        private void tBox_CadastroProdutoPreco_MouseClick(object sender, MouseEventArgs e)
        {
            tBox_CadastroProdutoPreco.Text = "";
        }

        private void tBox_CadastroProdutoPreco_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tBox_CadastroProdutoPreco.Text))
                tBox_CadastroProdutoPreco.Text = Produto.ConverterFormatoDePreco(Convert.ToDecimal(tBox_CadastroProdutoPreco.Text));
        }

        private void tBox_CadastroProdutoPreco_TextChanged(object sender, EventArgs e)
        {
            tBox_CadastroProdutoPreco.Text = Regex.Replace(tBox_CadastroProdutoPreco.Text, "[^0-9.,]", "");
        }
    }
}