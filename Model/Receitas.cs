using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string comando = "SELECT Descricao, Valor, Observacao, CategriaId, Data FROM receitas;";
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
            string comando = " INSERT INTO receitas (Descricao, Valor, Data, CategoriaId, Observacao) " +
                "VALUES (@Descricao, @Valor, @Data, @CategoriaId, @Observacao)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@Descricao", Descricao);
            cmd.Parameters.AddWithValue("@Valor", Valor);
            cmd.Parameters.AddWithValue("@Data", Data);
            cmd.Parameters.AddWithValue("@CategoriaId", CategoriaId);
            cmd.Parameters.AddWithValue("@Observacao", Observacao);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            // se deer erro vai desconectar do banco de dados
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }


    }
}
