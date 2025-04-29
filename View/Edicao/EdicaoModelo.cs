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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioTI.View.Edicao
{
    public partial class EdicaoModelo : Form
    {
        private ControleModelo _controleModelo;
        private Modelo _modeloAEditar;

        public EdicaoModelo()
        {
            InitializeComponent();
        }

        public EdicaoModelo(ControleModelo controleModelo, Modelo modeloAEditar)
        {
            InitializeComponent();
            _controleModelo = controleModelo;

            CenterToParent();

            _modeloAEditar = modeloAEditar;

            _ = InicializarAsync();

            tBox_EdicaoModeloNome.Text = _modeloAEditar.Nome;
        }

        private async Task InicializarAsync()
        {
            var marcas = await Marca.BuscarMarcasAsync();
            foreach (var marca in marcas)
            {
                if (!cBox_EdicaoModeloMarca.Items.Contains(marca.Nome))
                    cBox_EdicaoModeloMarca.Items.Add(marca.Nome);
            }

            cBox_EdicaoModeloMarca.SelectedIndex = _modeloAEditar.IdMarca;

            var situacoes = await Situacao.BuscarSituacoesAsync();
            foreach (var situacao in situacoes)
            {
                if (!cBox_EdicaoModeloSituacao.Items.Contains(situacao.Valor))
                    cBox_EdicaoModeloSituacao.Items.Add(situacao.Valor);
            }

            if (cBox_EdicaoModeloSituacao.Items.Count > 0)
                cBox_EdicaoModeloSituacao.SelectedIndex = _modeloAEditar.IdSituacao;
        }

        private async void bttn_EdicaoModeloSalvar_Click(object sender, EventArgs e)
        {
            var novoNome = tBox_EdicaoModeloNome.Text;
            var novaSituacao = cBox_EdicaoModeloSituacao.SelectedIndex;
            var novaMarca = cBox_EdicaoModeloMarca.SelectedIndex;

            if (!string.IsNullOrEmpty(novoNome))
            {
                var sucesso = await Modelo.EditarModeloAsync(novaMarca, _modeloAEditar.Id, novaSituacao, novoNome);
                if (sucesso)
                    MessageBox.Show("Modelo editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Erro ao editar o modelo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                await _controleModelo.InicializarAsync();
            }
        }
    }
}