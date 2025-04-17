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
    public partial class CadastroSituacao : Form
    {
        private ControleSituacao _controleSituacao;

        public CadastroSituacao()
        {
            InitializeComponent();

            CenterToParent();
        }

        public CadastroSituacao(ControleSituacao controleSituacao)
        {
            InitializeComponent();
            _controleSituacao = controleSituacao;

            CenterToParent();
        }

        private void bttn_CadastroSituacaoSalvar_Click(object sender, EventArgs e)
        {
            CadastrarSituacao(tBox_CadastroSituacaoValor.Text);

            _controleSituacao.RecarregarTabela(_controleSituacao.BuscarSituacoes());
        }

        private void CadastrarSituacao(string valor)
        {
            try
            {
                using (var comando = new SqlCommand($"INSERT INTO Situacao (Valor) VALUES ('{valor}')", GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    var linhasAfetadas = comando.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        MessageBox.Show("Situação cadastrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Verifique os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao cadastrar situação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tBox_CadastroSituacaoValor.Clear();
            _controleSituacao.RecarregarTabela(_controleSituacao.BuscarSituacoes());
        }
    }
}