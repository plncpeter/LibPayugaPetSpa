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
    internal class OrdemDAO
    {
        public static bool Lancar(Ordem o)
        {
            string comando;
            comando = "INSERT INTO ordem_comanda (id_pet, " +
                "id_servicos) " +
                "VALUES (@id_pet, @id_servicos)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_pet", o.IdPet);
            cmd.Parameters.AddWithValue("@id_servicos", o.IdServicos);


            cmd.Prepare();
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
        public static DataTable BuscarFicha(int id)
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT * FROM view_comanda WHERE Comanda = @id";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public static bool Encerrar(int id)
        {
            string comando;

            comando = "UPDATE ordem_comanda " +
            "SET situacao = 0 WHERE " +
            "id_pet = @id AND situacao = 1";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySqlCommand":
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
