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

        public string currentUser;
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

        private void mnItCadUser_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<UserForm>().Count() == 1)
            {
                MessageBox.Show("Utilize a tela de cadastro aberta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserForm user = new UserForm();
                user.MdiParent = this;
                user.Show();
            }
        }

        private void mnItCadProd_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadProdForm>().Count() == 1)
            {
                MessageBox.Show("Utilize a tela de cadastro aberta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CadProdForm cadProd = new CadProdForm();
                cadProd.MdiParent = this;
                cadProd.Show();
            }
        }

        private void consultaEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<EstoqueForm>().Count() == 1)
            {
                MessageBox.Show("Utilize a tela de cadastro aberta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EstoqueForm estoque = new EstoqueForm();
                estoque.MdiParent = this;
                estoque.Show();
            }
        }

        private void mnItLogout_Click(object sender, EventArgs e)
        {
            if (!mnItLogin.Visible)
            {
                DialogResult result = MessageBox.Show("Você deseja efetuar logout do sistema?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    List<Form> openForms = new List<Form>();
                    foreach (Form f in Application.OpenForms)
                    {
                        openForms.Add(f);
                    }

                    foreach (Form f in openForms)
                    {
                        if (f.Name != "MainForm")
                        {
                            f.Close();
                        }
                    }

                    mnProd.Enabled = false;
                    mnItCadUser.Visible = false;
                    mnItLogin.Visible = true;
                    mnItLogout.Visible = false;

                    currentUser = "";

                    

                    LoginForm login = new LoginForm();
                    login.MdiParent = this;
                    login.Show();
                    this.Text = "Gerenciamento de Padaria";
                }

            }
        }
    }
}
