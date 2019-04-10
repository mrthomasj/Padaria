using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(Application.OpenForms.OfType<LoginForm>().Count() == 1)
            {
                MessageBox.Show("Utilize a janela de login aberta.");
                Application.OpenForms.OfType<LoginForm>().First().Focus();

            }
            else
            {
                LoginForm login = new LoginForm();
                login.MdiParent = this;
                login.Show();
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.MdiParent = this;
            login.Show();
        }
    }
}
