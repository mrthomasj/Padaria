using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Validacoes
    {
        public bool validaUF(string str, Control ct)
        {
            try
            {
                if (str.Length != 2) throw new Exception();

                return true;

            }
            catch (Exception)
            {

                MessageBox.Show("UF inválido, selecione um valor da lista.", "Erro");
                ct.Focus();
                return false;
            }


        }


        public bool validaData(string str, Control ct)
        {
            try
            {
                DateTime dt = DateTime.Parse(str);
                return true;

            }
            catch (Exception)
            {

                MessageBox.Show("Favor insira uma data no formato 'DD/MM/AAAA'", "Erro");
                ct.Text = "";
                ct.Focus();
                return false;
            }
        }


        public bool validaNumero(string str, Control ct)
        {
            try
            {
                int.Parse(str);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Dados inválidos! Por favor, insira apenas algarismos numéricos.", "Erro");
                ct.Focus();
                return false;
            }
        }

        public bool validaHr(string str, Control ct)
        {
            try
            {
                if (int.Parse(str[0].ToString()) > 2 || int.Parse(str[3].ToString()) >= 5) throw new Exception();
                if (int.Parse(str[0].ToString()) == 2 && int.Parse(str[1].ToString()) >= 3) throw new Exception();
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Horário inválido. Insira dados entre 00:00 e 23:59", "Erro");
                ct.Text = "";
                ct.Focus();
                return false;
            }
        }


        public bool validaCpfCnpj(string str, Control ct)
        {
            try
            {
                foreach(char ch in str)
                {
                    int i = int.Parse(ch.ToString());
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Favor somente preencher este campo com números.", "Erro");
                ct.Text = "";
                ct.Focus();
                return false;
               
            }

        }

        public bool checkEmpty(Form frm)
        {
            foreach(Control ct in frm.Controls)
            {

                if (ct is TextBox)
                {
                    try
                    {
                    
                        if (ct.Text == "") throw new Exception();
                            
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Favor preencher o campo vazio.", "Erro");
                        ct.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        public void clearAll(Form frm)
        {
            foreach(Control ct in frm.Controls)
            {
                if (ct is TextBox) ct.Text = "";
                if (ct is ComboBox) ct.Text = "";
            }
        }
    }
}
