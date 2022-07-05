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
    public partial class Cad_usuario : Form
    {
        public Cad_usuario()
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
           string commandstring = @"INSERT INTO tb_user (nome,data_nasc,cpf,funcao,usuario,senha) VALUES ('" + textBox1.Text +"','" + maskedTextBox1.Text +"','" + maskedTextBox2.Text +"','" + textBox5.Text +"','" + textBox2.Text +"','" + textBox3.Text +"'); ";

           SqlConnection conexao = new SqlConnection(connectionString);
           conexao.Open();

           if (textBox1.Text.Length == 0)
           {
               MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
           }

            if ( maskedTextBox1.Text.Length == 0)
           {
               MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
           }

            if ( maskedTextBox2.Text.Length== 0)
           {
               MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
           }

            if ( textBox5.Text.Length == 0)
           {
               MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
           }

            if ( textBox2.Text.Length == 0)
           {
               MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
           }

            if (textBox3.Text.Length == 0)
           {
               MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
           }

            if (textBox4.Text.Length == 0)
           {
               MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
           }

            //Faz comparação de senhas em seguida limpa os campos caso estejam erradas !!!
            if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Senhas não se coincidem !");

                textBox3.Text = "";
                textBox4.Text = "";
            }

            else
            {
                //Executa o Cadastro do usuario e limpa os campos em sequida !!!
                SqlCommand comando = new SqlCommand(commandstring, conexao);
                comando.ExecuteNonQuery();

                MessageBox.Show("Usuario Cadstrado com Sucesso !");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";

                
                
            }
        }
    }
}
