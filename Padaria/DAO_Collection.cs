using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2.DAO
{
    public class DAO_Collection
    {
        


        public DataTable selectAluno()
        {
            
            MySqlConnection msc = new MySqlConnection();
            string cs = "server=localhost;User id=root;password='';database=dbo_instituicao";
            string sqlStatement;


            msc.ConnectionString = cs;
            try
            {
                msc.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Impossível comunicar com o servidor, favor verificar a sua conexão!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlStatement = "SELECT * FROM tb_aluno";

            MySqlDataAdapter mda = new MySqlDataAdapter(sqlStatement, msc);

            DataSet ds = new DataSet();

            try
            {
                mda.Fill(ds);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na consulta, favor consultar o administrador do banco de dados. \nCódigo de Erro: " + e, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            
            msc.Close();

            return ds.Tables[0];

        }


        public void insertAluno(string nmAluno, DateTime dtNasc, string rg, string logrAluno, string bairro, string cidade, string uf)
        {
            MySqlConnection msc = new MySqlConnection();
            string cs = "server=localhost;User id=root;password='';database=dbo_instituicao";
            string sqlStatement;


            msc.ConnectionString = cs;
            try
            {
                msc.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Impossível comunicar com o servidor, favor verificar a sua conexão!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MySqlCommand cmm = new MySqlCommand();


            sqlStatement = "INSERT INTO tb_aluno(al_nome, al_dtNasc, al_rg, al_logradouro, al_bairro, al_cidade, al_uf) VALUES('"+nmAluno+"', '"+dtNasc.ToString("yyyy-MM-dd")+"', '" + rg + "', '" + logrAluno + "', '"+ bairro + "', '" + cidade + "', '" + uf + "')";

            cmm.CommandText = sqlStatement;
            cmm.Connection = msc;
            
           
            /*cmm.Parameters.Add("@person", MySqlDbType.VarChar).Value = nmAluno;
            cmm.Parameters.Add("@dtnasc", MySqlDbType.Date).Value = dtNasc.ToString("yyyy-MM-dd");
            cmm.Parameters.Add("@rg", MySqlDbType.VarChar).Value = rg;
            cmm.Parameters.Add("@logr", MySqlDbType.VarChar).Value = logrAluno;
            cmm.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = bairro;
            cmm.Parameters.Add("@city", MySqlDbType.VarChar).Value = cidade;
            cmm.Parameters.Add("@uf", MySqlDbType.VarChar).Value = uf;*/

            

            try
            {
                cmm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na consulta, favor consultar o administrador do banco de dados. \nCódigo de Erro: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            msc.Close();
        }
    
    }
}
