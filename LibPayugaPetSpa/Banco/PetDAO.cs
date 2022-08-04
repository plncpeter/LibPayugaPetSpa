using LibPayugaPetSpa.Classes;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPayugaPetSpa.Banco
{
    internal class PetDAO
    {
        // Cadastrar
        public static bool Cadastrar(Pet p)
        {
            string comando;
            comando = "INSERT INTO pet (nome, id_tipo, id_cliente) VALUES (@nome,@id_tipo,@id_cliente)";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            // Instanciar obj so tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@id_tipo", p.IdTipo);
            cmd.Parameters.AddWithValue("@id_cliente", p.IdCliente);

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
                return false;
            }

        }
        // ListarTodos
        public static DataTable ListarTudo()
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT * FROM view_pets";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public static DataTable BuscarNomePorID(int id)
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT nome FROM pet WHERE id = @id";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        // Modificar
        public static bool Modificar(Pet p)
        {
            string comando;
            comando = "UPDATE pet " +
            "SET nome = @nome, " +
            "id_tipo = @id_tipo, id_cliente = @id_cliente WHERE id = @id";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar obj so tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@id_tipo", p.IdTipo);
            cmd.Parameters.AddWithValue("@id_cliente", p.IdCliente);
            cmd.Parameters.AddWithValue("@id", p.Id);

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
                return false;
            }
        }
        // Apagar
        public static bool ApagarPorID(int id)
        {
            string comando;
            comando = "DELETE FROM pet WHERE id = @id";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar obj so tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", id);


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
                return false;
            }

        }
    }
}
