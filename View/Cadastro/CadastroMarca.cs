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
        private ControleSituacao _controleSituacao;
        private int _ultimoIdCadastrado = 0;

        public CadastroMarca()
        {
            InitializeComponent();
            _controleSituacao = new ControleSituacao();

            var situacoes = _controleSituacao.BuscarSituacoes();

            foreach (var situacao in situacoes)
                cBox_MarcaSituacao.Items.Add(situacao.Valor);

            cBox_MarcaSituacao.SelectedIndex = 1;

            CenterToScreen();
        }

        public CadastroMarca(ControleMarca controleMarca)
        {
            InitializeComponent();
            _controleMarca = controleMarca;
            _controleSituacao = new ControleSituacao();

            var situacoes = _controleSituacao.BuscarSituacoes();

            foreach (var situacao in situacoes)
                cBox_MarcaSituacao.Items.Add(situacao.Valor);

            cBox_MarcaSituacao.SelectedIndex = 1;

            _controleMarca.RecarregarTabela(_controleMarca.BuscarMarcas());

            CenterToScreen();
        }

        private void bttn_CadastroMarcaSalvar_Click(object sender, EventArgs e)
        {
            CadastrarMarca(tBox_CadastroMarcaNome.Text, cBox_MarcaSituacao.SelectedIndex);

            _controleMarca.RecarregarTabela(_controleMarca.BuscarMarcas());
        }

        private void CadastrarMarca(string nome, int idSituacao)
        {
            try
            {
                var query = $"SELECT pk_id_marca FROM Marca";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    var leitor = comando.ExecuteReader();

                    while (leitor.Read())
                        _ultimoIdCadastrado = leitor.GetInt16(0);
                }

                query = $"INSERT INTO Marca (pk_id_marca, nome, fk_id_situacao) VALUES ({_ultimoIdCadastrado + 1}, '{nome}', {idSituacao})";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    var linhasAfetadas = comando.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        MessageBox.Show("Marca cadastrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Verifique os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao cadastrar Marca: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tBox_CadastroMarcaNome.Clear();
        }
    }
}