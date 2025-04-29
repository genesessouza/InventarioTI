using InventarioTI.Connection;
using Microsoft.Data.SqlClient;
using System.Drawing;

namespace InventarioTI.Model
{
    public class Marca
    {
        public int Id { get; set; } = 0;
        public int IdSituacao { get; set; } = 0;
        public string Nome { get; set; } = string.Empty;

        public static async Task<List<Marca>> BuscarMarcasAsync()
        {
            var marcas = new List<Marca>();
            try
            {
                var query = "SELECT * FROM Marca WHERE pk_id_marca > -1 ORDER BY pk_id_marca";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var marca = new Marca
                            {
                                Id = leitor.GetInt16(0),
                                Nome = leitor.GetString(2)
                            };
                            marcas.Add(marca);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar marcas por situação na database: " + ex.Message);
            }
            return marcas;
        }

        public static async Task<List<Marca>> BuscarMarcasPorSituacaoAsync(int idSituacao)
        {
            var marcas = new List<Marca>();
            try
            {
                var query = "SELECT pk_id_marca, nome FROM Marca WHERE fk_id_situacao = @idSituacao AND pk_id_marca > -1 ORDER BY pk_id_marca";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var marca = new Marca
                            {
                                Id = leitor.GetInt16(0),
                                Nome = leitor.GetString(1)
                            };
                            marcas.Add(marca);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar marcas por situação na database: " + ex.Message);
            }
            return marcas;
        }

        public static async Task<List<Marca>> BuscarMarcasPorSelecaoAsync(int idMarcaSelecionada)
        {
            var marcas = new List<Marca>();
            try
            {
                var query = "SELECT pk_id_marca, nome FROM Marca WHERE pk_id_marca = @idMarca AND pk_id_marca > -1 ORDER BY pk_id_marca";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idMarca", idMarcaSelecionada);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var marca = new Marca
                            {
                                Id = leitor.GetInt16(0),
                                Nome = leitor.GetString(1)
                            };
                            marcas.Add(marca);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar marcas por situação na database: " + ex.Message);
            }
            return marcas;
        }

        public static async Task<List<Marca>> BuscarMarcasPorSelecaoESituacaoAsync(int idMarcaSelecionada, int idSituacao)
        {
            var marcas = new List<Marca>();
            try
            {
                var query = "SELECT pk_id_marca, nome " +
                    "FROM Marca " +
                    "WHERE pk_id_marca = @idMarca AND fk_id_situacao = @idSituacao AND pk_id_marca > -1 " +
                    "ORDER BY pk_id_marca";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idMarca", idMarcaSelecionada);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var marca = new Marca
                            {
                                Id = leitor.GetInt16(0),
                                Nome = leitor.GetString(1)
                            };
                            marcas.Add(marca);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar marcas por situação na database: " + ex.Message);
            }
            return marcas;
        }

        public static async Task<Marca> ObterDadosDaMarcaSelecionadaAsync(int idMarcaSelecionada)
        {
            var marcaSelecionada = new Marca();
            try
            {
                var query = "SELECT pk_id_marca, fk_id_situacao, nome FROM Marca WHERE pk_id_marca = @idMarcaSelecionada";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idMarcaSelecionada", idMarcaSelecionada);

                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        if (await leitor.ReadAsync())
                        {
                            marcaSelecionada.Id = leitor.GetInt16(0);
                            marcaSelecionada.IdSituacao = leitor.GetInt16(1);
                            marcaSelecionada.Nome = leitor.GetString(2);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Não foi possível encontrar os dados da marca selecionada: {ex.Message}", "Puxa vida...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return marcaSelecionada;
        }

        public static async Task<bool> CadastrarMarcaAsync(int ultimoId, string nome, int idSituacao)
        {
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    using (var comando = new SqlCommand("INSERT INTO Marca (pk_id_marca, nome, fk_id_situacao) " +
                        "VALUES (@ultimoId, @nome, @idSituacao)", conexao))
                    {
                        comando.Parameters.AddWithValue("@ultimoId", ultimoId);
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@idSituacao", idSituacao);

                        var linhasAfetadas = await comando.ExecuteNonQueryAsync();
                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Erro ao editar marca: {ex.Message}", ex);
            }
        }

        public static async Task<bool> EditarMarcaAsync(int id, int idSituacao, string nome)
        {
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    using (var comando = new SqlCommand("UPDATE Marca SET fk_id_situacao = @idSituacao, nome = @nome WHERE pk_id_marca = @id", 
                        GerenciadorDeConexao.Instancia.ConexaoSql))
                    {
                        comando.Parameters.AddWithValue("@id", id);
                        comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                        comando.Parameters.AddWithValue("@nome", nome);
                        return await comando.ExecuteNonQueryAsync() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao editar marca: ", ex);
            }
        }

        public static async Task<bool> ExcluirMarcaAsync(int idMarca)
        {
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();
                    
                    using (var comando = new SqlCommand("DELETE FROM Marca WHERE pk_id_marca = @idMarca", conexao))
                    {
                        comando.Parameters.AddWithValue("@idMarca", idMarca);
                        return await comando.ExecuteNonQueryAsync() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao excluir marca.", ex);
            }
        }
    }
}