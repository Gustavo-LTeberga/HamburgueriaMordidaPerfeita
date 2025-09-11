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
    public partial class OrderSlips : Form {

        Model.Users users;
        public OrderSlips(Model.Users users) {
            InitializeComponent();
            this.users = users;
        }

            public void AtualizarDgv() {
                Model.Products produto = new Model.Products();

                dgvProdutos.DataSource = produto.Listar();
            }

            private void dgvLancamento_CellClick(object sender, DataGridViewCellEventArgs e) {
                int ls = dgvProdutos.SelectedCells[0].RowIndex;
                txbCodProduto.Text = dgvProdutos.Rows[ls].Cells[0].Value.ToString();
                txbProduto.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
            }

            private void btnComanda_Click(object sender, EventArgs e) {
                if (txbComanda.Text.Length == 0) {
                    MessageBox.Show("Infrome o nomero da comanda", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txbCodProduto.Text.Length == 0) {
                    MessageBox.Show("Infrome o COD do produto", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    grbInformacoes.Enabled = false;

                    grbLancamentos.Enabled = true;
                }
            }

            private void btnLancar_Click(object sender, EventArgs e) {
                if (txbQuantidade.Text.Length == 0) {
                    MessageBox.Show("Infrome a quantidade", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    Model.OrderTicket ordemComanda = new Model.OrderTicket();
                    ordemComanda.IdFicha = int.Parse(txbComanda.Text);
                    ordemComanda.IdProduto = int.Parse(txbCodProduto.Text);
                    ordemComanda.Quantidade = int.Parse(txbQuantidade.Text);
                    ordemComanda.IdResp = users.Id;

                    if (ordemComanda.Cadastrar()) {
                        MessageBox.Show("Lançamento efetuado", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        MessageBox.Show("Erro ap efetuar lançamento", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


            }
            private void ResetarCampos() {
                txbCodProduto.Clear();
                txbQuantidade.Clear();
                txbProduto.Clear();
                txbComanda.Clear();

                grbInformacoes.Enabled = false;
                grbLancamentos.Enabled = true;
            }

        }
}
