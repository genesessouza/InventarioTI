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
    public partial class CadastroMarca : Form
    {
        private ControleMarca _controleMarca;
        private int _ultimoIdCadastrado = 0;

        public CadastroMarca()
        {
            InitializeComponent();

            CenterToParent();

            _ = InicializarAsync();
        }

        private async Task InicializarAsync()
        {
            var situacoes = await Situacao.BuscarSituacoesAsync();
            foreach (var situacao in situacoes)
                cBox_MarcaSituacao.Items.Add(situacao.Valor);

            cBox_MarcaSituacao.SelectedIndex = 1;
        }

        public CadastroMarca(ControleMarca controleMarca)
        {
            InitializeComponent();
            _controleMarca = controleMarca;

            _ = InicializarAsync();

            CenterToParent();
        }

        private async void bttn_CadastroMarcaSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBox_CadastroMarcaNome.Text))
            {
                MessageBox.Show("Nome não pode ser nulo", "Aviso", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                return;
            }

            if (cBox_MarcaSituacao.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma situação", "Aviso", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                return;
            }

            var marcas = await Marca.BuscarMarcasAsync();
            foreach (var marca in marcas)
                _ultimoIdCadastrado = marca.Id;

            var sucesso = await Marca.CadastrarMarcaAsync(_ultimoIdCadastrado + 1, tBox_CadastroMarcaNome.Text, cBox_MarcaSituacao.SelectedIndex);

            if (sucesso)
                MessageBox.Show("Marca cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao cadastrar marca", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            tBox_CadastroMarcaNome.Clear();
            cBox_MarcaSituacao.SelectedItem = null;

            await _controleMarca.InicializarAsync();
        }
    }
}