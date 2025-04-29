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

        public ControleModelo()
        {
            InitializeComponent();

            CenterToScreen();

            tabelaDeModelos.Columns.Add("Id", typeof(int));
            tabelaDeModelos.Columns.Add("Nome", typeof(string));
            tabelaDeModelos.Columns.Add("Marca", typeof(string));

            _ = InicializarAsync();
        }

        public async Task InicializarAsync()
        {
            cBox_ModeloSelecao.Items.Clear();
            var modelos = await Modelo.BuscarModelosAsync();
            foreach (var modelo in modelos)
                cBox_ModeloSelecao.Items.Add(modelo.Nome);

            cBox_ModeloMarca.Items.Clear();
            var marcas = await Marca.BuscarMarcasAsync();
            foreach (var marca in marcas)
                cBox_ModeloMarca.Items.Add(marca.Nome);

            cBox_ModeloSituacao.Items.Clear();
            var situacoes = await Situacao.BuscarSituacoesAsync();
            foreach (var situacao in situacoes)
                cBox_ModeloSituacao.Items.Add(situacao.Valor);

            await RecarregarTabelaAsync();
        }

        public async Task RecarregarTabelaAsync(Task<List<Modelo>>? modelosTask = null)
        {
            try
            {
                tabelaDeModelos.Clear();

                var modelos = modelosTask != null ? await modelosTask : await Modelo.BuscarModelosAsync();

                foreach (var modelo in modelos)
                    tabelaDeModelos.Rows.Add(modelo.Id, modelo.Nome, modelo.Marca);

                dataGrid_Modelos.DataSource = tabelaDeModelos;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao carregar os modelos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void bttn_ModeloFiltrar_Click(object sender, EventArgs e)
        {
            if (cBox_ModeloSelecao.SelectedItem == null && cBox_ModeloMarca.SelectedItem == null)
                await RecarregarTabelaAsync(Modelo.BuscarModelosPorSituacaoAsync(cBox_ModeloSituacao.SelectedIndex));
            else if (cBox_ModeloSelecao.SelectedItem == null && cBox_ModeloSituacao.SelectedItem == null)
                await RecarregarTabelaAsync(Modelo.BuscarModelosPorMarcaAsync(cBox_ModeloMarca.SelectedIndex));
            else if (cBox_ModeloMarca.SelectedItem == null && cBox_ModeloSituacao.SelectedItem == null)
                await RecarregarTabelaAsync(Modelo.BuscarModelosPorDescricaoAsync(cBox_ModeloSelecao.Text));
            else if (cBox_ModeloSelecao.SelectedItem == null)
                await RecarregarTabelaAsync(Modelo.BuscarModelosPorSituacaoEMarcaAsync(cBox_ModeloMarca.SelectedIndex, cBox_ModeloSituacao.SelectedIndex));
            else if (cBox_ModeloMarca.SelectedItem == null)
                await RecarregarTabelaAsync(Modelo.BuscarModelosPorSelecaoESituacaoAsync(cBox_ModeloSelecao.SelectedIndex,
                    cBox_ModeloSituacao.SelectedIndex));
            else if (cBox_ModeloSituacao.SelectedItem == null)
                await RecarregarTabelaAsync(Modelo.BuscarModelosPorSelecaoEMarcaAsync(cBox_ModeloSelecao.SelectedIndex,
                    cBox_ModeloMarca.SelectedIndex));
            else
                await RecarregarTabelaAsync(Modelo.BuscarModelosPorSelecaoMarcaESituacaoAsync(cBox_ModeloSelecao.SelectedIndex,
                                cBox_ModeloMarca.SelectedIndex, cBox_ModeloSituacao.SelectedIndex));
        }

        private async void bttn_ModeloLimparFiltros_Click(object sender, EventArgs e)
        {
            await RecarregarTabelaAsync(Modelo.BuscarModelosAsync());

            cBox_ModeloSelecao.SelectedItem = null;
            cBox_ModeloSituacao.SelectedItem = null;
            cBox_ModeloMarca.SelectedItem = null;
        }

        private async void bttn_ModeloExcluir_Click(object sender, EventArgs e)
        {
            DialogResult desejaExcluir =
                MessageBox.Show("Deseja realmente excluir o modelo selecionado?", "Excluir Modelo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (desejaExcluir == DialogResult.Yes)
            {
                await Modelo.ExcluirModeloAsync(Convert.ToInt32(dataGrid_Modelos.SelectedRows[0].Cells["Id"].Value.ToString()));
                await InicializarAsync();
            }
        }

        private void bttn_ModeloInserir_Click(object sender, EventArgs e)
        {
            CadastroModelo controleModelo = new CadastroModelo(this);
            controleModelo.TopMost = true;
            controleModelo.Show();
        }

        private async void bttn_ModeloEditar_Click(object sender, EventArgs e)
        {
            var modeloAEditar = await Modelo.ObterDadosDoModeloSelecionadoAsync(Convert.ToInt32(dataGrid_Modelos.SelectedRows[0].Cells["Id"].Value.ToString()));

            EdicaoModelo edicaoModelo = new EdicaoModelo(this, modeloAEditar);
            edicaoModelo.TopMost = true;
            edicaoModelo.Show();
        }
    }
}