namespace auction_ff
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            label5 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            errorProvider6 = new ErrorProvider(components);
            errorProvider7 = new ErrorProvider(components);
            button4 = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(217, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(221, 197);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(264, 27);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(219, 338);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(266, 63);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 156);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 4;
            label1.Text = "Alış fiyatı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 204);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 5;
            label2.Text = "Satış fiyatı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 341);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 6;
            label3.Text = "haqqında bilgi:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(553, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 123);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(553, 222);
            button1.Name = "button1";
            button1.Size = new Size(127, 31);
            button1.TabIndex = 8;
            button1.Text = "Resim seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(442, 488);
            button2.Name = "button2";
            button2.Size = new Size(102, 41);
            button2.TabIndex = 9;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(256, 490);
            button3.Name = "button3";
            button3.Size = new Size(102, 41);
            button3.TabIndex = 10;
            button3.Text = "Leğv";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 111);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 11;
            label4.Text = "Id:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
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
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(22, 9);
            label5.Name = "label5";
            label5.Size = new Size(196, 41);
            label5.TabIndex = 12;
            label5.Text = "Satış elave et:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(219, 243);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(266, 27);
            maskedTextBox1.TabIndex = 13;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(219, 290);
            maskedTextBox2.Mask = "00/00/0000 00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(266, 27);
            maskedTextBox2.TabIndex = 14;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(113, 250);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 15;
            label6.Text = "istehsal tarixi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(134, 297);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 16;
            label7.Text = "çıxış tarixi:";
            // 
            // errorProvider6
            // 
            errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            errorProvider7.ContainerControl = this;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 0, 192);
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(54, 490);
            button4.Name = "button4";
            button4.Size = new Size(102, 41);
            button4.TabIndex = 17;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(679, 8);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(731, 543);
            Controls.Add(pictureBox4);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private Label label5;
        private Label label7;
        private Label label6;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider7;
        private Button button4;
        private PictureBox pictureBox4;
    }
}