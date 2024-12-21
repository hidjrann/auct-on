using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auction_ff
{
    public partial class Form6 : Form
    {
        private int auctionTimeLeft = 120;
        private decimal currentPrice = 1370m;
        private Random random = new Random();

        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
            textBox2.Text = GenerateRandomBid().ToString();
            textBox3.Text = GenerateRandomBid().ToString();
            textBox4.Text = GenerateRandomBid().ToString();
            textBox5.Text = GenerateRandomBid().ToString();
            textBox6.Text = GenerateRandomBid().ToString();

        }
        private decimal GenerateRandomBid()
        {
            return currentPrice + random.Next(1, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            auctionTimeLeft--;
            label2.Text = auctionTimeLeft.ToString();

            if (auctionTimeLeft <= 0)
            {
                timer1.Stop();
                DetermineWinner();
            }
        }

        private void DetermineWinner()
        {
            decimal highestBid = currentPrice;
            string winner = "Digər istifadəçilərdən biri";
            if (decimal.Parse(textBox2.Text) > highestBid)
            {
                highestBid = decimal.Parse(textBox2.Text);
                winner = "Təklifçi 1";
            }
            if (decimal.Parse(textBox3.Text) > highestBid)
            {
                highestBid = decimal.Parse(textBox3.Text);
                winner = "Təklifçi 2";
            }
            if (decimal.Parse(textBox4.Text) > highestBid)
            {
                highestBid = decimal.Parse(textBox4.Text);
                winner = "Təklifçi 3";
            }
            if (decimal.Parse(textBox5.Text) > highestBid)
            {
                highestBid = decimal.Parse(textBox5.Text);
                winner = "Təklifçi 4";
            }
            if (decimal.Parse(textBox6.Text) > highestBid)
            {
                highestBid = decimal.Parse(textBox6.Text);
                winner = "Təklifçi 5";
            }
            if (highestBid == currentPrice)
            {
                MessageBox.Show("Təəssüf ki, ürünü ala bilmədiniz.");
            }
            else
            {
                MessageBox.Show($"{winner} qalib oldu! Ürünü satın aldı.");
            }
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            decimal userBid;
            if (decimal.TryParse(textBox1.Text, out userBid))
            {
                if (userBid > currentPrice)
                {
                    MessageBox.Show("Qalib sizsiniz! Ürünü satın aldınız.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Təəssüf ki, ürünü ala bilmədiniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfən, düzgün bir təklif məbləği daxil edin.");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
