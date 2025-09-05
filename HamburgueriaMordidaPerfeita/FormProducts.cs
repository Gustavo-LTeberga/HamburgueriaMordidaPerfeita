using HamburgueriaMordidaPerfeita.Model;
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
    public partial class FormProducts : Form {

        Model.Users users;

        int selectedID = 0;

        public FormProducts (Model.Users users) {
            InitializeComponent();
            this.users = users;
            ListarCategoriaCmb();
            UpdateDgv();
        }

        public int SplitarCategoria(string categor) {

            string linha = categor;
            string numero = linha.Split('-')[0].Trim();
            return int.Parse(numero);

        }
        public void UpdateDgv() {
            Model.Products products = new Model.Products();
            dgvProdutos.DataSource = products.Listar();
        }

        public void ListarCategoriaCmb() {
            
            Model.Category category = new Model.Category();

            DataTable table = category.Listar();

            foreach (DataRow dr in table.Rows) {

                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbcategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");

            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            if (txbNomeCadastro.Text.Length < 2) {
                MessageBox.Show("o nome deve ter no minimo 2 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategoriaCadastro.Text == "") {
                MessageBox.Show("selecione uma categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Model.Products registeredProducts = new Model.Products();

                registeredProducts.Nome = txbNomeCadastro.Text;
                registeredProducts.Preco = double.Parse(txbPrecoCadastro.Text);
                registeredProducts.IdCategoria = SplitarCategoria(cmbCategoriaCadastro.Text);
                registeredProducts.IdRespCadastro = users.Id;

                if (registeredProducts.Cadastrar()) {
                    MessageBox.Show("produto cadastrado com sucesso! ", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    UpdateDgv();
                    txbNomeCadastro.Clear();
                    txbPrecoCadastro.Clear();
                }
                else {
                    MessageBox.Show("erro ao cadastrar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e) {

            int ls = dgvProdutos.SelectedCells[0].RowIndex;

            txbNomeEditar.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
            txbPrecoEditar.Text = dgvProdutos.Rows[ls].Cells[2].Value.ToString();

            selectedID = (int)dgvProdutos.Rows[ls].Cells[0].Value;

            grbEditar.Enabled = true;

            lblApagar.Text = $"Selecione o usuário para apagar {dgvProdutos.Rows[ls].Cells[1].Value}";

            grbApagar.Enabled = true;

        }

        private void btnApagar_Click(object sender, EventArgs e) {
            DialogResult r = MessageBox.Show($"tem certeza que deseja apagar este produto? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes) {

                Model.Products deleteProduct = new Model.Products();
                deleteProduct.Id = selectedID;
                if (deleteProduct.Apagar()) {

                    MessageBox.Show("produto apagado com sucesso! ", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    ResetFields();
                }
                else {

                    MessageBox.Show("falha ao apagar o produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        public void ResetFields() {

            UpdateDgv();
            txbNomeEditar.Clear();
            txbPrecoEditar.Clear();

            selectedID = 0;

            lblApagar.Text = "Selecione o produto que deseja apagar.";

            grbApagar.Enabled = false;
            grbEditar.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e) {

            if (txbNomeEditar.Text.Length < 2) {
                MessageBox.Show("o nome deve ter no minimo 5 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbcategoriaEditar.Text == "") {
                MessageBox.Show("selecione uma categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                Model.Products editProduct = new Model.Products();

                editProduct.Id = selectedID;
                editProduct.Nome = txbNomeEditar.Text;
                editProduct.Preco = double.Parse(txbPrecoEditar.Text);
                editProduct.IdCategoria = SplitarCategoria(cmbcategoriaEditar.Text);


                if (editProduct.Modificar()) {
                    MessageBox.Show("produto editado com sucesso! ", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ResetFields();
                }
                else {
                    MessageBox.Show("erro ao editar o produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }



   

}
