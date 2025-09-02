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
    public partial class FormUsers : Form {
        Model.Users users;

        public FormUsers(Model.Users users) {
            InitializeComponent();
            this.users = users;

            UpdateDgv();

        }

        public void UpdateDgv() {
            dgvUsers.DataSource = users.Listar();
        }

        private void brnCadastrar_Click(object sender, EventArgs e) {

            if(txbNomeCompletoCadastro.Text.Length < 5) {
                MessageBox.Show("o nome deve ter no minimo 5 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailCadastro.Text.Length < 7) {
                MessageBox.Show("o nome deve ter no minimo 7 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaCadastro.Text.Length < 6) {
                MessageBox.Show("o nome deve ter no minimo 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Model.Users registeredUser  = new Model.Users();

                registeredUser.NomeCompleto = txbNomeCompletoCadastro.Text;
                registeredUser.Email = txbEmailCadastro.Text;
                registeredUser.Senha = txbSenhaCadastro.Text;

                if (registeredUser.Cadastrar()) {
                    MessageBox.Show("usuario cadastrado com sucesso! ", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    UpdateDgv();
                    txbNomeCompletoCadastro.Clear();
                    txbEmailCadastro.Clear();
                    txbSenhaCadastro.Clear();
                }
                else {
                    MessageBox.Show("erro ao cadastrar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        

        }
    }
}
