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
        public FormProducts (Model.Users users) {
            InitializeComponent();
            this.users = users;
            ListarCategoriaCmb();
        }

        public void ListarCategoriaCmb() {
            
            Model.Category category = new Model.Category();

            DataTable table = category.Listar();

            foreach (DataRow dr in table.Rows) {

                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbcategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");

            }

        }

    }

   

}
