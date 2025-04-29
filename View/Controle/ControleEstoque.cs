using InventarioTI.Connection;
using InventarioTI.Model;
using InventarioTI.View.Cadastro;
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

namespace InventarioTI.View
{
    public partial class ControleEstoque : Form
    {
        DataTable tabelaDeQuantidades = new DataTable();

        public ControleEstoque()
        {
            InitializeComponent();

            CenterToScreen();

            tabelaDeQuantidades.Columns.Add("Id", typeof(int));
            tabelaDeQuantidades.Columns.Add("Produto", typeof(string));
            tabelaDeQuantidades.Columns.Add("Quantidade", typeof(int));

            _ = InicializarAsync();
        }

        public async Task InicializarAsync()
        {
            cBox_EstoqueSituacao.Items.Clear();
            var situacoes = await Situacao.BuscarSituacoesAsync();
            foreach (var situacao in situacoes)
                cBox_EstoqueSituacao.Items.Add(situacao.Valor);

            cBox_EstoqueProdutos.Items.Clear();
            var produtos = await Produto.BuscarProdutosAsync();
            foreach (var produto in produtos)
                cBox_EstoqueProdutos.Items.Add(produto.Descricao);

            cBox_EstoqueMarca.Items.Clear();
            var marcas = await Marca.BuscarMarcasAsync();
            foreach (var marca in marcas)
                cBox_EstoqueMarca.Items.Add(marca.Nome);

            cBox_EstoqueModelo.Items.Clear();
            var modelos = await Modelo.BuscarModelosAsync();
            foreach (var modelo in modelos)
                cBox_EstoqueModelo.Items.Add(modelo.Nome);

            await RecarregarTabelaAsync();
        }

