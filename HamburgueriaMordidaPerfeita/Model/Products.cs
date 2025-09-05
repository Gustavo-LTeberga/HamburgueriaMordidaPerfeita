using EasyEncryption;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HamburgueriaMordidaPerfeita.Model {
    public class Products {

        public int Id { get; set; } 

        public string Nome { get; set; }

        public double Preco { get; set; }

        public int IdCategoria { get; set; }

        public int IdRespCadastro { get; set; }

        Users Users = new Users();

        public DataTable Listar() {

            string comando = " SELECT produtos.*, usuarios.nome_completo, categorias.nome AS nome_categoria FROM produtos INNER JOIN usuarios ON produtos.id_respcadastro = usuarios.id INNER JOIN categorias ON produtos.id_categoria = categorias.id";
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


            string comand = "INSERT INTO produtos (nome, preco, id_categoria, id_respcadastro) VALUES " + "(@nome, @preco, @id_categoria, @id_respcadastro)";
            DataBase conexaoBD = new DataBase();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comand, con);

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@id_categoria", IdCategoria);
            cmd.Parameters.AddWithValue("@id_respcadastro", IdRespCadastro);
            


            

           

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

        public bool Apagar() {

            string comand = "DELETE FROM produtos WHERE id = @id";
            DataBase conexaoBD = new DataBase();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comand, con);

            cmd.Parameters.AddWithValue("@id", Id);

            cmd.Prepare();

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

        public bool Modificar() {

            string comand = "UPDATE produtos SET nome = @nome, " + "preco = @preco, id_Categoria = @id_categoria WHERE id = @id";
            DataBase conexaoBD = new DataBase();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comand, con);

            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@id_categoria", IdCategoria);


            cmd.Prepare();

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
