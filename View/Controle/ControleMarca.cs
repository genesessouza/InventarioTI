using InventarioTI.Connection;
using InventarioTI.Model;
using InventarioTI.View.Cadastro;
using InventarioTI.View.Edicao;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
    public partial class ControleMarca : Form
    {
        DataTable tabelaDeMarcas = new DataTable();

        public ControleMarca()
        {
            InitializeComponent();

            CenterToScreen();

            tabelaDeMarcas.Columns.Add("ID", typeof(int));
            tabelaDeMarcas.Columns.Add("Nome", typeof(string));

            cBox_MarcaSituacao.Items.Insert(0, "Inativo");
            cBox_MarcaSituacao.Items.Insert(1, "Ativo");
            cBox_MarcaSituacao.SelectedIndex = 1;

            RecarregarTabela(BuscarMarcas());
        }

        public List<Marca> BuscarMarcas()
        {
            var marcas = new List<Marca>();
            try
            {
                var query = "SELECT * FROM Marca ORDER BY pk_id_marca";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (leitor.HasRows == false)
                            MessageBox.Show("Pesquisa não retornou resultados. Verifique os filtros.", "Pesquisa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        while (leitor.Read())
                        {
                            var marca = new Marca
                            {
                                Id = leitor.GetInt16(0),
                                Nome = leitor.GetString(2)
                            };
                            marcas.Add(marca);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar marcas por situação na database: " + ex.Message);
            }
            return marcas;
        }

        public List<Marca> BuscarMarcasPorSituacao(int idSituacao)
        {
            var marcas = new List<Marca>();
            try
            {
                var query = "SELECT * FROM Marca WHERE fk_id_situacao = @idSituacao ORDER BY pk_id_marca";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (leitor.HasRows == false)
                            MessageBox.Show("Pesquisa não retornou resultados. Verifique os filtros.", "Pesquisa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        while (leitor.Read())
                        {
                            var marca = new Marca
                            {
                                Id = leitor.GetInt16(0),
                                Nome = leitor.GetString(2)
                            };
                            marcas.Add(marca);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar marcas por situação na database: " + ex.Message);
            }
            return marcas;
        }

        public List<Marca> BuscarMarcasPorNomeESituacao(string nome, int idSituacao)
        {
            var marcas = new List<Marca>();
            try
            {
                var query = $"SELECT * FROM Marca WHERE nome like '%{nome}%' AND fk_id_situacao = {idSituacao} ORDER BY pk_id_marca";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (leitor.HasRows == false)
                            MessageBox.Show("Pesquisa não retornou resultados. Verifique os filtros.", "Pesquisa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        while (leitor.Read())
                        {
                            var marca = new Marca
                            {
                                Id = leitor.GetInt16(0),
                                Nome = leitor.GetString(2)
                            };
                            marcas.Add(marca);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar marcas por situação na database: " + ex.Message);
            }
            return marcas;
        }

        private void ExcluirMarca(int idMarca)
        {
            try
            {
                var query = $"DELETE FROM Marca WHERE pk_id_marca = {idMarca}";

                using (var deleteComando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    var linhasAfetadas = deleteComando.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        MessageBox.Show("Marca excluída com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Verifique os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao excluir a marca selecionada: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RecarregarTabela(List<Marca> marcas)
        {
            tabelaDeMarcas.Clear();

            foreach (var marca in marcas)
                tabelaDeMarcas.Rows.Add(marca.Id, marca.Nome);

            dataGrid_Marcas.DataSource = tabelaDeMarcas;
        }

        private Marca ObterDadosDaMarcaSelecionada(int idMarcaSelecionada)
        {
            Marca marcaSelecionada = new Marca();
            try
            {
                var query = $"SELECT pk_id_marca, fk_id_situacao, nome FROM Marca WHERE pk_id_marca = {idMarcaSelecionada}";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    var leitor = comando.ExecuteReader();
                    while (leitor.Read())
                    {
                        marcaSelecionada.Id = leitor.GetInt16(0);
                        marcaSelecionada.IdSituacao = leitor.GetInt16(1);
                        marcaSelecionada.Nome = leitor.GetString(2);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Não foi possível encontrar os dados da marca selecionada: {ex.Message}", "Puxa vida...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return marcaSelecionada;
        }

        private void bttn_MarcaFiltrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBox_MarcaNome.Text))
                RecarregarTabela(BuscarMarcasPorSituacao(cBox_MarcaSituacao.SelectedIndex));
            else
                RecarregarTabela(BuscarMarcasPorNomeESituacao(tBox_MarcaNome.Text, cBox_MarcaSituacao.SelectedIndex));
        }

        private void bttn_MarcaLimparFiltros_Click(object sender, EventArgs e)
        {
            RecarregarTabela(BuscarMarcas());
            cBox_MarcaSituacao.SelectedIndex = 1;
            tBox_MarcaNome.Clear();
        }

        private void bttn_MarcaExcluir_Click(object sender, EventArgs e)
        {
            DialogResult desejaExcluir =
                MessageBox.Show("Se prosseguir, os modelos dessa marca também serão excluídos. Deseja realmente excluir a marca selecionada?", 
                "Excluir Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (desejaExcluir == DialogResult.Yes)
            {
                var idMarcaSelecionada = Convert.ToInt32(dataGrid_Marcas.SelectedRows[0].Cells["Id"].Value.ToString());
                ExcluirMarca(idMarcaSelecionada);

                RecarregarTabela(BuscarMarcas());
            }
        }

        private void bttn_MarcaCadastrar_Click(object sender, EventArgs e)
        {
            CadastroMarca cadastroMarca = new CadastroMarca(this);
            cadastroMarca.Show();
        }

        private void bttn_MarcaEditar_Click(object sender, EventArgs e)
        {
            var marcaSelecionada = ObterDadosDaMarcaSelecionada(Convert.ToInt32(dataGrid_Marcas.SelectedRows[0].Cells["Id"].Value.ToString()));

            EdicaoMarca edicaoMarca = new EdicaoMarca(this, marcaSelecionada);
            edicaoMarca.Show();
        }
    }
}