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
    public partial class InitialMenu : Form {

        Model.Users users = new Model.Users();


        public InitialMenu(Model.Users usuario) {
            InitializeComponent();
            this.users = usuario;
            lblDesc.Text = $"Ola {usuario.NomeCompleto}";
        }

        private void btnUsers_Click(object sender, EventArgs e) {
            FormUsers formusers = new FormUsers(users);
            formusers.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e) {
            OrderSlips orderslip = new OrderSlips(users);
            orderslip.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e) {
            FormProducts formproducts = new FormProducts(users);    
            formproducts.ShowDialog();
        }

        private void btnCheckout_Click(object sender, EventArgs e) {
            Cash cash = new Cash(users);
            cash.ShowDialog();
        }
    }
}
