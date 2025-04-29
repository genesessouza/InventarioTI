using InventarioTI.Connection;
using Microsoft.Data.SqlClient;
using System.Globalization;

namespace InventarioTI.Model
{
    public class Produto
    {
        public int Id { get; set; } = 0;
        public int IdMarca { get; set; } = 0;
        public int IdModelo { get; set; } = 0;
        public int IdSituacao { get; set; } = 0;
        public string Descricao { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public Decimal Preco { get; set; }

        public static string ConverterFormatoDePreco(decimal preco)
        {
            NumberFormatInfo formatoDePreco = CultureInfo.GetCultureInfo("pt-br").NumberFormat;
            formatoDePreco = (NumberFormatInfo)formatoDePreco.Clone();
            formatoDePreco.CurrencySymbol = "";
            return string.Format(formatoDePreco, "{0:C2}", preco).Trim();
        }

        public static decimal ConverterPrecoParaDecimal(string preco)
        {
            return Convert.ToDecimal(preco, System.Globalization.CultureInfo.CurrentCulture);
        }

        public static async Task<List<Produto>> BuscarProdutosAsync()
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE pk_id_produto > -1 " +
                "ORDER BY pk_id_produto";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos por situação na database: " + ex.Message);
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorProdutoAsync(int idProduto)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE Produto.pk_id_produto = @idProduto " +
                "ORDER BY pk_id_produto";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos por situação na database: " + ex.Message);
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorMarcaAsync(int idMarca)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE produto.fk_id_marca = @idMarca " +
                "ORDER BY pk_id_produto";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos por situação na database: " + ex.Message);
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorModeloAsync(int idModelo)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE produto.fk_id_modelo = @idModelo " +
                "ORDER BY pk_id_produto";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos por situação na database: " + ex.Message);
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorSituacaoAsync(int idSituacao)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE produto.fk_id_situacao = @idSituacao " +
                "ORDER BY pk_id_produto";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos por situação na database: " + ex.Message);
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorProdutoESituacaoAsync(int idProduto, int idSituacao)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE produto.fk_id_situacao = @idSituacao " +
                    "AND produto.pk_id_produto = @idProduto " +
                "ORDER BY pk_id_produto";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar produtos por situação na database: {ex.Message}");
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorProdutoEMarcaAsync(int idProduto, int idMarca)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE produto.pk_id_produto = @idProduto " +
                    "AND produto.fk_id_marca = @idMarca " +
                "ORDER BY pk_id_produto";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar produtos por situação na database: {ex.Message}");
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorProdutoEModeloAsync(int idProduto, int idModelo)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE produto.fk_id_modelo = @idModelo " +
                    "AND produto.pk_id_produto = @idProduto " +
                "ORDER BY pk_id_produto";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar produtos por situação na database: {ex.Message}");
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorMarcaEModeloAsync(int idMarca, int idModelo)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE produto.fk_id_modelo = @idModelo " +
                    "AND produto.fk_id_marca = @idMarca " +
                "ORDER BY pk_id_produto";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorMarcaESituacaoAsync(int idMarca, int idSituacao)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE produto.fk_id_marca = @idMarca " +
                    "AND produto.fk_id_situacao = @idSituacao " +
                "ORDER BY pk_id_produto";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorModeloESituacaoAsync(int idModelo, int idSituacao)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE produto.fk_id_modelo = @idModelo " +
                    "AND produto.fk_id_situacao = @idSituacao " +
                "ORDER BY pk_id_produto";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorMarcaModeloESituacaoAsync(int idMarca, int idModelo, int idSituacao)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE produto.fk_id_marca = @idMarca " +
                    "AND produto.fk_id_modelo = @idModelo " +
                    "AND produto.fk_id_situacao = @idSituacao " +
                "ORDER BY pk_id_produto";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorProdutoMarcaESituacaoAsync(int idProduto, int idMarca, int idSituacao)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE produto.fk_id_marca = @idMarca " +
                    "AND produto.fk_id_situacao = @idSituacao " +
                    "AND produto.pk_id_produto = @idProduto " +
                "ORDER BY pk_id_produto";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorProdutoMarcaEModeloAsync(int idProduto, int idMarca, int idModelo)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE produto.fk_id_marca = @idMarca " +
                    "AND produto.fk_id_modelo = @idModelo " +
                    "AND produto.pk_id_produto = @idProduto " +
                "ORDER BY pk_id_produto";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorProdutoModeloESituacaoAsync(int idProduto, int idModelo, int idSituacao)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE produto.fk_id_situacao = @idSituacao " +
                    "AND produto.fk_id_modelo = @idModelo " +
                    "AND produto.pk_id_produto = @idProduto " +
                "ORDER BY pk_id_produto";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return produtos;
        }

