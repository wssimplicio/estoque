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
    public partial class Consul_produto : Form
    {
        public Consul_produto()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Excluir_prod exc_prod = new Excluir_prod();
            exc_prod.Show();
        }

        private void Consul_produto_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server = WAGNER\SQLEXPRESS; Database = STOCKSYSTEM; Trusted_Connection = True;";
            string commandstring = @" SELECT id as Codigo,fornecedor as Forncedor,desc_prod as 'Descrição do Produto',categoria as Categoria,
                                             qtde as Quantidade,data_entra as 'Data de Entrada',data_venc as 'Data de Vencimento',
                                             p_compra as 'Preço de Compra ',p_venda as 'Preço de Venda',
                                             est_max as 'Estoque Maximo',est_min as 'Estoque Minimo'
                                        FROM tb_cadprod";

            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            SqlCommand comando = new SqlCommand(commandstring, conexao);
            comando.ExecuteNonQuery();

            SqlDataAdapter adpter = new SqlDataAdapter(comando);

            DataSet ds = new DataSet();
            adpter.Fill(ds, "Produto");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Produto";


            string commandstring1 = @"SELECT categoria FROM tb_categoria";
            SqlCommand comando2 = new SqlCommand(commandstring1, conexao);

            try
            {
                //conexao.Open();
                SqlDataReader leitor2 = comando2.ExecuteReader();
                while (leitor2.Read())
                {
                    comboBox1.Items.Add(leitor2.GetValue(0));
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server = WAGNER\SQLEXPRESS; Database = STOCKSYSTEM; Trusted_Connection = True;";
            string commandstring = @" SELECT id as Codigo,fornecedor as Forncedor,desc_prod as 'Descrição do Produto',categoria as Categoria,
                                             qtde as Quantidade,data_entra as 'Data de Entrada',data_venc as 'Data de Vencimento',
                                             p_compra as 'Preço de Compra ',p_venda as 'Preço de Venda',
                                             est_max as 'Estoque Maximo',est_min as 'Estoque Minimo'
                                        FROM tb_cadprod WHERE desc_prod = '"+ textBox1.Text  +"' or categoria = '"+ comboBox1.Text +"'";

            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            SqlCommand comando = new SqlCommand(commandstring, conexao);
            comando.ExecuteNonQuery();

            SqlDataAdapter adpter = new SqlDataAdapter(comando);

            DataSet ds = new DataSet();
            adpter.Fill(ds, "Produto");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Produto";
        }
    }
}
