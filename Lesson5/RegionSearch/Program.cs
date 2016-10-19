using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegionSearch.Managers;

namespace RegionSearch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm();

            while (loginForm.ShowDialog() == DialogResult.OK)
            {
                Authorization auth = new Authorization();
                if (loginForm.ShowDialog() == DialogResult.OK) {
                    if (auth.IsConnected(loginForm.inputLogin.Text, loginForm.inputPassword.Text)) {
                        Application.Run(new MainForm(auth.ConnectString));
                    }
                }
                else {
                    MessageBox.Show("Ivalid login or password");
                }
            }
           
        }
    }
}
