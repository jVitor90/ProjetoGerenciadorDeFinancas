using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeFinanças.Model
{
    internal class Categorias
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }


        public DataTable ListarCategorias()
        {
            string comando = "SELECT * FROM categorias;";

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

        public bool CadastrarCategorias()
        {
            string comando = "INSERT INTO categorias (nome, tipo) " +
            "VALUES (@nome, @tipo)";
            Banco conexao = new Banco();
            MySqlConnection con = conexao.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@tipo", Tipo);
            cmd.Prepare();


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
            catch
            {
                conexao.Desconectar(con);
                return false;
            }

        }

        public bool ExcluiCategoria()
        {
            string comando = "DELETE FROM categorias WHERE Id = @Id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@Id", Id);

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
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
        public bool EditarCategoria()
        {
            string comando = "UPDATE categorias SET Nome = @Nome, Tipo = @Tipo = WHARE Id = @Id";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Tipo", Tipo);
            cmd.Parameters[0].Value = Id;

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
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}