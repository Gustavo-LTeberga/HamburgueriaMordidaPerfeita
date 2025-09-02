using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
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

        public DataTable Listar() {

            string comando = "SELECT id, nome_completo, email FROM usuarios";
         
            DataBase conexaoBD = new DataBase();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;

        }

        public bool Cadastrar() {
            string comand = "INSERT INTO usuarios (nome_completo, email, senha) VALUES " + "(@nome_completo, @email, @senha)";
            DataBase conexaoBD = new DataBase();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comand, con);

            cmd.Parameters.AddWithValue("@nome_completo", NomeCompleto);

            cmd.Parameters.AddWithValue("@email", Email);
            String passwordhash = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", passwordhash);

            // Obs.: Certifique-se de utilizar alguma método para obter o hash da senha antes de cadastrar!

            cmd.Prepare();

            // O trecho abaixo irá retornar true caso o cadastro dê certo:

            // Em caso de erro, experimente comentar o try/catch e executar novamente o código;

            // Grande parte dos problemas estão associados à um comando SQL incorreto. Verifique a string comando.

            try {

                if (cmd.ExecuteNonQuery() == 0) {

                    conexaoBD.Desconectar(con);

                    return false;

                }

                else {

                    conexaoBD.Desconectar(con);

                    return true;

                }

            }

            catch {

                conexaoBD.Desconectar(con);

                return false;

            }

        }


    }
}
