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

            _ = InicializarAsync();
        }

        public async Task InicializarAsync()
        {
            cBox_MarcaSelecao.Items.Clear();

            var marcas = await Marca.BuscarMarcasAsync();
            foreach (var marca in marcas)
                cBox_MarcaSelecao.Items.Add(marca.Nome);

            cBox_MarcaSituacao.Items.Clear();
            var situacoes = await Situacao.BuscarSituacoesAsync();
            foreach (var situacao in situacoes)
                cBox_MarcaSituacao.Items.Add(situacao.Valor);

            await RecarregarTabelaAsync();
        }

        public async Task RecarregarTabelaAsync(Task<List<Marca>>? marcasTask = null)
        {
            try
            {
                tabelaDeMarcas.Clear();

                var marcas = marcasTask != null ? await marcasTask : await Marca.BuscarMarcasAsync();

                foreach (var marca in marcas)
                    tabelaDeMarcas.Rows.Add(marca.Id, marca.Nome);

                dataGrid_Marcas.DataSource = tabelaDeMarcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao recarregar marcas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void bttn_MarcaFiltrar_Click(object sender, EventArgs e)
        {
            if (cBox_MarcaSelecao.SelectedItem == null)
                await RecarregarTabelaAsync(Marca.BuscarMarcasPorSituacaoAsync(cBox_MarcaSituacao.SelectedIndex));
            else if (cBox_MarcaSituacao.SelectedItem == null)
                await RecarregarTabelaAsync(Marca.BuscarMarcasPorSelecaoAsync(cBox_MarcaSelecao.SelectedIndex));
            else
                await RecarregarTabelaAsync(Marca.BuscarMarcasPorSelecaoESituacaoAsync(cBox_MarcaSelecao.SelectedIndex, cBox_MarcaSituacao.SelectedIndex));
        }

        private async void bttn_MarcaLimparFiltros_Click(object sender, EventArgs e)
        {
            cBox_MarcaSituacao.SelectedItem = null;
            cBox_MarcaSelecao.SelectedItem = null;
            await RecarregarTabelaAsync(Marca.BuscarMarcasAsync());
        }

        private void bttn_MarcaCadastrar_Click(object sender, EventArgs e)
        {
            CadastroMarca cadastroMarca = new CadastroMarca(this);
            cadastroMarca.TopMost = true;
            cadastroMarca.Show();
        }

        private async void bttn_MarcaEditar_Click(object sender, EventArgs e)
        {
            var marcaSelecionada = await Marca.ObterDadosDaMarcaSelecionadaAsync(Convert.ToInt32(dataGrid_Marcas.SelectedRows[0].Cells["Id"].Value.ToString()));

            EdicaoMarca edicaoMarca = new EdicaoMarca(this, marcaSelecionada);
            edicaoMarca.TopMost = true;
            edicaoMarca.Show();
        }

        private async void bttn_MarcaExcluir_Click(object sender, EventArgs e)
        {
            DialogResult desejaExcluirModelos =
                MessageBox.Show("Se prosseguir, os modelos e produtos sob essa marca serão redefinidos para os valores padrão. " +
                "Deseja realmente excluir a marca selecionada?", "Excluir Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (desejaExcluirModelos == DialogResult.No)
                return;

            var idMarcaSelecionada = Convert.ToInt32(dataGrid_Marcas.SelectedRows[0].Cells["Id"].Value.ToString());

            var sucesso = await Marca.ExcluirMarcaAsync(idMarcaSelecionada);
            if (sucesso)
                MessageBox.Show("Marca excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao excluir marca", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            await InicializarAsync();
        }
    }
}