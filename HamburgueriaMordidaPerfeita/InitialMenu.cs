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
    }
}
