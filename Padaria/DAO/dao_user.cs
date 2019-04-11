using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Padaria.DAO
{
    class dao_user
    {

        public int getMatricula()
        {
            string cs;
            int result;
            MySqlConnection cn = new MySqlConnection();
            cs = "server=localhost;user id=root; password=''; database=dbo_padaria";
            cn.ConnectionString = cs;

            try
            {
                cn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Impossível comunicar com o servidor, favor verificar a sua conexão!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            string sqlQry = "SELECT max(idRF) from tb_funcionario";
            MySqlCommand cm = cn.CreateCommand();

            cm.CommandText = sqlQry;

            try
            {
                result = int.Parse(cm.ExecuteScalar().ToString());
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na consulta, favor consultar o administrador do banco de dados. \nCódigo de Erro: " + e, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        public void insertUser(string nome, string dtNasc, string cpf, string cep, string rua, string bairro, string city, string uf, string tel1, string tel2, int id, string login, string pass)
        {
            string cs, sqlQry;
            MySqlConnection cn = new MySqlConnection();
            cs = "server=localhost;user id=root; password=''; database=dbo_padaria";
            cn.ConnectionString = cs;

            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Impossível comunicar com o servidor, favor verificar a sua conexão!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            sqlQry = "INSERT INTO tb_funcionario(nmFunc, dtNasc, nrCpf, cep, logradouro, bairro, UF, nrTel1, nrTel2) VALUES(@name, @dtNasc, @cpf, @cep, @rua, @bairro, @UF, @tel1, @tel2)";

            MySqlCommand cm = cn.CreateCommand();
            cm.CommandText = sqlQry;
            cm.Parameters.AddWithValue("@nome", nome);
            cm.Parameters.AddWithValue("@dtNasc", dtNasc);
            cm.Parameters.AddWithValue("@cpf", cpf);
            cm.Parameters.AddWithValue("@cep", cep);
            cm.Parameters.AddWithValue("@rua", rua);
            cm.Parameters.AddWithValue("@bairro", bairro);
            cm.Parameters.AddWithValue("@UF", uf);
            cm.Parameters.AddWithValue("@tel1", tel1);
            cm.Parameters.AddWithValue("@tel2", tel2);

            try
            {
                cm.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na consulta, favor consultar o administrador do banco de dados. \nCódigo de Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlQry = "INSERT INTO tb_login(idRF, login, pass) VALUES(@id, @login, @pass)";

            cm.CommandText = sqlQry;
            cm.Parameters.AddWithValue("@id", id);
            cm.Parameters.AddWithValue("@login", login);
            cm.Parameters.AddWithValue("@pass", pass);


            try
            {
                cm.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na consulta, favor consultar o administrador do banco de dados. \nCódigo de Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            cn.Close();



        }


        public string doLogin(string user, string pass)
        {
            MySqlConnection cn = new MySqlConnection();
            string cs = "server=localhost;User id=root;passwor='';database=dbo_padaria";

            cn.ConnectionString = cs;

            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Impossível comunicar com o servidor, favor verificar a sua conexão!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            MySqlCommand cm = new MySqlCommand("SELECT * FROM tb_login WHERE login=@login and pass=@pass", cn);
            cm.Parameters.AddWithValue("@login", user);
            cm.Parameters.AddWithValue("@pass", pass);

            try
            {
                MySqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na consulta, favor consultar o administrador do banco de dados. \nCódigo de Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
