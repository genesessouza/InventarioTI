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

namespace InventarioTI.View
{
    public partial class EdicaoProduto : Form
    {
        ControleProduto _controleProduto;
        ControleMarca _controleMarca;
        ControleModelo _controleModelo;
        ControleSituacao _controleSituacao;

        Produto _produtoAEditar;

        public EdicaoProduto()
        {
            InitializeComponent();
        }

        public EdicaoProduto(ControleProduto controleProduto, Produto produtoAEditar)
        {
            InitializeComponent();
            _controleProduto = controleProduto;
            _controleMarca = new ControleMarca();
            _controleModelo = new ControleModelo();
            _controleSituacao = new ControleSituacao();

            var marcas = _controleMarca.BuscarMarcas();
            foreach (var marca in marcas)
            {
                if (!cBox_EdicaoProdutoMarca.Items.Contains(marca.Nome))
                    cBox_EdicaoProdutoMarca.Items.Add(marca.Nome);

            }

            var modelos = _controleModelo.BuscarModelos();
            foreach (var modelo in modelos)
            {
                if (!cBox_EdicaoProdutoModelo.Items.Contains(modelo.Nome))
                    cBox_EdicaoProdutoModelo.Items.Add(modelo.Nome);
            }

            var situacoes = _controleSituacao.BuscarSituacoes();
            foreach (var situacao in situacoes)
            {
                if (!cBox_EdicaoProdutoSituacao.Items.Contains(situacao.Valor))
                    cBox_EdicaoProdutoSituacao.Items.Add(situacao.Valor);
            }

            tBox_EdicaoDesc.Text = produtoAEditar.Descricao;
            tBox_EdicaoProdutoPreco.Text = produtoAEditar.Preco.ToString();
            tBox_EdicaoProdutoCodFab.Text = produtoAEditar.CodigoDeFabrica;

            cBox_EdicaoProdutoMarca.SelectedIndex = 0;
            cBox_EdicaoProdutoModelo.SelectedIndex = 0;
            cBox_EdicaoProdutoSituacao.SelectedIndex = 1;

            CenterToScreen();

            _produtoAEditar = produtoAEditar;
        }

        private void bttn_EditarProduto_Click(object sender, EventArgs e)
        {
            _produtoAEditar.IdMarca = cBox_EdicaoProdutoMarca.SelectedIndex;
            _produtoAEditar.IdModelo = cBox_EdicaoProdutoModelo.SelectedIndex;
            _produtoAEditar.IdSituacao = cBox_EdicaoProdutoSituacao.SelectedIndex;
            _produtoAEditar.Descricao = tBox_EdicaoDesc.Text;
            _produtoAEditar.Preco = Convert.ToDecimal(tBox_EdicaoProdutoPreco.Text);

            EditarProduto(_produtoAEditar.Id, _produtoAEditar.IdMarca, _produtoAEditar.IdModelo, _produtoAEditar.IdSituacao, _produtoAEditar.Descricao, _produtoAEditar.Preco);

            _controleProduto.RecarregarTabela(_controleProduto.BuscarProdutos());
        }

        private void EditarProduto(int idProduto, int idNovaMarca, int idNovoModelo, int idNovaSituacao, string novaDescricao, Decimal novoPreco)
        {
            try
            {
                var query = $"UPDATE Produto SET fk_id_situacao = {idNovaSituacao}, fk_id_marca = {idNovaMarca}, fk_id_modelo = {idNovoModelo}, " +
                    $"descricao = '{novaDescricao}', preco = {novoPreco} " +
                    $"WHERE pk_id_produto = {idProduto}";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Produto alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao tentar atualizar dados do produto: {ex.Message}", "Puxa vida...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
        }

        private void cBox_EdicaoProdutoModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}