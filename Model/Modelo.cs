using InventarioTI.Connection;
using Microsoft.Data.SqlClient;

namespace InventarioTI.Model
{
    public class Modelo
    {
        public int Id { get; set; } = 0;
        public int IdMarca { get; set; } = 0;
        public int IdSituacao { get; set; } = 0;
        public string Nome { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;

        public static async Task<List<Modelo>> BuscarModelosAsync()
        {
            var modelos = new List<Modelo>();
            try
            {
                var query =
                "SELECT pk_id_modelo, fk_id_marca, modelo.nome, marca.nome " +
                "FROM Modelo " +
                    "JOIN Marca " +
                    "ON Modelo.fk_id_marca = Marca.pk_id_marca " +
                    "WHERE pk_id_modelo > -1 " +
                "ORDER BY pk_id_modelo";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var modelo = new Modelo
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                Nome = leitor.GetString(2),
                                Marca = leitor.GetString(3)
                            };
                            modelos.Add(modelo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar modelos na database: " + ex.Message);
            }
            return modelos;
        }

        public static async Task<List<Modelo>> BuscarModelosPorDescricaoAsync(string descricao)
        {
            var modelos = new List<Modelo>();
            try
            {
                var query =
                "SELECT pk_id_modelo, fk_id_marca, modelo.nome, marca.nome " +
                "FROM Modelo " +
                    "JOIN Marca " +
                    "ON Modelo.fk_id_marca = Marca.pk_id_marca " +
                    "WHERE modelo.nome LIKE @descricao " +
                "ORDER BY pk_id_modelo";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@descricao", descricao);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var modelo = new Modelo
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                Nome = leitor.GetString(2),
                                Marca = leitor.GetString(3)
                            };
                            modelos.Add(modelo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar modelos por descrição na database: " + ex.Message);
            }
            return modelos;
        }

        public static async Task<List<Modelo>> BuscarModelosPorSituacaoAsync(int idSituacao)
        {
            var modelos = new List<Modelo>();
            try
            {
                var query =
                "SELECT pk_id_modelo, fk_id_marca, modelo.nome, marca.nome " +
                "FROM Modelo " +
                    "JOIN Marca " +
                    "ON Modelo.fk_id_marca = Marca.pk_id_marca " +
                    "WHERE modelo.fk_id_situacao = @idSituacao " +
                "ORDER BY pk_id_modelo";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var modelo = new Modelo
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                Nome = leitor.GetString(2),
                                Marca = leitor.GetString(3)
                            };
                            modelos.Add(modelo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar modelos por marca na database: " + ex.Message);
            }
            return modelos;
        }

        public static async Task<List<Modelo>> BuscarModelosPorMarcaAsync(int idMarca)
        {
            var modelos = new List<Modelo>();
            try
            {
                var query =
                "SELECT pk_id_modelo, fk_id_marca, modelo.nome, marca.nome " +
                "FROM Modelo " +
                    "JOIN Marca " +
                    "ON Modelo.fk_id_marca = Marca.pk_id_marca " +
                    "WHERE modelo.fk_id_marca = @idMarca " +
                "ORDER BY pk_id_modelo";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var modelo = new Modelo
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                Nome = leitor.GetString(2),
                                Marca = leitor.GetString(3)
                            };
                            modelos.Add(modelo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar modelos por marca na database: " + ex.Message);
            }
            return modelos;
        }

        public static async Task<List<Modelo>> BuscarModelosPorSituacaoEMarcaAsync(int idMarca, int idSituacao)
        {
            var modelos = new List<Modelo>();
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    var query = @"
                    SELECT pk_id_modelo, fk_id_marca, modelo.nome, marca.nome
                    FROM Modelo
                        JOIN Marca ON Modelo.fk_id_marca = Marca.pk_id_marca
                        WHERE Modelo.fk_id_marca = @idMarca 
                          AND Modelo.fk_id_situacao = @idSituacao 
                          AND Modelo.pk_id_modelo > -1
                    ORDER BY pk_id_modelo";

                    using (var comando = new SqlCommand(query, conexao))
                    {
                        // Adicionando parâmetros com tipos explícitos
                        comando.Parameters.AddWithValue("@idMarca", idMarca);
                        comando.Parameters.AddWithValue("@idSituacao", idSituacao);

                        using (var leitor = await comando.ExecuteReaderAsync())
                        {
                            while (await leitor.ReadAsync())
                            {
                                var modelo = new Modelo
                                {
                                    Id = leitor.GetInt16(0),
                                    IdMarca = leitor.GetInt16(1),
                                    Nome = leitor.GetString(2),
                                    Marca = leitor.GetString(3)
                                };
                                modelos.Add(modelo);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao buscar modelos na base de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return modelos;
        }

        public static async Task<List<Modelo>> BuscarModelosPorSelecaoEMarcaAsync(int idModeloSelecionado, int idMarca)
        {
            var modelos = new List<Modelo>();
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    var query = @"
                    SELECT pk_id_modelo, fk_id_marca, modelo.nome, marca.nome
                    FROM Modelo
                        JOIN Marca ON Modelo.fk_id_marca = Marca.pk_id_marca
                        WHERE Modelo.pk_id_modelo = @idModeloSelecionado 
                          AND Modelo.fk_id_marca = @idMarca 
                          AND Modelo.pk_id_modelo > -1
                    ORDER BY pk_id_modelo";

                    using (var comando = new SqlCommand(query, conexao))
                    {
                        // Adicionando parâmetros com tipos explícitos
                        comando.Parameters.AddWithValue("@idModeloSelecionado", idModeloSelecionado);
                        comando.Parameters.AddWithValue("@idMarca", idMarca);

                        using (var leitor = await comando.ExecuteReaderAsync())
                        {
                            while (await leitor.ReadAsync())
                            {
                                var modelo = new Modelo
                                {
                                    Id = leitor.GetInt16(0),
                                    IdMarca = leitor.GetInt16(1),
                                    Nome = leitor.GetString(2),
                                    Marca = leitor.GetString(3)
                                };
                                modelos.Add(modelo);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao buscar modelos na base de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return modelos;
        }

        public static async Task<List<Modelo>> BuscarModelosPorSelecaoESituacaoAsync(int idModeloSelecionado, int idSituacao)
        {
            var modelos = new List<Modelo>();
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    var query = @"
                    SELECT pk_id_modelo, fk_id_marca, modelo.nome, marca.nome
                    FROM Modelo
                        JOIN Marca ON Modelo.fk_id_marca = Marca.pk_id_marca
                        WHERE Modelo.pk_id_modelo = @idModeloSelecionado 
                          AND Modelo.fk_id_situacao = @idSituacao 
                          AND Modelo.pk_id_modelo > -1
                    ORDER BY pk_id_modelo";

                    using (var comando = new SqlCommand(query, conexao))
                    {
                        // Adicionando parâmetros com tipos explícitos
                        comando.Parameters.AddWithValue("@idModeloSelecionado", idModeloSelecionado);
                        comando.Parameters.AddWithValue("@idSituacao", idSituacao);

                        using (var leitor = await comando.ExecuteReaderAsync())
                        {
                            while (await leitor.ReadAsync())
                            {
                                var modelo = new Modelo
                                {
                                    Id = leitor.GetInt16(0),
                                    IdMarca = leitor.GetInt16(1),
                                    Nome = leitor.GetString(2),
                                    Marca = leitor.GetString(3)
                                };
                                modelos.Add(modelo);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao buscar modelos na base de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return modelos;
        }

        public static async Task<List<Modelo>> BuscarModelosPorSelecaoMarcaESituacaoAsync(int idModeloSelecionado, int idMarca, int idSituacao)
        {
            var modelos = new List<Modelo>();
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    var query = @"
                    SELECT pk_id_modelo, modelo.nome, fk_id_marca, marca.nome
                    FROM Modelo
                        JOIN Marca ON Modelo.fk_id_marca = Marca.pk_id_marca
                        WHERE Modelo.pk_id_modelo = @idModelo
                          AND Modelo.fk_id_marca = @idMarca 
                          AND Modelo.fk_id_situacao = @idSituacao 
                          AND Modelo.pk_id_modelo > -1
                    ORDER BY pk_id_modelo";

                    using (var comando = new SqlCommand(query, conexao))
                    {
                        // Adicionando parâmetros para evitar SQL Injection
                        comando.Parameters.AddWithValue("@idModelo", idModeloSelecionado);
                        comando.Parameters.AddWithValue("@idMarca", idMarca);
                        comando.Parameters.AddWithValue("@idSituacao", idSituacao);

                        using (var leitor = await comando.ExecuteReaderAsync())
                        {
                            while (await leitor.ReadAsync())
                            {
                                var modelo = new Modelo
                                {
                                    Id = leitor.GetInt16(0),
                                    Nome = leitor.GetString(1),
                                    IdMarca = leitor.GetInt16(2),
                                    Marca = leitor.GetString(3)
                                };
                                modelos.Add(modelo);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao buscar modelos na base de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return modelos;
        }

        public static async Task<Modelo> ObterDadosDoModeloSelecionadoAsync(int idModeloSelecionado)
        {
            Modelo modeloSelecionado = new Modelo();
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    using (var comando = new SqlCommand("SELECT pk_id_modelo, fk_id_marca, fk_id_situacao, nome FROM Modelo " +
                        "WHERE pk_id_modelo = @idModeloSelecionado",
                        conexao))
                    {
                        // Adicionando parâmetro para evitar SQL Injection
                        comando.Parameters.AddWithValue("@idModeloSelecionado", idModeloSelecionado);

                        using (var leitor = await comando.ExecuteReaderAsync())
                        {
                            if (await leitor.ReadAsync())
                            {
                                modeloSelecionado = new Modelo
                                {
                                    Id = leitor.GetInt16(0),
                                    IdMarca = leitor.GetInt16(1),
                                    IdSituacao = leitor.GetInt16(2),
                                    Nome = leitor.GetString(3)
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Não foi possível encontrar os dados do modelo selecionado: {ex.Message}", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return modeloSelecionado;
        }

        public static async Task<bool> CadastrarModeloAsync(int ultimoId, string nome, int idMarca, int idSituacao)
        {
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    using (var comando = new SqlCommand("INSERT INTO Modelo (pk_id_modelo, nome, fk_id_marca, fk_id_situacao) " +
                        "VALUES (@ultimoId, @nome, @idMarca, @idSituacao)",
                        conexao))
                    {
                        comando.Parameters.AddWithValue("@ultimoId", ultimoId);
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@idMarca", idMarca);
                        comando.Parameters.AddWithValue("@idSituacao", idSituacao);

                        var linhasAfetadas = await comando.ExecuteNonQueryAsync();
                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao cadastrar Modelo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static async Task<bool> EditarModeloAsync(int idMarca, int idModelo, int idSituacao, string nomeModelo)
        {
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    using (var comando = new SqlCommand("UPDATE Modelo SET fk_id_situacao = @idSituacao, fk_id_marca = @idMarca, nome = @nomeModelo " +
                        "WHERE pk_id_modelo = @idModelo",
                        conexao))
                    {
                        comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                        comando.Parameters.AddWithValue("@idMarca", idMarca);
                        comando.Parameters.AddWithValue("@nomeModelo", nomeModelo);
                        comando.Parameters.AddWithValue("@idModelo", idModelo);

                        var linhasAfetadas = await comando.ExecuteNonQueryAsync();
                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao editar modelo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static async Task<bool> ExcluirModeloAsync(int idModelo)
        {
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    var query = "DELETE FROM Modelo WHERE pk_id_modelo = @idModelo";
                    using (var comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@idModelo", idModelo);

                        var linhasAfetadas = await comando.ExecuteNonQueryAsync();
                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao excluir modelo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}