        public static async Task<List<Produto>> BuscarProdutosPorProdutoMarcaModeloESituacaoAsync(int idProduto, int idMarca, int idModelo, int idSituacao)
        {
            var produtos = new List<Produto>();
            try
            {
                var query =
                "SELECT pk_id_produto, Produto.fk_id_marca, Produto.fk_id_modelo, descricao, Marca.nome, Modelo.nome, preco " +
                "FROM Produto " +
                    "JOIN Marca " +
                    "ON Produto.fk_id_marca = Marca.pk_id_marca " +
                    "JOIN Modelo " +
                    "ON Produto.fk_id_modelo = Modelo.pk_id_modelo " +
                    "WHERE produto.pk_id_produto = @idProduto " +
                    "AND produto.fk_id_marca = @idMarca " +
                    "AND produto.fk_id_modelo = @idModelo " +
                    "AND produto.fk_id_situacao = @idSituacao " +
                "ORDER BY pk_id_produto";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        while (await leitor.ReadAsync())
                        {
                            var produto = new Produto
                            {
                                Id = leitor.GetInt16(0),
                                IdMarca = leitor.GetInt16(1),
                                IdModelo = leitor.GetInt16(2),
                                Descricao = leitor.GetString(3),
                                Marca = leitor.GetString(4),
                                Modelo = leitor.GetString(5),
                                Preco = leitor.GetDecimal(6)
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar estoques por situação na database: {ex.Message}");
            }
            return produtos;
        }

        public static async Task<Produto> ObterDadosDoProdutoSelecionadoAsync(int idProdutoSelecionado)
        {
            var produtoSelecionado = new Produto();
            try
            {
                var query =
                    "SELECT pk_id_produto, fk_id_marca, fk_id_modelo, fk_id_situacao, descricao, preco " +
                    "FROM Produto " +
                    "WHERE pk_id_produto = @idProdutoSelecionado";
                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idProdutoSelecionado", idProdutoSelecionado);

                    using (var leitor = await comando.ExecuteReaderAsync())
                    {
                        if (await leitor.ReadAsync())
                        {
                            produtoSelecionado.Id = leitor.GetInt16(0);
                            produtoSelecionado.IdMarca = leitor.GetInt16(1);
                            produtoSelecionado.IdModelo = leitor.GetInt16(2);
                            produtoSelecionado.IdSituacao = leitor.GetInt16(3);
                            produtoSelecionado.Descricao = leitor.GetString(4);
                            produtoSelecionado.Preco = leitor.GetDecimal(5);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Não foi possível encontrar os dados da marca selecionada: {ex.Message}", "Puxa vida...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return produtoSelecionado;
        }

        public static async Task<bool> CadastrarProdutoAsync(int ultimoId, int idMarca, int idModelo, int idSituacao, string descricao, decimal preco)
        {
            try
            {
                var query = "INSERT INTO Produto (pk_id_produto, fk_id_marca, fk_id_modelo, fk_id_situacao, descricao, preco) " +
                            "VALUES (@ultimoId, @idMarca, @idModelo, @idSituacao, @descricao, @preco)";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@ultimoId", ultimoId);
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    comando.Parameters.AddWithValue("@descricao", descricao);
                    comando.Parameters.AddWithValue("@preco", preco);

                    await comando.ExecuteNonQueryAsync();
                }

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao cadastrar produto: {ex.Message}", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return false;
        }

        public static async Task<bool> EditarProdutoAsync(int idProduto, int idMarca, int idModelo, int idSituacao, string descricao, decimal preco)
        {
            try
            {
                var query = "UPDATE Produto SET fk_id_marca = @idMarca, fk_id_modelo = @idModelo, fk_id_situacao = @idSituacao, " +
                    "descricao = @descricao, preco = @preco " +
                    "WHERE pk_id_produto = @idProduto";

                using (var comando = new SqlCommand(query, GerenciadorDeConexao.Instancia.ConexaoSql))
                {
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    comando.Parameters.AddWithValue("@idMarca", idMarca);
                    comando.Parameters.AddWithValue("@idModelo", idModelo);
                    comando.Parameters.AddWithValue("@idSituacao", idSituacao);
                    comando.Parameters.AddWithValue("@descricao", descricao);
                    comando.Parameters.AddWithValue("@preco", preco);

                    await comando.ExecuteNonQueryAsync();
                }

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao editar produto: {ex.Message}", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return false;
        }

        public static async Task<bool> ExcluirProdutoAsync(int idProduto)
        {
            try
            {
                using (var conexao = GerenciadorDeConexao.Instancia.ConexaoSql)
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                        await conexao.OpenAsync();

                    var query = "DELETE FROM Produto WHERE pk_id_produto = @idProduto";
                    using (var comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@idProduto", idProduto);

                        var linhasAfetadas = await comando.ExecuteNonQueryAsync();
                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao excluir produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}