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

                usuario.Email = txbEmail.Text;
                usuario.Senha = txbPassword.Text;
            }


        }
    }
}
