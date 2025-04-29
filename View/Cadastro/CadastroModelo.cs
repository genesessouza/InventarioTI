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

namespace InventarioTI.View.Cadastro
{
    public partial class CadastroModelo : Form
    {
        private ControleModelo _controleModelo;
        private int _ultimoIdCadastrado = 0;

        public CadastroModelo()
        {
            InitializeComponent();
        }

        public CadastroModelo(ControleModelo controleModelo)
        {
            InitializeComponent();
            _controleModelo = controleModelo;

            CenterToParent();

            _ = InicializarAsync();
        }

        private async Task InicializarAsync()
        {
            var marcas = await Marca.BuscarMarcasAsync();
            foreach (var marca in marcas)
            {
                if (!cBox_CadastroModeloMarca.Items.Contains(marca.Nome))
                    cBox_CadastroModeloMarca.Items.Add(marca.Nome);
            }

            cBox_CadastroModeloMarca.SelectedIndex = 0;

            var situacoes = await Situacao.BuscarSituacoesAsync();
            foreach (var situacao in situacoes)
            {
                if (!cBox_CadastroModeloSituacao.Items.Contains(situacao.Valor))
                    cBox_CadastroModeloSituacao.Items.Add(situacao.Valor);
            }

            cBox_CadastroModeloSituacao.SelectedIndex = 1;
            await _controleModelo.InicializarAsync();
        }

        private async void bttn_CadastroModeloSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBox_CadastroModeloDescricao.Text))
            {
                MessageBox.Show("A descrição do modelo não pode estar vazia.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cBox_CadastroModeloMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, selecione uma marca válida.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cBox_CadastroModeloSituacao.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, selecione uma situação válida.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var modelos = await Modelo.BuscarModelosAsync();
            foreach (var modelo in modelos)
                _ultimoIdCadastrado = modelo.Id;

            var sucesso =
                    await Modelo.CadastrarModeloAsync(_ultimoIdCadastrado + 1, tBox_CadastroModeloDescricao.Text, cBox_CadastroModeloMarca.SelectedIndex,
                    cBox_CadastroModeloSituacao.SelectedIndex);

            if (sucesso)
                MessageBox.Show("Modelo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Falha ao cadastrar o modelo. Verifique os dados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            tBox_CadastroModeloDescricao.Clear();
            cBox_CadastroModeloMarca.SelectedItem = null;
            cBox_CadastroModeloSituacao.SelectedItem = null;

            await _controleModelo.InicializarAsync();
        }
    }
}