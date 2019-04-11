using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Padaria.DAO
{
    public class dao_product
    {

        public void insertNewProd(string name, string marca, string categ, decimal vlr, int qtd)
        {
            MySqlConnection cn = new MySqlConnection();
            string cs = "server=localhost;User id=root;password='';database=dbo_padaria";
            cn.ConnectionString = cs;

            string sqlQry = "SELECT * FROM tb_produto WHERE nmProduto=@name and nmMarca=@brand and nmCategoria=@categ";

            try
            {
                cn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Impossível comunicar com o servidor, favor verificar a sua conexão!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            MySqlCommand cm = cn.CreateCommand();
            cm.CommandText = sqlQry;
            cm.Parameters.AddWithValue("@name", name);
            cm.Parameters.AddWithValue("@brand", marca);
            cm.Parameters.AddWithValue("@categ", categ);


            bool exists = true;

            try
            {
                MySqlDataReader reader = cm.ExecuteReader();
                if (!reader.Read())
                {
                    exists = false;
                }

                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }

            

            if (!exists)
            {
                sqlQry = "INSERT INTO tb_produto(nmProduto, nmMarca, nmCategoria, valProduto, qtdProduto) VALUES('" + name + "', '" + marca + "', '" + categ + "', '" + vlr + "', '" + qtd + "')";


                
                cm.CommandText = sqlQry;
                //cm.Parameters.AddWithValue("@name", name);
                //cm.Parameters.AddWithValue("@brand", marca);
                //cm.Parameters.AddWithValue("@categ", categ);

                //MySqlParameter value = cm.Parameters.Add("@value", MySqlDbType.Decimal);
                //value.Precision = 5;
                //value.Scale = 2;
                //value.Value = vlr.ToString().Replace(",", ".");



                //cm.Parameters.AddWithValue("@qtd", qtd.ToString());

                cm.Prepare();

                try
                {
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na consulta, favor consultar o administrador do banco de dados. \nCódigo de Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Produto já cadastrado!\nFavor utilizar a tela de manutenção de estoque para atualizar algum dado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cn.Close();
            
            
        }



        public DataTable qryProduct(Control ct, string param)
        {

            MySqlConnection cn = new MySqlConnection();
            string cs = "server=localhost;User id=root;password='';database=dbo_padaria";
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

            string sqlQry;

            MySqlDataAdapter da = new MySqlDataAdapter();

            switch (ct.Name)
            {
                case "btnNome":

                    sqlQry = "SELECT * FROM tb_produto WHERE nmProduto = '" + param + "'";
                    da.SelectCommand = new MySqlCommand(sqlQry, cn);
                    break;

                case "btnMarca":
                    sqlQry = "SELECT * FROM tb_produto WHERE nmMarca = '" + param + "'";
                    da.SelectCommand = new MySqlCommand(sqlQry, cn);
                    break;
                case "btnCateg":
                    sqlQry = "SELECT * FROM tb_produto WHERE nmCategoria = '" + param + "'";
                    da.SelectCommand = new MySqlCommand(sqlQry, cn);
                    break;
            }

            DataSet ds = new DataSet();

            try
            {
                da.Fill(ds);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na consulta, favor consultar o administrador do banco de dados. \nCódigo de Erro: " + e, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            cn.Close();

            return ds.Tables[0];

        }

    }
}
