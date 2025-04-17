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
    public partial class CadastroProduto : Form
    {
        ControleProduto _controleProduto;
        ControleSituacao _controleSituacao;
        ControleMarca _controleMarca;
        ControleModelo _controleModelo;

        public CadastroProduto()
        {
            InitializeComponent();
        }

        public CadastroProduto(ControleProduto controleProduto)
        {
            InitializeComponent();
            _controleProduto = controleProduto;
            _controleMarca = new ControleMarca();
            _controleModelo = new ControleModelo();
            _controleSituacao = new ControleSituacao();

            CenterToScreen();

            foreach (var marca in _controleMarca.BuscarMarcas())
            {
                if (!cBox_CadastroMarca.Items.Contains(marca.Nome))
                    cBox_CadastroMarca.Items.Add(marca.Nome);
            }

            foreach (var modelo in _controleModelo.BuscarModelos())
            {
                if (!cBox_CadastroModelo.Items.Contains(modelo.Nome))
                    cBox_CadastroModelo.Items.Add(modelo.Nome);
            }

            foreach (var situacao in _controleSituacao.BuscarSituacoes())
            {
                if (!cBox_CadastroSituacao.Items.Contains(situacao.Valor))
                    cBox_CadastroSituacao.Items.Add(situacao.Valor);
            }

            cBox_CadastroMarca.SelectedIndex = 0;
            cBox_CadastroModelo.SelectedIndex = 0;
            cBox_CadastroSituacao.SelectedIndex = 1;
        }

        private void bttn_CadastrarProduto_Click(object sender, EventArgs e)
        {
            var produto = new Produto();

            produto.IdMarca = cBox_CadastroMarca.SelectedIndex + 1;
            produto.IdModelo = cBox_CadastroModelo.SelectedIndex + 1;
            produto.IdSituacao = cBox_CadastroSituacao.SelectedIndex;
            produto.CodigoDeFabrica = tBox_CadastroCodFab.Text;
            produto.Descricao = tBox_CadastroDesc.Text;
            produto.Preco = Decimal.Parse(tBox_CadastroPreco.Text);

            CadastrarProduto(produto);

            _controleProduto.RecarregarTabela(_controleProduto.BuscarProdutos());
        }

        private void CadastrarProduto(Produto produto)
        {
            var ultimoIdCadastrado = 0;
            try
            {
                var query = $"SELECT pk_id_produto FROM Produto";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    var leitor = comando.ExecuteReader();

                    while (leitor.Read())
                        ultimoIdCadastrado = leitor.GetInt16(0);
                }

                query = "INSERT INTO Produto (fk_id_marca, fk_id_modelo, fk_id_situacao, fk_id_estoque, codigo_de_fabrica, descricao, preco) " +
                    $"VALUES ({produto.IdMarca}, {produto.IdModelo}, {produto.IdSituacao}, {ultimoIdCadastrado + 1}, '{produto.CodigoDeFabrica}', '{produto.Descricao}', {produto.Preco})";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao cadastrar produto: {ex.Message}", "Puxa vida...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}