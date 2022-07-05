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
    public partial class Cad_Produto : Form
    {
        public Cad_Produto()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Cad_Produto_Load(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           string connectionString = @"Server = WAGNER\SQLEXPRESS; Database = STOCKSYSTEM; Trusted_Connection = True;";
           string commandstring = @"INSERT INTO tb_cadprod (fornecedor,desc_prod,categoria,qtde,data_entra,data_venc,p_compra,p_venda,est_max,est_min) VALUES ('" + comboBox1.Text+"','" + textBox2.Text+"','" + comboBox2.Text +"','" + textBox6.Text +"','" + maskedTextBox3.Text +"','" + maskedTextBox4.Text +"','" + maskedTextBox1.Text +"','" + maskedTextBox2.Text +"','" + textBox7.Text +"','" + textBox8.Text +"')";
           string pagar = @"INSERT INTO tb_pagar (fornecedor,descricao_prod,dat_entra,valor,dat_venci,status) VALUES ('"+comboBox1.Text+"','"+textBox2.Text+"','"+maskedTextBox3.Text+"','"+label11.Text+"','"+label12.Text+"','Pendente')";


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

               SqlCommand pagar1 = new SqlCommand(pagar, conexao);
               pagar1.ExecuteNonQuery();

               MessageBox.Show("Cadastro Realizado com Sucesso !");

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
    }
}


                //DateTime date = DateTime.Now;
               //date = date.AddDays(30);
               //label12.Text = date.ToString();

               //double n1, n2, calc;

               //n1 = double.Parse(maskedTextBox1.Text);
               //n2 = double.Parse(textBox6.Text);
               //calc = n1 * n2;
               //label11.Text = calc.ToString();
           