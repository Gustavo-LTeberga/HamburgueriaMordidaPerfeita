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
    public partial class Cash : Form {

        Model.Users users;
        public Cash(Model.Users users) {
            InitializeComponent();
            this.users = users;
        }
    }
}
