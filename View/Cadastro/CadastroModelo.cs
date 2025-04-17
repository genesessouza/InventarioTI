using InventarioTI.Connection;
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
        private ControleMarca _controleMarca;
        private ControleSituacao _controleSituacao;

        public CadastroModelo()
        {
            InitializeComponent();
        }

        public CadastroModelo(ControleModelo controleModelo)
        {
            InitializeComponent();
            _controleModelo = controleModelo;
            _controleMarca = new ControleMarca();
            _controleSituacao = new ControleSituacao();

            var marcas = _controleMarca.BuscarMarcas();
            foreach(var marca in marcas)
            {
                if (!cBox_CadastroModeloMarca.Items.Contains(marca.Nome))
                    cBox_CadastroModeloMarca.Items.Add(marca.Nome);
            }

            cBox_CadastroModeloMarca.SelectedIndex = 0;

            var situacoes = _controleSituacao.BuscarSituacoes();
            foreach (var situacao in situacoes)
            {
                if (!cBox_CadastroModeloSituacao.Items.Contains(situacao.Valor))
                    cBox_CadastroModeloSituacao.Items.Add(situacao.Valor);
            }

            cBox_CadastroModeloSituacao.SelectedIndex = 1;

            _controleModelo.RecarregarTabela(_controleModelo.BuscarModelos());

            CenterToScreen();
        }

        private void bttn_CadastroModeloSalvar_Click(object sender, EventArgs e)
        {
            CadastrarModelo(tBox_CadastroModeloDescricao.Text, cBox_CadastroModeloMarca.SelectedIndex + 1, cBox_CadastroModeloSituacao.SelectedIndex);

            _controleModelo.RecarregarTabela(_controleModelo.BuscarModelos());
        }

        private void CadastrarModelo(string nome, int idMarca, int idSituacao)
        {
            try
            {
                var query = $"INSERT INTO Modelo (nome, fk_id_marca, fk_id_situacao) VALUES ('{nome}', {idMarca}, {idSituacao})";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    var linhasAfetadas = comando.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        MessageBox.Show("Modelo cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Verifique os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao cadastrar Modelo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tBox_CadastroModeloDescricao.Clear();
        }
    }
}