using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_controle_estoque
{
    public partial class Alter_prod : Form
    {
        public Alter_prod()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server = WAGNER\SQLEXPRESS; Database = STOCKSYSTEM; Trusted_Connection = True;";
            string commandstring = @"SELECT * FROM tb_cadprod WHERE id = '" + textBox1.Text + "'";

            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            SqlCommand comando = new SqlCommand(commandstring, conexao);
            comando.CommandText = commandstring;

            SqlDataReader Reader = comando.ExecuteReader();
            while (Reader.Read())
            {

                comboBox1.Text = Convert.ToString(Reader["fornecedor"]);
                textBox2.Text = Convert.ToString(Reader["desc_prod"]);
                comboBox2.Text = Convert.ToString(Reader["categoria"]);
                textBox6.Text = Convert.ToString(Reader["qtde"]);
                maskedTextBox3.Text = Convert.ToString(Reader["data_entra"]);
                maskedTextBox4.Text = Convert.ToString(Reader["data_venc"]);
                maskedTextBox1.Text = Convert.ToString(Reader["p_compra"]);
                maskedTextBox2.Text = Convert.ToString(Reader["p_venda"]);
                textBox7.Text = Convert.ToString(Reader["est_max"]);
                textBox8.Text = Convert.ToString(Reader["est_min"]);
                
                
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server = WAGNER\SQLEXPRESS; Database = STOCKSYSTEM; Trusted_Connection = True;";
            string commandstring = @"UPDATE  tb_cadprod SET fornecedor = '" + comboBox1.Text + "',desc_prod = '" + textBox2.Text + "',categoria = '" + comboBox2.Text + "',qtde = '" + textBox6.Text + "',data_entra = '" + maskedTextBox3.Text + "',data_venc = '" + maskedTextBox4.Text + "',p_compra = '" + maskedTextBox1.Text + "',p_venda = '" + maskedTextBox2.Text + "',est_max = '" + textBox7.Text + "',est_min = '" + textBox8.Text + "' WHERE id = '" + textBox1.Text + "'; ";
                                                                                                                                                                                                                                                                                                                                         //(       

            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox2.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox6.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maskedTextBox3.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maskedTextBox4.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (maskedTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maskedTextBox2.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox7.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox8.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                SqlCommand comando = new SqlCommand(commandstring, conexao);
                comando.ExecuteNonQuery();

                MessageBox.Show("Produto ou Material Atualizado com Sucesso !");

                comboBox1.Text = "";
                comboBox2.Text = "";
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
                maskedTextBox3.Text = "";
                maskedTextBox4.Text = "";
                textBox2.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";


            }
        }

        private void Alter_prod_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server = WAGNER\SQLEXPRESS; Database = STOCKSYSTEM; Trusted_Connection = True;";
            string commandstring = @"SELECT nm_fantasia FROM tb_cadforn";
            string commandstring1 = @"SELECT categoria FROM tb_categoria";

            SqlConnection conexao = new SqlConnection(connectionString);

            SqlCommand comando = new SqlCommand(commandstring, conexao);

            SqlCommand comando2 = new SqlCommand(commandstring1, conexao);

            comando.Connection = conexao;


            //combobox fornecedor
            try
            {
                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    comboBox1.Items.Add(leitor.GetValue(0));
                }
                conexao.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            //combobox categoria
            try
            {
                conexao.Open();
                SqlDataReader leitor2 = comando2.ExecuteReader();
                while (leitor2.Read())
                {
                    comboBox2.Items.Add(leitor2.GetValue(0));
                }
                conexao.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

                //comboBox1.Text = ""; 
                //textBox2.Text = "";
                //comboBox2.Text = "";
                //textBox6.Text = "";
                //maskedTextBox3.Text = "";
                //maskedTextBox4.Text = "";
                //maskedTextBox1.Text = "";
                //maskedTextBox2.Text = "";
                //textBox7.Text = "";
                //textBox8.Text = "";