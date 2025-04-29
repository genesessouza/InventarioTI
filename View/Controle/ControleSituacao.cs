using InventarioTI.Connection;
using InventarioTI.Model;
using InventarioTI.View.Cadastro;
using InventarioTI.View.Edicao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioTI.View
{
    public partial class ControleSituacao : Form
    {
        private readonly DataTable _tabelaDeSituacoes = new DataTable();

        public ControleSituacao()
        {
            InitializeComponent();
            CenterToScreen();

            _tabelaDeSituacoes.Columns.Add("Id", typeof(int));
            _tabelaDeSituacoes.Columns.Add("Valor", typeof(string));

            _ = InicializarAsync();
        }

        public async Task InicializarAsync()
        {
            cBox_SituacaoSelecao.Items.Clear();
            var situacoes = await Situacao.BuscarSituacoesAsync();
            foreach (var situacao in situacoes)
                cBox_SituacaoSelecao.Items.Add(situacao.Valor);

            await RecarregarTabelaAsync();
        }

        public async Task RecarregarTabelaAsync(Task<List<Situacao>>? situacoesTask = null)
        {
            try
            {
                _tabelaDeSituacoes.Clear();

                var situacoes = situacoesTask != null ? await situacoesTask : await Situacao.BuscarSituacoesAsync();

                foreach (var situacao in situacoes)
                    _tabelaDeSituacoes.Rows.Add(situacao.Id, situacao.Valor);

                dataGrid_Situacoes.DataSource = _tabelaDeSituacoes;
            }
            catch (Exception ex)
            {
                ExibirMensagemErro($"Erro ao recarregar tabela: {ex.Message}");
            }
        }

        private static void ExibirMensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bttn_SituacaoCadastrar_Click(object sender, EventArgs e)
        {
            var cadastroSituacao = new CadastroSituacao(this);
            cadastroSituacao.TopMost = true;
            cadastroSituacao.ShowDialog();
        }

        private void bttn_SituacaoEditar_Click(object sender, EventArgs e)
        {
            if (dataGrid_Situacoes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma situação selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = Convert.ToInt32(dataGrid_Situacoes.SelectedRows[0].Cells["Id"].Value.ToString());

            var situacaoSelecionada = Task.Run(() => Situacao.ObterDadosDaSituacaoSelecionadaAsync(id)).Result;

            var edicaoSituacao = new EdicaoSituacao(this, situacaoSelecionada);
            edicaoSituacao.TopMost = true;
            edicaoSituacao.Show();
        }

        private async void bttn_SituacaoExcluir_Click(object sender, EventArgs e)
        {
            DialogResult temCerteza = 
                MessageBox.Show("Deseja realmente excluir a situação selecionada?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (temCerteza == DialogResult.No)
                return;

            var id = (int)dataGrid_Situacoes.CurrentRow.Cells[0].Value;

            var sucesso = Situacao.ExcluirSituacao(id);
            if (sucesso)
                MessageBox.Show("Situação excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao excluir situação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            await InicializarAsync();
        }

        private async void bttn_SituacaoFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBox_SituacaoSelecao.SelectedItem == null)
                    await RecarregarTabelaAsync(Situacao.BuscarSituacoesAsync());
                else
                    await RecarregarTabelaAsync(Situacao.BuscarSituacoesPorNomeAsync(cBox_SituacaoSelecao.Text));
            }
            catch (Exception ex)
            {
                ExibirMensagemErro($"Erro ao filtrar situações: {ex.Message}");
            }
        }

        private async void bttn_SituacaoLimparFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                cBox_SituacaoSelecao.SelectedItem = null;
                await RecarregarTabelaAsync();
            }
            catch (Exception ex)
            {
                ExibirMensagemErro($"Erro ao limpar filtros: {ex.Message}");
            }
        }
    }
}