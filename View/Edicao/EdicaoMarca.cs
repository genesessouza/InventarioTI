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
        private ControleSituacao _controleSituacao;
        private ControleMarca _controleMarca;
        private Marca _marcaAEditar;

        public EdicaoMarca()
        {
            InitializeComponent();
        }

        public EdicaoMarca(ControleMarca controleMarca, Marca marcaAEditar)
        {
            InitializeComponent();
            _controleSituacao = new ControleSituacao();
            _controleMarca = controleMarca;

            _marcaAEditar = marcaAEditar;

            CenterToScreen();

            var situacoes = _controleSituacao.BuscarSituacoes();

            foreach (var situacao in situacoes)
                cBox_EdicaoMarcaSituacao.Items.Add(situacao.Valor);

            cBox_EdicaoMarcaSituacao.SelectedIndex = _marcaAEditar.IdSituacao;

            tBox_EdicaoMarcaNome.Text = _marcaAEditar.Nome;
        }

        private void bttn_EdicaoMarcaSalvar_Click(object sender, EventArgs e)
        {
            var novaSituacao = cBox_EdicaoMarcaSituacao.SelectedIndex;

            if (!string.IsNullOrEmpty(tBox_EdicaoMarcaNome.Text))
            {
                SalvarAlteracoes(_marcaAEditar.Id, novaSituacao, tBox_EdicaoMarcaNome.Text);
                _controleMarca.RecarregarTabela(_controleMarca.BuscarMarcasPorSituacao(_marcaAEditar.IdSituacao));
            }
            else
                MessageBox.Show("Nome não pode ser nulo", "Aviso", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
        }

        private void SalvarAlteracoes(int id, int idSituacao, string nome)
        {
            try
            {
                var query = $"UPDATE Marca SET fk_id_situacao = {idSituacao}, nome = '{nome}' WHERE pk_id_marca = {id}";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Marca editada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao editar marca: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}