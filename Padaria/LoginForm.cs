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
            }
        }
    }
}
