using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_controle_estoque
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_usuario cad_user = new Cad_usuario();
            cad_user.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_fornecedor cad_forn = new Cad_fornecedor();
            cad_forn.Show();

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_Produto cad_prod = new Cad_Produto();
            cad_prod.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

           if (MessageBox.Show("Deseja Realmente Sair ?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
               Application.Exit();
           }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cad_usuario cad_user = new Cad_usuario();
            cad_user.MdiParent = this;
            cad_user.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cad_fornecedor cad_forn = new Cad_fornecedor();
            cad_forn.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cad_categoria cad_cate = new Cad_categoria();
            cad_cate.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Cad_Produto cad_prod = new Cad_Produto();
            cad_prod.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_categoria cad_cate = new Cad_categoria();
            cad_cate.Show();
        }       

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex_user exibir_user = new Ex_user();
            exibir_user.Show();
        } 

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Research pesquisa = new Research();
            pesquisa.Show();
        }

        private void todosOsProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consul_produto consul_prod = new Consul_produto();
            consul_prod.Show();
        }

        private void todosOsFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consul_forn consul_forn = new Consul_forn();
            consul_forn.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Alter_prod alter_produt = new Alter_prod();
            alter_produt.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Alter_forn alter_forne = new Alter_forn();
            alter_forne.Show();
        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ex_user user = new Ex_user();
            user.Show();
        }
    }
}
