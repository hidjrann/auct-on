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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog1.FileName;
                    pictureBox1.Image = System.Drawing.Image.FromFile(selectedImagePath);

                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = "";
            richTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "Id empty!");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (textBox2.Text == string.Empty)
            {
                errorProvider2.SetError(textBox2, "Purchase price empty");
            }
            else
            {
                errorProvider2.Clear();
            }

            if (textBox3.Text == string.Empty)
            {
                errorProvider3.SetError(textBox3, "Sale empty");
            }
            else
            {
                errorProvider3.Clear();
            }
            if (richTextBox1.Text == string.Empty)
            {
                errorProvider4.SetError(richTextBox1, "Information empty");
            }
            else
            {
                errorProvider4.Clear();
            }
            if (pictureBox1.Image == null)
            {
                errorProvider5.SetError(pictureBox1, "Picture empty");
            }
            else
            {
                errorProvider5.Clear();
            }
            if (maskedTextBox1.Text == string.Empty)
            {
                errorProvider6.SetError(maskedTextBox1, "Date empty");
            }
            else
            {
                errorProvider6.Clear();
            }
            if (maskedTextBox1.Text == string.Empty)
            {
                errorProvider7.SetError(maskedTextBox1, "Date empty");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 fForm = new Form3();
            fForm.Show();
            this.Hide();
        }
    }
}
