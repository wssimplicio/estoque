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
    public partial class Consul_forn : Form
    {
        public Consul_forn()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Excluir_forn exc_forn = new Excluir_forn();
            exc_forn.Show();
        }

        private void Consul_forn_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server = WAGNER\SQLEXPRESS; Database = STOCKSYSTEM; Trusted_Connection = True;";
            string commandstring = @" SELECT id as Codigo, rz_social as 'Razão Social',nm_fantasia as 'Nome Fantasia',cnpj as CNPJ,
                                            inc_estadual as 'Inscrição Estadual',cpf as CPF,estado as Estado,    
                                            cep as CEP,complemento as Complemento,cidade as Cidade,
                                            endereco as Endereço ,tel_1 as 'Telefone 1',tel_2 as 'Telefone 2',
                                            celular as Celular,fax as Fax,email as 'E-Mail'
                                        FROM tb_cadforn";

            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            SqlCommand comando = new SqlCommand(commandstring, conexao);
            comando.ExecuteNonQuery();

            SqlDataAdapter adpter = new SqlDataAdapter(comando);

            DataSet ds = new DataSet();
            adpter.Fill(ds, "Fornecedor");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Fornecedor";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server = WAGNER\SQLEXPRESS; Database = STOCKSYSTEM; Trusted_Connection = True;";
            string commandstring = @"SELECT id as Codigo, rz_social as 'Razão Social',nm_fantasia as 'Nome Fantasia',cnpj as CNPJ,
                                            inc_estadual as 'Inscrição Estadual',cpf as CPF,estado as Estado,    
                                            cep as CEP,complemento as Complemento,cidade as Cidade,
                                            endereco as Endereço ,tel_1 as 'Telefone 1',tel_2 as 'Telefone 2',
                                            celular as Celular,fax as Fax,email as 'E-Mail'
                                     FROM tb_cadforn WHERE rz_social = '" + textBox2.Text + "' or id = '" + textBox1.Text + "'";
            


            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            SqlCommand comando = new SqlCommand(commandstring, conexao);
            comando.ExecuteNonQuery();

            SqlDataAdapter adpter = new SqlDataAdapter(comando);

            DataSet ds = new DataSet();
            adpter.Fill(ds, "Filtrar");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Filtrar";
        }
    }
}
