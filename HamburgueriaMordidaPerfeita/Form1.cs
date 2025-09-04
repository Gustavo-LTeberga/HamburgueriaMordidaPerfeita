using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgueriaMordidaPerfeita {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

        }

        private void btnEnter_Click(object sender, EventArgs e) {

            if (txbEmail.Text.Length < 6) {
                MessageBox.Show("digite um email válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbPassword.Text.Length < 4) {
                MessageBox.Show("digite uma senha válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Model.Users usuario = new Model.Users();  

                usuario.Email = txbEmail.Text.ToLower();
                usuario.Senha = txbPassword.Text;

                DataTable result = usuario.Logar();

                if (result.Rows.Count == 0) {
                    MessageBox.Show("email ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    usuario.Id = int.Parse(result.Rows[0]["id"].ToString());
                    usuario.NomeCompleto = result.Rows[0]["nome_completo"].ToString();

                    InitialMenu initialmenu = new InitialMenu(usuario);
                    Hide();
                    initialmenu.ShowDialog();

                    Show();
                }

            }


        }

        private void txbEmail_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                txbPassword.Focus();
            }
        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnEnter.PerformClick();
            }
        }
    }
}
