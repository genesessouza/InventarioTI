using InventarioTI.Connection;
using InventarioTI.Model;
using InventarioTI.View.Cadastro;
using InventarioTI.View.Edicao;
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
    public partial class ControleModelo : Form
    {
        DataTable tabelaDeModelos = new DataTable();
        ControleMarca _controleMarca = new ControleMarca();

        public ControleModelo()
        {
            InitializeComponent();

            CenterToScreen();

            tabelaDeModelos.Columns.Add("Id", typeof(int));
            tabelaDeModelos.Columns.Add("Nome", typeof(string));
            tabelaDeModelos.Columns.Add("Marca", typeof(string));

            cBox_ModeloSituacao.Items.Insert(0, "Inativo");
            cBox_ModeloSituacao.Items.Insert(1, "Ativo");

            var marcas = _controleMarca.BuscarMarcas();

            foreach (var marca in marcas)
            {
                if (!cBox_ModeloMarca.Items.Contains(marca.Nome))
                    cBox_ModeloMarca.Items.Add(marca.Nome);
            }

            RecarregarTabela(BuscarModelos());

            if (cBox_ModeloMarca.Items.Count > 0)
                cBox_ModeloMarca.SelectedIndex = 0;

            if (cBox_ModeloSituacao.Items.Count > 0)
                cBox_ModeloSituacao.SelectedIndex = 1;
        }

        public List<Modelo> BuscarModelos()
        {
            var modelos = new List<Modelo>();
            try
            {
                var query = "SELECT pk_id_modelo, fk_id_marca, modelo.nome, marca.nome " +
                    "FROM Modelo " +
                    "JOIN Marca " +
                    "ON Modelo.fk_id_marca = Marca.pk_id_marca " +
                    "ORDER BY pk_id_modelo";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (leitor.HasRows == false)
                            MessageBox.Show("Pesquisa não retornou resultados. Verifique os filtros.", "Pesquisa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        while (leitor.Read())
                        {
                            var modelo = new Modelo
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                Nome = leitor.GetString(2),
                                Marca = leitor.GetString(3)
                            };
                            modelos.Add(modelo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar modelos por situação na database: " + ex.Message);
            }
            return modelos;
        }

        public List<Modelo> BuscarModelosPorSituacaoEMarca(int idMarca, int idSituacao)
        {
            var modelos = new List<Modelo>();
            try
            {
                var query = "SELECT pk_id_modelo, fk_id_marca, modelo.nome, marca.nome " +
                    "FROM Modelo " +
                    "JOIN Marca " +
                    "ON Modelo.fk_id_marca = Marca.pk_id_marca " +
                    $"WHERE Modelo.fk_id_marca = {idMarca} AND Modelo.fk_id_situacao = {idSituacao} " +
                    "ORDER BY pk_id_modelo";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (leitor.HasRows == false)
                            MessageBox.Show("Pesquisa não retornou resultados. Verifique os filtros.", "Pesquisa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        while (leitor.Read())
                        {
                            var modelo = new Modelo
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                Nome = leitor.GetString(2),
                                Marca = leitor.GetString(3)
                            };
                            modelos.Add(modelo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar modelos por situação na database: " + ex.Message);
            }
            return modelos;
        }

        public List<Modelo> BuscarModelosPorNomeMarcaESituacao(string nome, int idMarca, int idSituacao)
        {
            var modelos = new List<Modelo>();
            try
            {
                var query = "SELECT pk_id_modelo, modelo.nome, fk_id_marca, marca.nome " +
                    "FROM Modelo " +
                    "JOIN Marca ON " +
                    "Modelo.fk_id_marca = Marca.pk_id_marca " +
                    $"WHERE Modelo.nome like '%{nome}%' AND Modelo.fk_id_marca = {idMarca} AND Modelo.fk_id_situacao = {idSituacao} " +
                    $"ORDER BY pk_id_modelo";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (leitor.HasRows == false)
                            MessageBox.Show("Pesquisa não retornou resultados. Verifique os filtros.", "Pesquisa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        while (leitor.Read())
                        {
                            var modelo = new Modelo
                            {
                                Id = leitor.GetInt16(0),
                                Nome = leitor.GetString(1),
                                IdMarca = leitor.GetInt16(2),
                                Marca = leitor.GetString(3)
                            };
                            modelos.Add(modelo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar modelos por situação na database: " + ex.Message);
            }
            return modelos;
        }

        private void ExcluirModelo(int idModelo)
        {
            try
            {
                var query = $"DELETE FROM Modelo WHERE pk_id_modelo = {idModelo}";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    var linhasAfetadas = comando.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        MessageBox.Show("Modelo excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Verifique os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao excluir marca: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RecarregarTabela(List<Modelo> modelos)
        {
            tabelaDeModelos.Clear();

            foreach (var modelo in modelos)
                tabelaDeModelos.Rows.Add(modelo.Id, modelo.Nome, modelo.Marca);

            dataGrid_Modelos.DataSource = tabelaDeModelos;
        }

        private Modelo ObterDadosDoModeloSelecionado(int idModeloSelecionado)
        {
            Modelo modeloSelecionado = new Modelo();
            try
            {
                var query = $"SELECT pk_id_modelo, fk_id_marca, fk_id_situacao, nome FROM Modelo WHERE pk_id_modelo = {idModeloSelecionado}";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    var leitor = comando.ExecuteReader();
                    while (leitor.Read())
                    {
                        modeloSelecionado.Id = leitor.GetInt16(0);
                        modeloSelecionado.IdMarca = leitor.GetInt16(1);
                        modeloSelecionado.IdSituacao = leitor.GetInt16(2);
                        modeloSelecionado.Nome = leitor.GetString(3);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Não foi possível encontrar os dados do modelo selecionado: {ex.Message}", "Puxa vida...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return modeloSelecionado;
        }

        private void bttn_ModeloFiltrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tBox_ModeloNome.Text))
                RecarregarTabela(BuscarModelosPorNomeMarcaESituacao(tBox_ModeloNome.Text, cBox_ModeloMarca.SelectedIndex + 1, cBox_ModeloSituacao.SelectedIndex));
            else
                RecarregarTabela(BuscarModelosPorSituacaoEMarca(cBox_ModeloMarca.SelectedIndex + 1, cBox_ModeloSituacao.SelectedIndex));
        }

        private void bttn_ModeloLimparFiltros_Click(object sender, EventArgs e)
        {
            RecarregarTabela(BuscarModelos());

            cBox_ModeloSituacao.SelectedIndex = 1;
            cBox_ModeloMarca.SelectedIndex = 0;
            tBox_ModeloNome.Clear();
        }

        private void bttn_ModeloExcluir_Click(object sender, EventArgs e)
        {
            DialogResult desejaExcluir =
                MessageBox.Show("Deseja realmente excluir o modelo selecionado?", "Excluir Modelo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (desejaExcluir == DialogResult.Yes)
            {
                ExcluirModelo(Convert.ToInt32(dataGrid_Modelos.SelectedRows[0].Cells["Id"].Value.ToString()));
                RecarregarTabela(BuscarModelos());
            }
        }

        private void bttn_ModeloInserir_Click(object sender, EventArgs e)
        {
            CadastroModelo controleModelo = new CadastroModelo(this);
            controleModelo.Show();
        }

        private void bttn_ModeloEditar_Click(object sender, EventArgs e)
        {
            var modeloAEditar = ObterDadosDoModeloSelecionado(Convert.ToInt32(dataGrid_Modelos.SelectedRows[0].Cells["Id"].Value.ToString()));

            EdicaoModelo edicaoModelo = new EdicaoModelo(this, modeloAEditar);
            edicaoModelo.Show();
        }
    }
}