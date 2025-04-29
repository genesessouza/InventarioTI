using InventarioTI.Connection;
using Microsoft.Data.SqlClient;

namespace InventarioTI.Model
{
    public class Situacao
    {
        public int Id { get; set; } = 0;
        public string Valor { get; set; } = string.Empty;

        public static async Task<bool> CadastrarSituacaoAsync(int ultimoId, string valor)
        {
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    using (var comando = new SqlCommand("INSERT INTO Situacao (pk_id_situacao, valor) VALUES (@ultimoId, @valor)", conexao))
                    {
                        comando.Parameters.AddWithValue("@ultimoId", ultimoId);
                        comando.Parameters.AddWithValue("@valor", valor);

                        var linhasAfetadas = await comando.ExecuteNonQueryAsync();
                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Erro ao cadastrar situação: {ex.Message}", ex);
            }
        }

        public static async Task<List<Situacao>> BuscarSituacoesAsync()
        {
            var situacoes = new List<Situacao>();

            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    using (var comando = new SqlCommand("SELECT * FROM Situacao ORDER BY pk_id_situacao", conexao))
                    {
                        using (var leitor = await comando.ExecuteReaderAsync())
                        {
                            while (await leitor.ReadAsync())
                            {
                                situacoes.Add(new Situacao
                                {
                                    Id = leitor.GetInt16(0),
                                    Valor = leitor.GetString(1)
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Erro ao buscar situações: {ex.Message}", ex);
            }

            return situacoes;
        }

        public static async Task<List<Situacao>> BuscarSituacoesPorNomeAsync(string valor)
        {
            var situacoes = new List<Situacao>();

            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    using (var comando = new SqlCommand("SELECT * FROM Situacao WHERE valor LIKE @valor", conexao))
                    {
                        comando.Parameters.AddWithValue("@valor", $"%{valor}%");

                        using (var leitor = await comando.ExecuteReaderAsync())
                        {
                            while (await leitor.ReadAsync())
                            {
                                situacoes.Add(new Situacao
                                {
                                    Id = leitor.GetInt16(0),
                                    Valor = leitor.GetString(1)
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Erro ao buscar situações por nome: {ex.Message}", ex);
            }

            return situacoes;
        }

        public static async Task<bool> EditarSituacaoSelecionadaAsync(int idSituacao, string novoValor)
        {
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    using (var comando = new SqlCommand("UPDATE Situacao SET valor = @novoValor WHERE pk_id_situacao = @id", conexao))
                    {
                        comando.Parameters.AddWithValue("@novoValor", novoValor);
                        comando.Parameters.AddWithValue("@id", idSituacao);

                        var linhasAfetadas = await comando.ExecuteNonQueryAsync();
                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Erro ao editar situação: {ex.Message}", ex);
            }
        }

        public static async Task<Situacao> ObterDadosDaSituacaoSelecionadaAsync(int idSituacaoSelecionada)
        {
            var situacaoSelecionada = new Situacao();

            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    using (var comando = new SqlCommand("SELECT pk_id_situacao, valor FROM Situacao WHERE pk_id_situacao = @id", conexao))
                    {
                        comando.Parameters.AddWithValue("@id", idSituacaoSelecionada);

                        using (var leitor = await comando.ExecuteReaderAsync())
                        {
                            if (await leitor.ReadAsync())
                            {
                                situacaoSelecionada.Id = leitor.GetInt16(0);
                                situacaoSelecionada.Valor = leitor.GetString(1);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Erro ao obter dados da situação selecionada: {ex.Message}", ex);
            }

            return situacaoSelecionada;
        }

        public static bool ExcluirSituacao(int id)
        {
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    using (var comando = new SqlCommand("DELETE FROM Situacao WHERE pk_id_situacao = @id", conexao))
                    {
                        comando.Parameters.AddWithValue("@id", id);

                        var linhasAfetadas = comando.ExecuteNonQuery();
                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Erro ao excluir situação: {ex.Message}", ex);
            }
        }
    }
}