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
    public partial class frmLighOnOff : Form
    {
        public frmLighOnOff()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (picOff.Visible == true)
            {
                btnShow.Text = txtName.Text + ". Mở đèn ngay!";
            }
            else
            {
                btnShow.Text = txtName.Text + ". Tắt đèn ngay!";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (picOff.Visible == true)
            {
                picOn.Visible = true;
                picOff.Visible = false;
                btnShow.Text = btnShow.Text.Replace("Mở", "Tắt");
            }
            else
            {
                picOn.Visible = false;
                picOff.Visible = true;
                btnShow.Text = btnShow.Text.Replace("Tắt", "Mở");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
