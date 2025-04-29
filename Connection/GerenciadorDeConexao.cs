using InventarioTI.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace InventarioTI.Connection
{
    public class GerenciadorDeConexao
    {
        public static string StringDeConexao = "";
        public SqlConnection ConexaoSql { get; private set; }
        public static GerenciadorDeConexao Instancia { get { return new GerenciadorDeConexao(); } }
        public bool ConseguiuConectar { get; private set; }

        public GerenciadorDeConexao()
        {
            Conectar(StringDeConexao);
        }

        public GerenciadorDeConexao(string instancia)
        {
            StringDeConexao = $"Server={instancia};Database=InventarioTI;User Id=sa; Password=@112658n;Integrated Security=True;Trust Server Certificate=True";
            Conectar(StringDeConexao);
        }

        private void Conectar(string conexao)
        {
            try
            {
                ConexaoSql = new SqlConnection(conexao);
                ConexaoSql.Open();

                if (ConexaoSql.State == ConnectionState.Open)
                    ConseguiuConectar = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConseguiuConectar = false;
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