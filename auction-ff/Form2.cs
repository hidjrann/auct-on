using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace auction_ff
{
    public partial class Form2 : Form
    {
        public Form2( )
        {
            InitializeComponent();            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string metn = register_username.Text;
            if (metn.Contains("@") && metn.Contains("."))
            {
                if (metn.IndexOf("@") - metn.IndexOf(".") == 1 ||
                     metn.IndexOf("@") - metn.IndexOf(".") == -1)
                {
                    errorProvider4.SetError(register_username, "Username is incorrect");
                    label5.Text = "Email is incorrect!";
                }
                else
                {
                    errorProvider1.Clear();
                    label5.Text = " ";
                }
            }
            else
            {
                label5.Text = "Email is incorrect!";
            }

            string username = register_username.Text;
            string pasword = register_password.Text;
            string email = register_email.Text;



            if (register_email.Text == string.Empty)
            {
                errorProvider1.SetError(register_email, "Email empty");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (register_username.Text == string.Empty)
            {
                errorProvider2.SetError(register_username, "Username empty");
            }
            else
            {
                errorProvider2.Clear();
            }

            if (register_password.Text == string.Empty)
            {
                errorProvider3.SetError(register_password, "Password empty");
            }
            else
            {
                errorProvider3.Clear();
            }

            if (register_email.Text != string.Empty && register_username.Text != string.Empty
                && register_password.Text != string.Empty)
            {
                dataGridView.Rows.Add(username, pasword);
                register_email.Text = "";
                register_username.Text = "";
                register_password.Text = "";
            }
            else
            {
                MessageBox.Show("Pls,Enter Username and Password ");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_login_Click(object sender, EventArgs e)
        {
            Form1 lForm = new Form1();
            lForm.Show();
            this.Hide();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                register_password.UseSystemPasswordChar = true;
            }
            else
            {
                register_password.UseSystemPasswordChar = false;
            }
        }
    }
}
