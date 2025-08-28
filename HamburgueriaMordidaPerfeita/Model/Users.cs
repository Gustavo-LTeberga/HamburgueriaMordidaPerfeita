using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgueriaMordidaPerfeita.Model {
    public class Users {

        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public DataTable Logar() {

            string comando = "SELECT * FROM usuarios WHERE email = @email AND senha = @senha";
            /*
            Caso vá utilizar o WHERE, empregue o uso de caracteres coringas,
            semelhante ao apresentado no metódo Cadastrar() acima.
            */
            DataBase conexaoBD = new DataBase();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            //hash
            String passwordhash = EasyEncryption.SHA.ComputeSHA256Hash(Senha);

            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@senha", passwordhash);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }


    }
}
