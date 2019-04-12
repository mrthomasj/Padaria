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
    public partial class UserForm : Form
    {
        Validacoes val = new Validacoes();

        public UserForm()
        {
            InitializeComponent();
            string[] UF = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };
            cmbBoxUf.Items.AddRange(UF);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            DAO.dao_user dao = new DAO.dao_user();

            txtMatric.Text = (dao.getMatricula() + 1).ToString();
            txtMatric.Enabled = false;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {

            if (val.checkEmpty(this) == false) return;
            if (val.validaCpfCnpj(txtCpf.Text, txtCpf) == false) return;
            if (val.validaData(txtDtNasc.Text, txtDtNasc) == false) return;
            if (val.validaNumero(txtTel1.Text, txtTel1) == false) return;
            if (val.validaNumero(txtTel2.Text, txtTel2) == false) return;
            if (val.validaNumero(txtCep.Text, txtCep) == false) return;
            if (txtCep.Text.Length != 8)
            {
                MessageBox.Show("CEP deve conter 8 digitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (val.validaUF(cmbBoxUf.SelectedItem.ToString(), cmbBoxUf) == false) return;
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, selecione um dos itens da lista.", "Erro");
                cmbBoxUf.Focus();
                return;
            }

            if(txtPass.Text != txtRePass.Text)
            {
                MessageBox.Show("Senhas não conferem, favor verificar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;

            }

            DAO.dao_user dao = new DAO.dao_user();

            dao.insertUser(txtNome.Text, DateTime.Parse(txtDtNasc.Text).ToString("yyyy-MM-dd"), 
                txtCpf.Text, txtCep.Text, txtLogr.Text, txtBairro.Text, txtCidade.Text, cmbBoxUf.Text,
                txtTel1.Text, txtTel2.Text, int.Parse(txtMatric.Text), txtLogin.Text, txtPass.Text);


            val.clearAll(panLogin);
            val.clearAll(panFunc);

        }

        
        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnShowRePass_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtRePass.UseSystemPasswordChar = false;
            }
        }

        private void btnShowRePass_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtRePass.UseSystemPasswordChar = true;
            }
        }
    }
}
