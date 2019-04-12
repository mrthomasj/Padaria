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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DAO.dao_user dao = new DAO.dao_user();
            string user = dao.doLogin(txtLogin.Text, txtPass.Text);
            if (user != null)
            {
                ((MainForm)this.MdiParent).mnItLogin.Visible = false;
                ((MainForm)this.MdiParent).mnItLogout.Visible = true;
                ((MainForm)this.MdiParent).mnProd.Enabled = true;
                if(user == "admin")
                {
                    ((MainForm)this.MdiParent).mnItCadUser.Visible = true;
                }
                ((MainForm)this.MdiParent).currentUser = user;

                ((MainForm)this.MdiParent).Text = "Gerenciamento de Padaria | Usuário ativo: " + user;

                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciais não conferem, favor verificar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void showPass_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void showPass_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnLogin_Click(btnLogin, e);
            }

        }
    }
}
