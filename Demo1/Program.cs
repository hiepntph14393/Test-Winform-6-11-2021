using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmHoTen());
            }
            else if (login.ShowDialog() == DialogResult.Yes)
            {               
                Application.Run(new frmColorFont());
            }
            else if (login.ShowDialog() == DialogResult.No)
            {
                Application.Run(new frmLighOnOff());
            }
        }
    }
}
