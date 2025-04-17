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
        ControleMarca _controleMarca;
        ControleModelo _controleModelo;

        public ControleProduto()
        {
            InitializeComponent();

            _controleMarca = new ControleMarca();
            _controleModelo = new ControleModelo();

            CenterToScreen();

            _tabelaProdutos.Columns.Add("Id");
            _tabelaProdutos.Columns.Add("Código de Fábrica");
            _tabelaProdutos.Columns.Add("Descrição");
            _tabelaProdutos.Columns.Add("Preço");

            var marcas = _controleMarca.BuscarMarcas();
            foreach (var marca in marcas)
            {
                if (!cBox_ProdutoMarca.Items.Contains(marca.Nome))
                    cBox_ProdutoMarca.Items.Add(marca.Nome);
            }

            var modelos = _controleModelo.BuscarModelos();
            foreach(var modelo in modelos)
            {
                if (!cBox_ProdutoModelo.Items.Contains(modelo.Nome))
                    cBox_ProdutoModelo.Items.Add(modelo.Nome);
            }

            cBox_ProdutoSituacao.Items.Insert(0, "Inativo");
            cBox_ProdutoSituacao.Items.Insert(1, "Ativo");

            cBox_ProdutoMarca.SelectedIndex = 0;
            cBox_ProdutoModelo.SelectedIndex = 0;
            cBox_ProdutoSituacao.SelectedIndex = 1;

            RecarregarTabela(BuscarProdutos());
        }

        public List<Produto> BuscarProdutos()
        {
            var produtos = new List<Produto>();
            try
            {
                var query = "SELECT pk_id_produto, codigo_de_fabrica, descricao, marca.nome, modelo.nome, preco " +
                    "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo ";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (leitor.HasRows == false)
                            MessageBox.Show("Pesquisa não retornou resultados. Verifique os filtros.", "Pesquisa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        while (leitor.Read())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                CodigoDeFabrica = leitor.GetString(1),
                                Descricao = leitor.GetString(2),
                                Marca = leitor.GetString(3),
                                Modelo = leitor.GetString(4),
                                Preco = leitor.GetDecimal(5)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos na database: " + ex.Message);
            }
            return produtos;
        }

        public List<Produto> BuscarProdutosPorSituacao(int idSituacao)
        {
            var produtos = new List<Produto>();
            try
            {
                var query = "SELECT pk_id_produto, codigo_de_fabrica, descricao, marca.nome, modelo.nome, preco " +
                    "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    $"WHERE Produto.fk_id_situacao = {idSituacao}" +
                    "ORDER BY pk_id_produto";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (leitor.HasRows == false)
                            MessageBox.Show("Pesquisa não retornou resultados. Verifique os filtros.", "Pesquisa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        while (leitor.Read())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                CodigoDeFabrica = leitor.GetString(1),
                                Descricao = leitor.GetString(2),
                                Marca = leitor.GetString(3),
                                Modelo = leitor.GetString(4),
                                Preco = leitor.GetDecimal(5)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos na database: " + ex.Message);
            }
            return produtos;
        }

        public List<Produto> BuscarProdutosPorModeloESituacao(int idModelo, int idSituacao)
        {
            var produtos = new List<Produto>();
            try
            {
                var query = "SELECT pk_id_produto, codigo_de_fabrica, descricao, marca.nome, modelo.nome, preco " +
                    "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    $"WHERE Produto.fk_id_modelo = {idModelo} AND Produto.fk_id_situacao = {idSituacao} " +
                    "ORDER BY pk_id_produto";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (leitor.HasRows == false)
                            MessageBox.Show("Pesquisa não retornou resultados. Verifique os filtros.", "Pesquisa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        while (leitor.Read())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                CodigoDeFabrica = leitor.GetString(1),
                                Descricao = leitor.GetString(2),
                                Marca = leitor.GetString(3),
                                Modelo = leitor.GetString(4),
                                Preco = leitor.GetDecimal(5)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos na database: " + ex.Message);
            }
            return produtos;
        }

        public List<Produto> BuscarProdutosPorDescricaoESituacao(string descricao, int idSituacao)
        {
            var produtos = new List<Produto>();
            try
            {
                var query = "SELECT pk_id_produto, produto.fk_id_marca, codigo_de_fabrica, descricao, marca.nome, modelo.nome, preco " +
                    "FROM Produto " +
                    "JOIN Marca ON " +
                    "Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo ON " +
                    "Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    $"WHERE Produto.descricao like '%{descricao}%' AND Produto.fk_id_situacao = {idSituacao}" +
                    $"ORDER BY pk_id_produto";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (leitor.HasRows == false)
                            MessageBox.Show("Pesquisa não retornou resultados. Verifique os filtros.", "Pesquisa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        while (leitor.Read())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                CodigoDeFabrica = leitor.GetString(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos na database: " + ex.Message);
            }
            return produtos;
        }

        public List<Produto> BuscarProdutosPorMarcaESituacao(int idMarca, int idSituacao)
        {
            var produtos = new List<Produto>();
            try
            {
                var query = "SELECT pk_id_produto, produto.fk_id_marca, codigo_de_fabrica, descricao, marca.nome, modelo.nome, preco " +
                    "FROM Produto " +
                    "JOIN Marca ON " +
                    "Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo ON " +
                    "Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    $"WHERE Produto.fk_id_marca = {idMarca} AND Produto.fk_id_situacao = {idSituacao} " +
                    $"ORDER BY pk_id_produto";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (leitor.HasRows == false)
                            MessageBox.Show("Pesquisa não retornou resultados. Verifique os filtros.", "Pesquisa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        while (leitor.Read())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                CodigoDeFabrica = leitor.GetString(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos na database: " + ex.Message);
            }
            return produtos;
        }

        public List<Produto> BuscarProdutosPorMarcaModeloESituacao(int idMarca, int idModelo, int idSituacao)
        {
            var produtos = new List<Produto>();
            try
            {
                var query = "SELECT pk_id_produto, produto.fk_id_marca, codigo_de_fabrica, descricao, marca.nome, modelo.nome, preco " +
                    "FROM Produto " +
                    "JOIN Marca ON " +
                    "Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo ON " +
                    "Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    $"WHERE Produto.fk_id_marca = {idMarca} AND Produto.fk_id_modelo = {idModelo} AND Produto.fk_id_situacao = {idSituacao} " +
                    $"ORDER BY pk_id_produto";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (leitor.HasRows == false)
                            MessageBox.Show("Pesquisa não retornou resultados. Verifique os filtros.", "Pesquisa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        while (leitor.Read())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                CodigoDeFabrica = leitor.GetString(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos na database: " + ex.Message);
            }
            return produtos;
        }

        private void ExcluirProduto(int idProduto)
        {
            try
            {
                var query = $"DELETE FROM Produto WHERE pk_id_produto = {idProduto}";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    var linhasAfetadas = comando.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        MessageBox.Show("Produto excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Verifique os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao excluir produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RecarregarTabela(List<Produto> produtos)
        {
            _tabelaProdutos.Clear();

            foreach (var produto in produtos)
                _tabelaProdutos.Rows.Add(produto.Id, produto.CodigoDeFabrica, produto.Descricao, produto.Preco);

            dataGrid_Produtos.DataSource = _tabelaProdutos;
        }

        private Produto ObterDadosDoProdutoSelecionado(int idProdutoSelecionado)
        {
            Produto produtoSelecionado = new Produto();
            try
            {
                var query = $"SELECT pk_id_produto, fk_id_marca, fk_id_situacao, codigo_de_fabrica, descricao, preco FROM Produto WHERE pk_id_produto = {idProdutoSelecionado}";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    var leitor = comando.ExecuteReader();
                    while (leitor.Read())
                    {
                        produtoSelecionado.Id = leitor.GetInt16(0);
                        produtoSelecionado.IdMarca = leitor.GetInt16(1);
                        produtoSelecionado.IdSituacao = leitor.GetInt16(2);
                        produtoSelecionado.CodigoDeFabrica = leitor.GetString(3);
                        produtoSelecionado.Descricao = leitor.GetString(4);
                        produtoSelecionado.Preco = leitor.GetDecimal(5);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Não foi possível encontrar os dados do produto selecionado: {ex.Message}", "Puxa vida...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return produtoSelecionado;
        }

        private void bttn_Inserir_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastrarProduto = new CadastroProduto(this);
            cadastrarProduto.Show();
        }

        private void bttn_Editar_Click(object sender, EventArgs e)
        {
            var produtoSelecionado = ObterDadosDoProdutoSelecionado(Convert.ToInt32(dataGrid_Produtos.SelectedRows[0].Cells["Id"].Value.ToString()));
            EdicaoProduto editarProduto = new EdicaoProduto(this, produtoSelecionado);
            editarProduto.Show();
        }

        private void bttn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult desejaExcluir =
                MessageBox.Show("Deseja realmente excluir o produto selecionado?", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (desejaExcluir == DialogResult.Yes)
            {
                var idProdutoSelecionado = Convert.ToInt32(dataGrid_Produtos.SelectedRows[0].Cells["Id"].Value.ToString());
                ExcluirProduto(idProdutoSelecionado);

                RecarregarTabela(BuscarProdutos());
            }
        }

        private void bttn_Filtrar_Click(object sender, EventArgs e)
        {
            var descricaoVazia = string.IsNullOrEmpty(tBox_ProdutoDescricao.Text);

            var marcaVazia = cBox_ProdutoMarca.SelectedItem == null;
            var modeloVazio = cBox_ProdutoModelo.SelectedItem == null;

            var descricao = tBox_ProdutoDescricao.Text;

            var idMarca = cBox_ProdutoMarca.SelectedIndex + 1;
            var idModelo = cBox_ProdutoModelo.SelectedIndex + 1;
            var idSituacao = cBox_ProdutoSituacao.SelectedIndex;

            if (descricaoVazia && marcaVazia && modeloVazio)
                RecarregarTabela(BuscarProdutosPorSituacao(idSituacao));
            else if (marcaVazia && modeloVazio)
                RecarregarTabela(BuscarProdutosPorDescricaoESituacao(descricao, idSituacao));
            else if (descricaoVazia && modeloVazio)
                RecarregarTabela(BuscarProdutosPorMarcaESituacao(idMarca, idSituacao));
            else if (descricaoVazia && marcaVazia)
                RecarregarTabela(BuscarProdutosPorModeloESituacao(idModelo, idSituacao));
            else if (descricaoVazia)
                RecarregarTabela(BuscarProdutosPorMarcaModeloESituacao(idMarca, idModelo, idSituacao));
        }

        private void bttn_LimparFiltros_Click(object sender, EventArgs e)
        {
            cBox_ProdutoMarca.SelectedItem = null;
            cBox_ProdutoModelo.SelectedItem = null;
            tBox_ProdutoDescricao.Text = string.Empty;
            cBox_ProdutoSituacao.SelectedIndex = 1;
            RecarregarTabela(BuscarProdutos());
        }
    }
}