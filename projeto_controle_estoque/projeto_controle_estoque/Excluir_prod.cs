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
    public partial class Excluir_prod : Form
    {
        public Excluir_prod()
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
            string commandstring = @"DELETE  FROM tb_cadprod WHERE id = '" + textBox1.Text + "'";

            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja Realmente Excluir Produto ou Material?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand comando = new SqlCommand(commandstring, conexao);
                comando.ExecuteNonQuery();

                MessageBox.Show("Produto ou Material Excluido Com Sucesso");

                this.Hide();
            }

            else
            {
                this.Hide();
            }
        }
    }
}
