using MySqlConnector;
using System.Data;

namespace GerenciadorDeFinanças.Model
{
    internal class Receitas
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Observacao { get; set; }
        public int CategoriaId { get; set; }
        public DateTime Data { get; set; }

        public DataTable ListarReceitas()
        {
            string comando = @"
                SELECT r.Id, r.Descricao, r.Valor, c.Nome AS Categoria, r.Data, r.Observacao
                FROM receitas r
                INNER JOIN categorias c ON c.Id = r.CategoriaId
                ORDER BY r.Data DESC;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();

            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public bool CadastrarReceita()
        {
            string comando = "INSERT INTO receitas (Descricao, Valor, Data, CategoriaId, Observacao) VALUES (@Descricao, @Valor, @Data, " +
                "@CategoriaId, @Observacao)";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@Descricao", Descricao);
            cmd.Parameters.AddWithValue("@Valor", Valor);
            cmd.Parameters.AddWithValue("@Data", Data.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@CategoriaId", CategoriaId);
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
            string comando = "SELECT Id, Nome FROM categorias WHERE Tipo = 'receita' ORDER BY Nome;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();

            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public bool ExcluirReceita(int id)
        {
            string comando = "DELETE FROM receitas WHERE Id = @Id";

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
    }
}