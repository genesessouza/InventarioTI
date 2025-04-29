using InventarioTI.Model;
using InventarioTI.Connection;
using System.Data;
using System.Collections.Generic;
using InventarioTI.View;
using Microsoft.Data.SqlClient;

namespace InventarioTI
{
    public partial class ControleProduto : Form
    {
        DataTable _tabelaProdutos = new DataTable();

        public ControleProduto()
        {
            InitializeComponent();

            CenterToScreen();

            _tabelaProdutos.Columns.Add("Id");
            _tabelaProdutos.Columns.Add("Descrição");
            _tabelaProdutos.Columns.Add("Marca");
            _tabelaProdutos.Columns.Add("Modelo");
            _tabelaProdutos.Columns.Add("Preço");

            _ = InicializarAsync();
        }

        public async Task InicializarAsync()
        {
            cBox_ProdutoSelecao.Items.Clear();
            var selecao = await Produto.BuscarProdutosAsync();
            foreach (var selecaoItem in selecao)
                cBox_ProdutoSelecao.Items.Add(selecaoItem.Descricao);

            cBox_ProdutoMarca.Items.Clear();
            var marcas = await Marca.BuscarMarcasAsync();
            foreach (var marca in marcas)
                cBox_ProdutoMarca.Items.Add(marca.Nome);

            cBox_ProdutoModelo.Items.Clear();
            var modelos = await Modelo.BuscarModelosAsync();
            foreach (var modelo in modelos)
                cBox_ProdutoModelo.Items.Add(modelo.Nome);

            cBox_ProdutoSituacao.Items.Clear();
            var situacoes = await Situacao.BuscarSituacoesAsync();
            foreach (var situacao in situacoes)
                cBox_ProdutoSituacao.Items.Add(situacao.Valor);

            await RecarregarTabelaAsync();
        }

        public async Task RecarregarTabelaAsync(Task<List<Produto>>? produtosTask = null)
        {
            try
            {
                _tabelaProdutos.Clear();

                var produtos = produtosTask != null ? await produtosTask : await Produto.BuscarProdutosAsync();

                foreach (var produto in produtos)
                    _tabelaProdutos.Rows.Add(produto.Id, produto.Descricao, produto.Marca,
                        produto.Modelo, Produto.ConverterFormatoDePreco(produto.Preco));

                dataGrid_Produtos.DataSource = _tabelaProdutos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao recarregar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGrid_Produtos.Columns["Preço"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void bttn_Inserir_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastrarProduto = new CadastroProduto(this);
            cadastrarProduto.TopMost = true;
            cadastrarProduto.Show();
        }

        private async void bttn_Editar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGrid_Produtos.SelectedRows[0].Cells["Id"].Value.ToString());
            var produtoSelecionado = await Produto.ObterDadosDoProdutoSelecionadoAsync(id);

            EdicaoProduto editarProduto = new EdicaoProduto(this, produtoSelecionado);
            editarProduto.TopMost = true;
            editarProduto.Show();
        }

        private async void bttn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult desejaExcluir =
                MessageBox.Show("Deseja realmente excluir o produto selecionado?", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (desejaExcluir == DialogResult.Yes)
            {
                await Produto.ExcluirProdutoAsync(Convert.ToInt32(dataGrid_Produtos.SelectedRows[0].Cells["Id"].Value.ToString()));
                await InicializarAsync();
            }
        }

