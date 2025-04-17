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
    public partial class EdicaoModelo : Form
    {
        private ControleSituacao _controleSituacao;
        private ControleMarca _controleMarca;
        private ControleModelo _controleModelo;
        private Modelo _modeloAEditar;

        public EdicaoModelo()
        {
            InitializeComponent();
        }

        public EdicaoModelo(ControleModelo controleModelo, Modelo modeloAEditar)
        {
            InitializeComponent();
            _controleSituacao = new ControleSituacao();
            _controleMarca = new ControleMarca();
            _controleModelo = controleModelo;

            CenterToScreen();

            _modeloAEditar = modeloAEditar;

            var marcas = _controleMarca.BuscarMarcas();

            foreach (var marca in marcas)
            {
                if(!cBox_EdicaoModeloMarca.Items.Contains(marca.Nome))
                cBox_EdicaoModeloMarca.Items.Add(marca.Nome);
            }

            var situacoes = _controleSituacao.BuscarSituacoes();

            foreach (var situacao in situacoes)
                cBox_EdicaoModeloSituacao.Items.Add(situacao.Valor);

            cBox_EdicaoModeloMarca.SelectedIndex = _modeloAEditar.IdMarca -1;
            cBox_EdicaoModeloSituacao.SelectedIndex = _modeloAEditar.IdSituacao;

            tBox_EdicaoModeloNome.Text = _modeloAEditar.Nome;
        }

        private void bttn_EdicaoModeloSalvar_Click(object sender, EventArgs e)
        {
            var novoNome = tBox_EdicaoModeloNome.Text;
            var novaSituacao = cBox_EdicaoModeloSituacao.SelectedIndex;
            var novaMarca = cBox_EdicaoModeloMarca.SelectedIndex + 1;

            if (!string.IsNullOrEmpty(novoNome))
            {
                SalvarAlteracoes(novaMarca, _modeloAEditar.Id, novaSituacao, novoNome);
                _controleModelo.RecarregarTabela(_controleModelo.BuscarModelos());
            }
        }

        private void SalvarAlteracoes(int idMarca, int idModelo, int idSituacao, string nomeModelo)
        {
            try
            {
                var query = $"UPDATE Modelo SET fk_id_situacao = {idSituacao}, fk_id_marca = {idMarca}, nome = '{nomeModelo}' WHERE pk_id_modelo = {idModelo}";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Modelo editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar modelo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}