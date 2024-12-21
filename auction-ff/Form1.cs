using System.Windows.Forms;
using Microsoft.Win32;

namespace auction_ff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == string.Empty)
            {
                errorProvider1.SetError(login_username, "Email empty");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (login_password.Text == string.Empty)
            {
                errorProvider2.SetError(login_password, "Username empty");
            }
            else
            {
                errorProvider2.Clear();
            }


            if (login_username.Text != string.Empty
                && login_password.Text != string.Empty)
            {

                login_username.Text = "";
                login_password.Text = "";
            }


            Form3 fForm = new Form3();
            fForm.Show();
            this.Hide();
        }


        private void login_register_Click(object sender, EventArgs e)
        {
            Form2 sForm = new Form2();
            sForm.Show();
            this.Hide();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                login_password.UseSystemPasswordChar = true;
            }
            else
            {
                login_password.UseSystemPasswordChar = false;
            }
        }
    }
}
