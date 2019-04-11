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
    public partial class EstoqueForm : Form
    {
        public EstoqueForm()
        {
            InitializeComponent();
        }

        DAO.dao_product dao = new DAO.dao_product();

        private void btnNome_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            dgvProd.DataSource =  dao.qryProduct(btn, txtNome.Text);
            this.Width = 1100;

        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            dgvProd.DataSource = dao.qryProduct(btn, txtMarca.Text);
            this.Width = 1100;
        }

        private void btnCateg_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            dgvProd.DataSource = dao.qryProduct(btn, txtCat.Text);
            this.Width = 1100;
        }
    }
}
