using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auction_ff
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form3 fForm = new Form3();
            fForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bu potrenin satisi bitib");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bu potrenin satisi bitib");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bu potrenin satisi hele baslamayb");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form6 nForm = new Form6();
            nForm.Show();
            this.Hide();
        }
    }
}
