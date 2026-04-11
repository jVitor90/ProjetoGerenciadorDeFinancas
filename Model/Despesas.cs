using MySqlConnector;
using System.Data;

namespace GerenciadorDeFinanças.Model
{
    internal class Despesas
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Observacao { get; set; }
        public int CategoriaId { get; set; }
        public int Pago { get; set; }
        public DateTime Data { get; set; }

        public DataTable ListarDespesas()
        {
            string comando = @"
                SELECT d.Id, d.Descricao, d.Valor, c.Nome AS Categoria,
                       d.Data, d.Pago, d.Observacao
                FROM despesas d
                INNER JOIN categorias c ON c.Id = d.CategoriaId
                ORDER BY d.Data DESC;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();

            DataTable tabela = new DataTable();

            // Garante que a coluna Pago seja sempre int,
            // independente do tipo retornado pelo MySQL (ulong, bool, sbyte, etc.)
            tabela.Columns.Add("Id", typeof(int));
            tabela.Columns.Add("Descricao", typeof(string));
            tabela.Columns.Add("Valor", typeof(double));
            tabela.Columns.Add("Categoria", typeof(string));
            tabela.Columns.Add("Data", typeof(DateTime));
            tabela.Columns.Add("Pago", typeof(int));
            tabela.Columns.Add("Observacao", typeof(string));

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    tabela.Rows.Add(
                        reader.IsDBNull(0) ? (object)DBNull.Value : Convert.ToInt32(reader[0]),
                        reader.IsDBNull(1) ? (object)DBNull.Value : reader.GetString(1),
                        reader.IsDBNull(2) ? (object)DBNull.Value : Convert.ToDouble(reader[2]),
                        reader.IsDBNull(3) ? (object)DBNull.Value : reader.GetString(3),
                        reader.IsDBNull(4) ? (object)DBNull.Value : reader.GetDateTime(4),
                        reader.IsDBNull(5) ? (object)DBNull.Value : Convert.ToInt32(reader[5]),  // Pago: sempre int
                        reader.IsDBNull(6) ? (object)DBNull.Value : reader.GetString(6)
                    );
                }
            }

            conexaoBD.Desconectar(con);
            return tabela;
        }

        public bool CadastrarDespesa()
        {
            string comando = @"
                INSERT INTO despesas (Descricao, Valor, Data, CategoriaId, Pago, Observacao)
                VALUES (@Descricao, @Valor, @Data, @CategoriaId, @Pago, @Observacao)";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@Descricao", Descricao);
            cmd.Parameters.AddWithValue("@Valor", Valor);
            cmd.Parameters.AddWithValue("@Data", Data.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@CategoriaId", CategoriaId);
            cmd.Parameters.AddWithValue("@Pago", Pago);
            cmd.Parameters.AddWithValue("@Observacao", Observacao ?? "");
            cmd.Prepare();

            try
            {
                bool ok = cmd.ExecuteNonQuery() > 0;
                conexaoBD.Desconectar(con);
                return ok;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        public DataTable ListarCategorias()
        {
            string comando = "SELECT Id, Nome FROM categorias WHERE Tipo = 'despesas' ORDER BY Nome;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();

            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public bool ExcluirDespesa(int id)
        {
            string comando = "DELETE FROM despesas WHERE Id = @Id";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Prepare();

            try
            {
                bool ok = cmd.ExecuteNonQuery() > 0;
                conexaoBD.Desconectar(con);
                return ok;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        public bool AlterarStatus(int id, int novoStatus)
        {
            string comando = "UPDATE despesas SET Pago = @Pago WHERE Id = @Id";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@Pago", novoStatus);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Prepare();

            try
            {
                bool ok = cmd.ExecuteNonQuery() > 0;
                conexaoBD.Desconectar(con);
                return ok;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}