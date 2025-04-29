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

namespace InventarioTI.View.Edicao
{
    public partial class EdicaoMarca : Form
    {
        private ControleMarca _controleMarca;
        private Marca _marcaAEditar;

        public EdicaoMarca()
        {
            InitializeComponent();
        }

        public EdicaoMarca(ControleMarca controleMarca, Marca marcaAEditar)
        {
            InitializeComponent();
            _controleMarca = controleMarca;
            _marcaAEditar = marcaAEditar;

            CenterToParent();

            _ = IncializarAsync();
        }

        private async Task IncializarAsync()
        {
            var situacoes = await Situacao.BuscarSituacoesAsync();

            foreach (var situacao in situacoes)
                cBox_EdicaoMarcaSituacao.Items.Add(situacao.Valor);

            tBox_EdicaoMarcaNome.Text = _marcaAEditar.Nome;
            cBox_EdicaoMarcaSituacao.SelectedIndex = _marcaAEditar.IdSituacao;
        }

        private async void bttn_EdicaoMarcaSalvar_Click(object sender, EventArgs e)
        {
            var novaSituacao = cBox_EdicaoMarcaSituacao.SelectedIndex;

            if (string.IsNullOrEmpty(tBox_EdicaoMarcaNome.Text))
            {
                MessageBox.Show("Nome não pode ser nulo", "Aviso", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                return;
            }

            var sucesso = await Marca.EditarMarcaAsync(_marcaAEditar.Id, novaSituacao, tBox_EdicaoMarcaNome.Text);
            if (sucesso)
                MessageBox.Show("Marca editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao editar marca", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            await _controleMarca.InicializarAsync();
        }
    }
}