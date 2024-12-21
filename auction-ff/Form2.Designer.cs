namespace auction_ff
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            dataGridView = new DataGridView();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            register_login = new Label();
            label4 = new Label();
            register_btn = new Button();
            register_password = new TextBox();
            label3 = new Label();
            register_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            register_email = new TextBox();
            label6 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(dataGridView);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-14, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 665);
            panel1.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Username, Password });
            dataGridView.Location = new Point(26, 447);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(330, 188);
            dataGridView.TabIndex = 4;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.Width = 150;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 125;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(35, 250);
            label7.Name = "label7";
            label7.Size = new Size(312, 46);
            label7.TabIndex = 3;
            label7.Text = "AUCTION SYSTEM";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(92, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(194, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(726, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // register_login
            // 
            register_login.AutoSize = true;
            register_login.Location = new Point(579, 560);
            register_login.Name = "register_login";
            register_login.Size = new Size(79, 20);
            register_login.TabIndex = 17;
            register_login.Text = "Login here";
            register_login.Click += register_login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(421, 560);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 16;
            label4.Text = "Don't have an account?";
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.MidnightBlue;
            register_btn.Cursor = Cursors.Hand;
            register_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            register_btn.ForeColor = Color.White;
            register_btn.Location = new Point(482, 461);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(152, 52);
            register_btn.TabIndex = 15;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += button1_Click;
            // 
            // register_password
            // 
            register_password.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            register_password.Location = new Point(404, 364);
            register_password.Multiline = true;
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(318, 43);
            register_password.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(404, 341);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 13;
            label3.Text = "Password:";
            // 
            // register_username
            // 
            register_username.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            register_username.Location = new Point(404, 274);
            register_username.Multiline = true;
            register_username.Name = "register_username";
            register_username.Size = new Size(318, 43);
            register_username.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(404, 251);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 11;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(384, 81);
            label1.Name = "label1";
            label1.Size = new Size(243, 61);
            label1.TabIndex = 10;
            label1.Text = "Get Started!";
            // 
            // register_email
            // 
            register_email.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            register_email.Location = new Point(404, 195);
            register_email.Multiline = true;
            register_email.Name = "register_email";
            register_email.Size = new Size(318, 43);
            register_email.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(404, 172);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 19;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(128, 128, 255);
            label5.Location = new Point(411, 437);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 21;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Gray;
            checkBox1.Location = new Point(600, 413);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(766, 637);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(register_email);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(register_login);
            Controls.Add(label4);
            Controls.Add(register_btn);
            Controls.Add(register_password);
            Controls.Add(label3);
            Controls.Add(register_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label register_login;
        private Label label4;
        private Button register_btn;
        private TextBox register_password;
        private Label label3;
        private TextBox register_username;
        private Label label2;
        private Label label1;
        private TextBox register_email;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private Label label5;
        private CheckBox checkBox1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private ErrorProvider errorProvider4;
    }
}