        private async void bttn_Filtrar_Click(object sender, EventArgs e)
        {
            var produtoItensNulo = cBox_ProdutoSelecao.SelectedItem == null;
            var marcaItensNulo = cBox_ProdutoMarca.SelectedItem == null;
            var modeloItensNulo = cBox_ProdutoModelo.SelectedItem == null;
            var situacaoItensNulo = cBox_ProdutoSituacao.SelectedItem == null;


            if (produtoItensNulo && marcaItensNulo && modeloItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorSituacaoAsync(cBox_ProdutoSituacao.SelectedIndex));

            if (produtoItensNulo && marcaItensNulo && situacaoItensNulo && !modeloItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorModeloAsync(cBox_ProdutoModelo.SelectedIndex));

            if (produtoItensNulo && modeloItensNulo && situacaoItensNulo && !marcaItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorMarcaAsync(cBox_ProdutoMarca.SelectedIndex));

            if (modeloItensNulo && marcaItensNulo && situacaoItensNulo && !produtoItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorProdutoAsync(cBox_ProdutoSelecao.SelectedIndex));


            if (produtoItensNulo && modeloItensNulo && !marcaItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorMarcaESituacaoAsync(cBox_ProdutoMarca.SelectedIndex, cBox_ProdutoSituacao.SelectedIndex));

            if (situacaoItensNulo && produtoItensNulo && !marcaItensNulo && !modeloItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorMarcaEModeloAsync(cBox_ProdutoMarca.SelectedIndex, cBox_ProdutoModelo.SelectedIndex));

            if (modeloItensNulo && situacaoItensNulo && !produtoItensNulo && !marcaItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorProdutoEMarcaAsync(cBox_ProdutoSelecao.SelectedIndex, cBox_ProdutoMarca.SelectedIndex));

            if (produtoItensNulo && marcaItensNulo && !modeloItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorModeloESituacaoAsync(cBox_ProdutoModelo.SelectedIndex, cBox_ProdutoSituacao.SelectedIndex));

            if (marcaItensNulo && modeloItensNulo && !produtoItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorProdutoESituacaoAsync(cBox_ProdutoSelecao.SelectedIndex, cBox_ProdutoSituacao.SelectedIndex));

            if (marcaItensNulo && situacaoItensNulo && !produtoItensNulo && !modeloItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorProdutoEModeloAsync(cBox_ProdutoSelecao.SelectedIndex, cBox_ProdutoModelo.SelectedIndex));



            if (produtoItensNulo && !marcaItensNulo && !modeloItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorMarcaModeloESituacaoAsync(cBox_ProdutoMarca.SelectedIndex,
                    cBox_ProdutoModelo.SelectedIndex, cBox_ProdutoSituacao.SelectedIndex));

            if (marcaItensNulo && !produtoItensNulo && !modeloItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorProdutoModeloESituacaoAsync(cBox_ProdutoSelecao.SelectedIndex,
                    cBox_ProdutoModelo.SelectedIndex, cBox_ProdutoSituacao.SelectedIndex));

            if (modeloItensNulo && !produtoItensNulo && !marcaItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorProdutoMarcaESituacaoAsync(cBox_ProdutoSelecao.SelectedIndex,
                    cBox_ProdutoMarca.SelectedIndex, cBox_ProdutoSituacao.SelectedIndex));

            if(situacaoItensNulo && !produtoItensNulo && !marcaItensNulo && !modeloItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorProdutoMarcaEModeloAsync(cBox_ProdutoSelecao.SelectedIndex,
                    cBox_ProdutoMarca.SelectedIndex, cBox_ProdutoModelo.SelectedIndex));



            if (!produtoItensNulo && !marcaItensNulo && !modeloItensNulo && !situacaoItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosPorProdutoMarcaModeloESituacaoAsync(cBox_ProdutoSelecao.SelectedIndex,
                    cBox_ProdutoMarca.SelectedIndex, cBox_ProdutoModelo.SelectedIndex, cBox_ProdutoSituacao.SelectedIndex));

            if(produtoItensNulo && marcaItensNulo && modeloItensNulo && situacaoItensNulo)
                await RecarregarTabelaAsync(Produto.BuscarProdutosAsync());
        }

        private async void bttn_LimparFiltros_Click(object sender, EventArgs e)
        {
            cBox_ProdutoMarca.SelectedItem = null;
            cBox_ProdutoModelo.SelectedItem = null;
            cBox_ProdutoSelecao.SelectedItem = null;
            cBox_ProdutoSituacao.SelectedItem = null;

            await RecarregarTabelaAsync(Produto.BuscarProdutosAsync());
        }
    }
}