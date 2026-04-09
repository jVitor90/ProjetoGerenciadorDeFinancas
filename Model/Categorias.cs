using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GerenciadorDeFinanças.Model
{
    internal class Categorias
    {
        public int Id { get; set; }
        public string nome_categoria { get; set; }
        public int tipo_categria { get; set; }


        public DataTable Listar()
        {
            string comando = "SELECT * FROM categoria;";

            Banco conexao = new Banco();
            MySqlConnection con = conexao.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // Aqui nos vamos declarar a tebela que ira receber o resultado
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexao.Desconectar(con);
            return tabela;
        }

        public bool Cadastrar()
        {
            string comando = "INSERT INTO categorias (nome, tipo) " +
                "VALUES (@nome, @tipo)";
            Banco conexao = new Banco();
            MySqlConnection con = conexao.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando,con);
            cmd.Parameters.AddWithValue("@nome", nome_categoria);
            cmd.Parameters.AddWithValue("@tipo", tipo_categria);
            cmd.Prepare();
            //impede que o programa possa quebrar
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexao.Desconectar(con);
                    return false;
                }
                else
                {
                    conexao.Desconectar(con);
                    return true;
                }
            }
            // de ser erro vai desconectar do banco de dados
            catch
            {
                conexao.Desconectar(con);
                return false;
            }

        }

        public bool Excluir()
        {
            string comando = "DELETE FROM categorias WHERE Id = @Id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@Id", Id);

            cmd.Prepare();
            // para impedir que o programa quebre 
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
            // se der erro, ele ira desconectar do bd
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}
