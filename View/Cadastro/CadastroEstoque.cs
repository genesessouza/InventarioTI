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
    public partial class CadastroEstoque : Form
    {
        private ControleEstoque _controleEstoque;

        public CadastroEstoque()
        {
            InitializeComponent();

            CenterToScreen();
        }

        public CadastroEstoque(ControleEstoque controleEstoque)
        {
            InitializeComponent();
         
            CenterToScreen();
            _controleEstoque = controleEstoque;
        }

        private void bttn_CadastroEstoqueSalvar_Click(object sender, EventArgs e)
        {
            CadastrarEstoque(cBox_CadastroEstoqueProduto.SelectedIndex, Convert.ToInt32(tBox_CadastroEstoqueQuantidade.Text));

            //_controleEstoque.RecarregarTabela();
        }

        private void CadastrarEstoque(int produtoId, int quantidade)
        {
            try
            {
                var query = $"INSERT INTO Estoque (quantidade) VALUES ({produtoId}, {quantidade})";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    var linhasAfetadas = comando.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        MessageBox.Show("Estoque cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Verifique os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao cadastrar Estoque: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tBox_CadastroEstoqueQuantidade.Clear();
        }
    }
}