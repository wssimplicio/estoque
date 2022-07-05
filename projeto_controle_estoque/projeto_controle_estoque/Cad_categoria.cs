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
    public partial class Cad_categoria : Form
    {
        public Cad_categoria()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server = WAGNER\SQLEXPRESS; Database = STOCKSYSTEM; Trusted_Connection = True;";
            string commandstring = @"INSERT INTO tb_categoria (categoria, descricao) VALUES ('"+ textBox1.Text +"', '"+ richTextBox1.Text +"')";
            //string retorno = @"SELECT id FROM tb_categoria";

            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                SqlCommand comando = new SqlCommand(commandstring, conexao);
                comando.ExecuteNonQuery();

                MessageBox.Show("Categoria Cadastrada com Sucesso !");

                textBox1.Text = "";
                richTextBox1.Text = "";
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.MaxLength = 100;
        }
    }
}
