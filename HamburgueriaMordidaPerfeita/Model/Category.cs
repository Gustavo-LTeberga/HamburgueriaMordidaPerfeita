using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgueriaMordidaPerfeita.Model {
    public class Category {

        public int Id { get; set; }

        public string Nome { get; set; }

        public DataTable Listar() {

            string comando = "SELECT * FROM categorias ";

            DataBase conexaoBD = new DataBase();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;

        }

    }
}
