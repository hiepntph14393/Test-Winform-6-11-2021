using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "frmhoten" && txtPass.Text == "admin")
            {
                DialogResult = DialogResult.OK;
            }
            else if (txtUser.Text == "frmcolorfont" && txtPass.Text == "admin")
            {             
                DialogResult = DialogResult.Yes;
            }
            else if (txtUser.Text == "frmlightonoff" && txtPass.Text == "admin")
            {
                DialogResult = DialogResult.No;
            }
        }
    }
}
