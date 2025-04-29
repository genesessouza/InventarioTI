using InventarioTI.Connection;
using Microsoft.Data.SqlClient;

namespace InventarioTI.Model
{
    public class Estoque
    {
        public int Id { get; set; } = 0;
        public int IdProduto { get; set; } = 0;
        public int IdMarca { get; set; } = 0;
        public int IdModelo { get; set; } = 0;
        public string Produto { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public int Quantidade { get; set; } = 0;

        public static async Task<List<Estoque>> BuscarQuantidadesAsync()
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Produto.pk_id_produto = Estoque.pk_id_estoque " +
                    "WHERE pk_id_estoque > -1 " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<List<Estoque>> BuscarQuantidadesPorProdutoAsync(int idProduto)
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Produto.pk_id_produto = Estoque.pk_id_estoque " +
                    "WHERE Estoque.pk_id_estoque = @idProduto " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<List<Estoque>> BuscarQuantidadesPorMarcaAsync(int idMarca)
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Produto.pk_id_produto = Estoque.pk_id_estoque " +
                    "WHERE produto.fk_id_marca = @idMarca " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<List<Estoque>> BuscarQuantidadesPorModeloAsync(int idModelo)
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Produto.pk_id_produto = Estoque.pk_id_estoque " +
                    "WHERE produto.fk_id_modelo = @idModelo " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<List<Estoque>> BuscarQuantidadesPorSituacaoAsync(int idSituacao)
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Produto.pk_id_produto = Estoque.pk_id_estoque " +
                    "WHERE produto.fk_id_situacao = @idSituacao " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<List<Estoque>> BuscarQuantidadesPorProdutoESituacaoAsync(int idProduto, int idSituacao)
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Produto.pk_id_produto = Estoque.pk_id_estoque " +
                    "WHERE produto.fk_id_situacao = @idSituacao " +
                    "AND produto.pk_id_produto = @idProduto " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<List<Estoque>> BuscarQuantidadesPorProdutoEMarcaAsync(int idProduto, int idMarca)
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Produto.pk_id_produto = Estoque.pk_id_estoque " +
                    "WHERE Produto.fk_id_marca = @idMarca " +
                    "AND Produto.pk_id_produto = @idProduto " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<List<Estoque>> BuscarQuantidadesPorProdutoEModeloAsync(int idProduto, int idModelo)
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Estoque.pk_id_estoque = Produto.pk_id_produto " +
                    "WHERE Produto.fk_id_modelo = @idModelo " +
                    "AND Produto.pk_id_produto = @idProduto " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<List<Estoque>> BuscarQuantidadesPorMarcaESituacaoAsync(int idMarca, int idSituacao)
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Produto.pk_id_produto = Estoque.pk_id_estoque " +
                    "WHERE produto.fk_id_marca = @idMarca " +
                    "AND produto.fk_id_situacao = @idSituacao " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<List<Estoque>> BuscarQuantidadesPorMarcaEModeloAsync(int idMarca, int idModelo)
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Produto.pk_id_produto = Estoque.pk_id_estoque " +
                    "WHERE produto.fk_id_marca = @idMarca " +
                    "AND produto.fk_id_modelo = @idModelo " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<List<Estoque>> BuscarQuantidadesPorModeloESituacaoAsync(int idModelo, int idSituacao)
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Produto.pk_id_produto = Estoque.pk_id_estoque " +
                    "WHERE produto.fk_id_modelo = @idModelo " +
                    "AND produto.fk_id_situacao = @idSituacao " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<List<Estoque>> BuscarQuantidadesPorMarcaModeloESituacaoAsync(int idMarca, int idModelo, int idSituacao)
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Produto.pk_id_produto = Estoque.pk_id_estoque " +
                    "WHERE produto.fk_id_marca = @idMarca " +
                    "AND produto.fk_id_situacao = @idSituacao " +
                    "AND produto.fk_id_modelo = @idModelo " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<List<Estoque>> BuscarQuantidadesPorProdutoModeloESituacaoAsync(int idProduto, int idModelo, int idSituacao)
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Produto.pk_id_produto = Estoque.pk_id_estoque " +
                    "WHERE produto.fk_id_modelo = @idModelo " +
                    "AND produto.fk_id_situacao = @idSituacao " +
                    "AND produto.pk_id_produto = @idProduto " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<List<Estoque>> BuscarQuantidadesPorProdutoMarcaESituacaoAsync(int idProduto, int idMarca, int idSituacao)
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Produto.pk_id_produto = Estoque.pk_id_estoque " +
                    "WHERE produto.fk_id_marca = @idMarca " +
                    "AND produto.fk_id_situacao = @idSituacao " +
                    "AND produto.pk_id_produto = @idProduto " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<List<Estoque>> BuscarQuantidadesPorProdutoMarcaModeloESituacaoAsync(int idProduto, int idMarca, int idModelo, int idSituacao)
        {
            var estoques = new List<Estoque>();
            try
            {
                var query =
                "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                "FROM Estoque " +
                    "JOIN Produto " +
                    "ON Produto.pk_id_produto = Estoque.pk_id_estoque " +
                    "WHERE produto.fk_id_marca = @idMarca " +
                    "AND produto.fk_id_situacao = @idSituacao " +
                    "AND produto.fk_id_modelo = @idModelo " +
                    "AND produto.pk_id_produto = @idProduto " +
                "ORDER BY pk_id_estoque";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                            estoques.Add(estoque);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return estoques;
        }

        public static async Task<Estoque> ObterDadosDoEstoqueAEditarAsync(int idEstoque)
        {
            var estoque = new Estoque();
            try
            {
                var query = 
                    "SELECT pk_id_estoque, Produto.descricao, quantidade " +
                    "FROM Estoque " +
                        "JOIN Produto " +
                        "ON Estoque.pk_id_estoque = Produto.pk_id_produto " +
                    "WHERE pk_id_estoque = @idEstoque";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idEstoque", idEstoque);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            estoque = new Estoque
                            {
                                Id = leitor.GetInt16(0),
                                Produto = leitor.GetString(1),
                                Quantidade = leitor.GetInt32(2)
                            };
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show($"Erro ao buscar estoque do produto selecionado: {ex.Message}", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return estoque;
        }

        public static async Task<bool> EditarEstoqueAsync(int idEstoque, int quantidade)
        {
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    var query = "UPDATE Estoque SET quantidade = @quantidade WHERE pk_id_estoque = @idEstoque";
                    using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                    {
                        comando.Parameters.AddWithValue("@quantidade", quantidade);
                        comando.Parameters.AddWithValue("@idEstoque", idEstoque);

                        var linhasAfetadas = comando.ExecuteNonQuery();
                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao cadastrar Estoque: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}