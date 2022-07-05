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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*string connectionString = @"Server = WAGNER\SQLEXPRESS; Database = STOCKSYSTEM; Trusted_Connection = True;";

            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT usuario, senha FROM tb_user WHERE usuario = '" + textBox1.Text + "' and senha ='" + textBox2.Text + "'", conexao);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows.Count == 1)
            {

                Home home = new Home();
                home.Show();

                //fecha a tela de login
                this.Hide();
            }*/
            if(textBox1.Text == "wagner" && textBox2.Text == "senha123")
            {
                Home home = new Home();
                home.Show();

                //fecha a tela de login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usario ou senha invalidos ! ", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
