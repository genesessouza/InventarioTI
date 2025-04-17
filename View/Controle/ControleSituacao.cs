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
    public partial class ControleSituacao : Form
    {
        DataTable tabelaDeSituacoes = new DataTable();
        List<Situacao> _tempSituacoes = new List<Situacao>();

        public ControleSituacao()
        {
            InitializeComponent();

            CenterToScreen();

            tabelaDeSituacoes.Columns.Add("Id", typeof(int));
            tabelaDeSituacoes.Columns.Add("Valor", typeof(string));

            RecarregarTabela(BuscarSituacoes());
        }

        private List<Situacao> BuscarSituacoesPorNome(string valor)
        {
            var situacoes = new List<Situacao>();
            try
            {
                using (var comando = new SqlCommand($"SELECT * FROM Situacao WHERE valor like '%{valor}%'", GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (!leitor.HasRows)
                            MessageBox.Show("Pesquisa não retornou resultados. Verifique os filtros.", "Pesquisa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        while (leitor.Read())
                        {
                            var situacao = new Model.Situacao
                            {
                                Id = leitor.GetInt16(0),
                                Valor = leitor.GetString(1)
                            };
                            situacoes.Add(situacao);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao buscar situações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return situacoes;
        }

        public List<Situacao> BuscarSituacoes()
        {
            var situacoes = new List<Situacao>();
            try
            {
                using (var comando = new SqlCommand("SELECT * FROM Situacao ORDER BY pk_id_situacao", GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (!leitor.HasRows)
                            MessageBox.Show("Pesquisa não retornou resultados. Verifique os filtros.", "Pesquisa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        while (leitor.Read())
                        {
                            var situacao = new Model.Situacao
                            {
                                Id = leitor.GetInt16(0),
                                Valor = leitor.GetString(1)
                            };
                            situacoes.Add(situacao);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao buscar situações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return situacoes;
        }

        public void RecarregarTabela(List<Situacao> situacoes)
        {
            tabelaDeSituacoes.Clear();

            foreach (var situacao in situacoes)
                tabelaDeSituacoes.Rows.Add(situacao.Id, situacao.Valor);

            dataGrid_Situacoes.DataSource = tabelaDeSituacoes;
        }

        private void ExcluirSituacao(int id)
        {
            try
            {
                using (var comando = new SqlCommand($"DELETE FROM Situacao WHERE pk_id_situacao = {id}", GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    var linhasAfetadas = comando.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        MessageBox.Show("Situação excluída com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Nenhuma situação foi excluída. Verifique o ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao excluir situação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RecarregarTabela(BuscarSituacoes());
        }

        private void bttn_SituacaoCadastrar_Click(object sender, EventArgs e)
        {
            var cadastroSituacao = new Cadastro.CadastroSituacao(this);
            cadastroSituacao.Show();
        }

        private void bttn_SituacaoExcluir_Click(object sender, EventArgs e)
        {
            ExcluirSituacao((int)dataGrid_Situacoes.CurrentRow.Cells[0].Value);
        }

        private void bttn_SituacaoFiltrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tBox_SituacaoValor.Text))
                RecarregarTabela(BuscarSituacoesPorNome(tBox_SituacaoValor.Text));
            else
                RecarregarTabela(BuscarSituacoes());
        }

        private void bttn_SituacaoLimparFiltros_Click(object sender, EventArgs e)
        {
            RecarregarTabela(BuscarSituacoes());
            tBox_SituacaoValor.Clear();
        }
    }
}