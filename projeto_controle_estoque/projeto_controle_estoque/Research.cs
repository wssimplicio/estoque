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
    public partial class Research : Form
    {
        public Research()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Consul_produto consul_prod = new Consul_produto();
            consul_prod.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Consul_forn consul_forn = new Consul_forn();
            consul_forn.Show();
        }
    }
}
