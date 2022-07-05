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
    public partial class Alter_forn : Form
    {
        public Alter_forn()
        {
            InitializeComponent();

            this.comboBox1.Items.AddRange(new object[] {
            "Acre - AC",
            "Alagoas - AL",
            "Amapá - AP",
            "Amazonas - AM",
            "Bahia  - BA",
            "Ceará - CE",
            "Distrito Federal  - DF",
            "Espírito Santo - ES",
            "Goiás - GO",
            "Maranhão - MA",
            "Mato Grosso - MT",
           "Mato Grosso do Sul - MS",
            "Minas Gerais - MG",
            "Pará - PA",
            "Paraíba - PB",
            "Paraná - PR",
            "Pernambuco - PE",
            "Piauí - PI",
            "Rio de Janeiro - RJ",
            "Rio Grande do Norte - RN",
            "Rio Grande do Sul - RS",
            "Rondônia - RO",
            "Roraima - RR",
            "Santa Catarina - SC",
            "São Paulo - SP",
            "Sergipe - SE",
            "Tocantins - TO"

            });
        }

        private void Alter_forn_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             string connectionString = @"Server = WAGNER\SQLEXPRESS; Database = STOCKSYSTEM; Trusted_Connection = True;";
             string commandstring = @"SELECT * FROM tb_cadforn WHERE id = '"+textBox4.Text+"'";

             SqlConnection conexao = new SqlConnection(connectionString);
             conexao.Open();

             SqlCommand comando = new SqlCommand(commandstring, conexao);
             comando.CommandText = commandstring;

             SqlDataReader Reader = comando.ExecuteReader();
             while (Reader.Read())
             {
                 textBox2.Text = Convert.ToString(Reader["rz_social"]);
                 textBox3.Text = Convert.ToString(Reader["nm_fantasia"]);
                 maskedTextBox1.Text = Convert.ToString(Reader["cnpj"]);
                 maskedTextBox4.Text = Convert.ToString(Reader["inc_estadual"]);
                 maskedTextBox5.Text = Convert.ToString(Reader["cpf"]);
                 comboBox1.Text = Convert.ToString(Reader["estado"]);
                 maskedTextBox8.Text = Convert.ToString(Reader["cep"]);
                 textBox1.Text = Convert.ToString(Reader["complemento"]);
                 textBox6.Text = Convert.ToString(Reader["cidade"]);
                 textBox7.Text = Convert.ToString(Reader["endereco"]);
                 maskedTextBox2.Text = Convert.ToString(Reader["tel_1"]);
                 maskedTextBox3.Text = Convert.ToString(Reader["tel_2"]);
                 maskedTextBox6.Text = Convert.ToString(Reader["celular"]);
                 maskedTextBox7.Text = Convert.ToString(Reader["fax"]);
                 textBox10.Text = Convert.ToString(Reader["email"]);
                 //rz_social,nm_fantasia,cnpj,inc_estadual,cpf,estado,cep,complemento,cidade,endereco,tel_1,tel_2,celular,fax,email
             }

             
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server = WAGNER\SQLEXPRESS; Database = STOCKSYSTEM; Trusted_Connection = True;";
            string commandstring = @"UPDATE tb_cadforn SET rz_social = '" + textBox2.Text + "', nm_fantasia = '" + textBox3.Text + "',cnpj = '" + maskedTextBox1.Text + "',inc_estadual = '" + maskedTextBox4.Text + "',cpf = '" + maskedTextBox5.Text + "',estado = '" + comboBox1.Text + "',cep = '" + maskedTextBox8.Text + "',complemento = '" + textBox1.Text + "',cidade = '" + textBox6.Text + "',endereco = '" + textBox7.Text + "',tel_1 = '" + maskedTextBox2.Text + "',tel_2 = '" + maskedTextBox3.Text + "',celular = '" + maskedTextBox6.Text + "',fax = '" + maskedTextBox7.Text + "',email = '" + textBox10.Text + "' WHERE id = '"+ textBox4.Text +"';";     

            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maskedTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maskedTextBox4.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maskedTextBox5.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maskedTextBox8.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox6.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox7.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maskedTextBox2.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maskedTextBox3.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maskedTextBox6.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maskedTextBox7.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox10.Text.Length == 0)
            {
                MessageBox.Show("Existem Campos em Branco !!!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                SqlCommand comando = new SqlCommand(commandstring, conexao);
                comando.ExecuteNonQuery();

                MessageBox.Show("Fornecedor Atualizado com Sucesso !");

                textBox4.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                maskedTextBox1.Text = "";
                maskedTextBox4.Text = "";
                maskedTextBox5.Text = "";
                comboBox1.Text = "";
                maskedTextBox8.Text = "";
                textBox1.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                maskedTextBox2.Text = ""; 
                maskedTextBox3.Text = "";
                maskedTextBox6.Text = "";
                maskedTextBox7.Text = "";
                textBox10.Text = "";
            }
        

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


                //textBox2.Text = "";
                //textBox3.Text = "";
               // maskedTextBox1.Text = "";
               //maskedTextBox4.Text = "";
               // maskedTextBox5.Text = "";
               // comboBox1.Text = "";
               // maskedTextBox8.Text = "";
               // textBox1.Text = "";
              //  textBox6.Text = "";
               // textBox7.Text = "";
               // maskedTextBox2.Text = ""; 
              //  maskedTextBox3.Text = "";
              //  maskedTextBox6.Text = "";
              //  maskedTextBox7.Text = "";
              //  textBox10.Text = "";