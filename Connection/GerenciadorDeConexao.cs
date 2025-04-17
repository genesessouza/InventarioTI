using InventarioTI.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace InventarioTI.Connection
{
    public class GerenciadorDeConexao
    {
        private static string StringDeConexao = "Data Source=GENESES-PC\\SQLEXPRESS;Initial Catalog=InventarioTI;Integrated Security=True;Trust Server Certificate=True";
        public SqlConnection ConexaoSql { get; private set; }
        public static GerenciadorDeConexao Instancia { get { return new GerenciadorDeConexao(); } }

        public GerenciadorDeConexao()
        {
            Conectar();
        }

        private void Conectar()
        {
            try
            {
                ConexaoSql = new SqlConnection(StringDeConexao);
                ConexaoSql.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Desconectar()
        {
            try
            {
                if (ConexaoSql != null && ConexaoSql.State == ConnectionState.Open)
                {
                    ConexaoSql.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao desconectar do banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}