        public async Task RecarregarTabelaAsync(Task<List<Estoque>>? estoquesTask = null)
        {
            try
            {
                tabelaDeQuantidades.Clear();

                var estoques = estoquesTask != null ? await estoquesTask : await Estoque.BuscarQuantidadesAsync();

                foreach (var estoque in estoques)
                    tabelaDeQuantidades.Rows.Add(estoque.Id, estoque.Produto, estoque.Quantidade);

                dataGrid_Quantidades.DataSource = tabelaDeQuantidades;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao recarregar quantidades: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void bttn_EstoqueFiltrar_Click(object sender, EventArgs e)
        {
            var produtoItensNulo = cBox_EstoqueProdutos.SelectedItem == null;
            var marcaItensNulo = cBox_EstoqueMarca.SelectedItem == null;
            var modeloItensNulo = cBox_EstoqueModelo.SelectedItem == null;
            var situacaoItensNulo = cBox_EstoqueSituacao.SelectedItem == null;


            if (produtoItensNulo && marcaItensNulo && modeloItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Estoque.BuscarQuantidadesPorSituacaoAsync(cBox_EstoqueSituacao.SelectedIndex));

            if (produtoItensNulo && marcaItensNulo && situacaoItensNulo && !modeloItensNulo)
                await RecarregarTabelaAsync(Estoque.BuscarQuantidadesPorModeloAsync(cBox_EstoqueModelo.SelectedIndex));

            if (produtoItensNulo && modeloItensNulo && situacaoItensNulo && !marcaItensNulo)
                await RecarregarTabelaAsync(Estoque.BuscarQuantidadesPorMarcaAsync(cBox_EstoqueMarca.SelectedIndex));

            if (modeloItensNulo && marcaItensNulo && situacaoItensNulo && !produtoItensNulo)
                await RecarregarTabelaAsync(Estoque.BuscarQuantidadesPorProdutoAsync(cBox_EstoqueProdutos.SelectedIndex));


            if (produtoItensNulo && modeloItensNulo && !marcaItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Estoque.BuscarQuantidadesPorMarcaESituacaoAsync(cBox_EstoqueMarca.SelectedIndex, cBox_EstoqueSituacao.SelectedIndex));

            if (situacaoItensNulo && produtoItensNulo && !marcaItensNulo && !modeloItensNulo)
                await RecarregarTabelaAsync(Estoque.BuscarQuantidadesPorMarcaEModeloAsync(cBox_EstoqueMarca.SelectedIndex, cBox_EstoqueModelo.SelectedIndex));

            if (modeloItensNulo && situacaoItensNulo && !produtoItensNulo && !marcaItensNulo)
                await RecarregarTabelaAsync(Estoque.BuscarQuantidadesPorProdutoEMarcaAsync(cBox_EstoqueProdutos.SelectedIndex, cBox_EstoqueMarca.SelectedIndex));

            if (produtoItensNulo && marcaItensNulo && !modeloItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Estoque.BuscarQuantidadesPorModeloESituacaoAsync(cBox_EstoqueModelo.SelectedIndex, cBox_EstoqueSituacao.SelectedIndex));

            if (marcaItensNulo && modeloItensNulo && !produtoItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Estoque.BuscarQuantidadesPorProdutoESituacaoAsync(cBox_EstoqueProdutos.SelectedIndex, cBox_EstoqueSituacao.SelectedIndex));

            if(!produtoItensNulo && !modeloItensNulo)
                await RecarregarTabelaAsync(Estoque.BuscarQuantidadesPorProdutoEModeloAsync(cBox_EstoqueProdutos.SelectedIndex, cBox_EstoqueModelo.SelectedIndex));



            if (produtoItensNulo && !marcaItensNulo && !modeloItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Estoque.BuscarQuantidadesPorMarcaModeloESituacaoAsync(cBox_EstoqueMarca.SelectedIndex,
                    cBox_EstoqueModelo.SelectedIndex, cBox_EstoqueSituacao.SelectedIndex));

            if (!produtoItensNulo && marcaItensNulo && !modeloItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Estoque.BuscarQuantidadesPorProdutoModeloESituacaoAsync(cBox_EstoqueProdutos.SelectedIndex,
                    cBox_EstoqueModelo.SelectedIndex, cBox_EstoqueSituacao.SelectedIndex));

            if (!produtoItensNulo && !marcaItensNulo && modeloItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Estoque.BuscarQuantidadesPorProdutoMarcaESituacaoAsync(cBox_EstoqueProdutos.SelectedIndex,
                    cBox_EstoqueMarca.SelectedIndex, cBox_EstoqueSituacao.SelectedIndex));



            if (!produtoItensNulo && !marcaItensNulo && !modeloItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Estoque.BuscarQuantidadesPorProdutoMarcaModeloESituacaoAsync(cBox_EstoqueProdutos.SelectedIndex,
                    cBox_EstoqueMarca.SelectedIndex, cBox_EstoqueModelo.SelectedIndex, cBox_EstoqueSituacao.SelectedIndex));

            if(produtoItensNulo && marcaItensNulo && modeloItensNulo && situacaoItensNulo)
                await RecarregarTabelaAsync();
        }

        private async void bttn_MarcaLimparFiltros_Click(object sender, EventArgs e)
        {
            cBox_EstoqueProdutos.SelectedItem = null;
            cBox_EstoqueMarca.SelectedItem = null;
            cBox_EstoqueModelo.SelectedItem = null;
            cBox_EstoqueSituacao.SelectedItem = null;
            await InicializarAsync();
        }

        private async void bttn_EstoqueAjustar_Click(object sender, EventArgs e)
        {
            var estoqueAEditar = await Estoque.ObterDadosDoEstoqueAEditarAsync(Convert.ToInt32(dataGrid_Quantidades.CurrentRow.Cells[0].Value));

            EdicaoEstoque edicaoEstoque = new EdicaoEstoque(this, estoqueAEditar);
            edicaoEstoque.TopMost = true;
            edicaoEstoque.ShowDialog();
        }
    }
}