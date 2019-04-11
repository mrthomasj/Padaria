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
    public partial class CadProdForm : Form
    {
        public CadProdForm()
        {
            InitializeComponent();
        }

        Validacoes val = new Validacoes();

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (val.checkEmpty(this) == false) return;
            if (val.validaValor(txtVlr.Text, txtVlr) == false) return;
            if (val.validaNumero(txtQtd.Text, txtQtd) == false) return;

            DAO.dao_product dao = new DAO.dao_product();

            dao.insertNewProd(txtNome.Text, txtMarca.Text, txtCat.Text, decimal.Parse(txtVlr.Text), int.Parse(txtQtd.Text));
        }

        private void txtVlr_Leave(object sender, EventArgs e)
        {
            if (txtVlr.Text == "")
                txtVlr.Text = "00,00";
            
        }

        private void txtVlr_Enter(object sender, EventArgs e)
        {
            
            if(txtVlr.Text == "00,00")
                txtVlr.Text = "";

        }
    }
}
