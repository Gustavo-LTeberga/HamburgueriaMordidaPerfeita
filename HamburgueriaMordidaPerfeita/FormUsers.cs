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

        int selectedID = 0;

        public FormUsers(Model.Users users) {
            InitializeComponent();
            this.users = users;

            UpdateDgv();

        }

        public void UpdateDgv() {
            dgvUsers.DataSource = users.Listar();
        }

        private void brnCadastrar_Click(object sender, EventArgs e) {

            if (txbNomeCompletoCadastro.Text.Length < 5) {
                MessageBox.Show("o nome deve ter no minimo 5 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailCadastro.Text.Length < 7) {
                MessageBox.Show("o nome deve ter no minimo 7 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaCadastro.Text.Length < 6) {
                MessageBox.Show("o nome deve ter no minimo 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Model.Users registeredUser = new Model.Users();

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

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e) {


            int ls = dgvUsers.SelectedCells[0].RowIndex;

            txbNomeCompletoEditar.Text = dgvUsers.Rows[ls].Cells[1].Value.ToString();
            txbEmailEditar.Text = dgvUsers.Rows[ls].Cells[2].Value.ToString();

            selectedID = (int)dgvUsers.Rows[ls].Cells[0].Value;

            grbEditar.Enabled = true;

            lblApagar.Text = $"Selecione o usuário para apagar {dgvUsers.Rows[ls].Cells[1].Value}";

            grbApagar.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e) {
            DialogResult r = MessageBox.Show($"tem certeza que deseja apagar este usuario? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes) {

                Model.Users deleteUsers = new Model.Users();
                deleteUsers.Id = selectedID;
                if (deleteUsers.Apagar()) {

                    MessageBox.Show("usuario apagado com sucesso! ", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  
                    ResetFields();
                }
                else {

                    MessageBox.Show("falha ao apagar o usuario!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        public void ResetFields() {

            UpdateDgv();
            txbNomeCompletoCadastro.Clear();
            txbEmailCadastro.Clear();
            txbSenhaCadastro.Clear();

            selectedID = 0;

            lblApagar.Text = "Selecione o usuario que deseja apagar.";

            grbApagar.Enabled = false;
            grbEditar.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e) {

            if (txbNomeCompletoCadastro.Text.Length < 5) {
                MessageBox.Show("o nome deve ter no minimo 5 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailCadastro.Text.Length < 7) {
                MessageBox.Show("o nome deve ter no minimo 7 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaCadastro.Text.Length < 6) {
                MessageBox.Show("o nome deve ter no minimo 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                Model.Users editUsers = new Model.Users();

                editUsers.Id = selectedID;
                editUsers.NomeCompleto = txbNomeCompletoEditar.Text;
                editUsers.Email = txbEmailEditar.Text;
                editUsers.Senha = txbSenhaEditar.Text;

                if (editUsers.Modificar()) {
                    MessageBox.Show("usuario editado com sucesso! ", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ResetFields();
                }
                else {
                    MessageBox.Show("erro ao editar o usuario!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
