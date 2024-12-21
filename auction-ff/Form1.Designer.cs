namespace auction_ff
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            login_register = new Label();
            label4 = new Label();
            login_btn = new Button();
            login_password = new TextBox();
            label3 = new Label();
            login_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(login_register);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(login_password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 645);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Gray;
            checkBox1.Location = new Point(603, 367);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(128, 128, 255);
            label5.Location = new Point(416, 390);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(714, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // login_register
            // 
            login_register.AutoSize = true;
            login_register.Location = new Point(585, 562);
            login_register.Name = "login_register";
            login_register.Size = new Size(104, 20);
            login_register.TabIndex = 8;
            login_register.Text = "Registere here";
            login_register.Click += login_register_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(427, 562);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 7;
            label4.Text = "Don't have an account?";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.MidnightBlue;
            login_btn.Cursor = Cursors.Hand;
            login_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(481, 423);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(152, 52);
            login_btn.TabIndex = 6;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_password
            // 
            login_password.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            login_password.Location = new Point(406, 318);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(318, 43);
            login_password.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(406, 295);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // login_username
            // 
            login_username.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            login_username.Location = new Point(406, 228);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(318, 43);
            login_username.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(406, 205);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(390, 83);
            label1.Name = "label1";
            label1.Size = new Size(188, 61);
            label1.TabIndex = 1;
            label1.Text = "Welcome!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(3, -9);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 654);
            panel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(29, 257);
            label6.Name = "label6";
            label6.Size = new Size(312, 46);
            label6.TabIndex = 1;
            label6.Text = "AUCTION SYSTEM";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(86, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(194, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(763, 637);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox login_username;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button login_btn;
        private TextBox login_password;
        private Label label3;
        private PictureBox pictureBox1;
        private Label login_register;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label5;
        private CheckBox checkBox1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}
