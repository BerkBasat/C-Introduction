using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Labirent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int yellowBox = 2;
        int grayBox = 10;
        private void label1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Kaybettiniz!");
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Kazandınız");
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Visible = false;

            lblToplam.Text = (Convert.ToInt32(lblToplam.Text) + yellowBox).ToString();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Visible = false;

            lblToplam.Text = (Convert.ToInt32(lblToplam.Text) + yellowBox).ToString();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.Visible = false;

            lblToplam.Text = (Convert.ToInt32(lblToplam.Text) + yellowBox).ToString();
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.Visible = false;

            lblToplam.Text = (Convert.ToInt32(lblToplam.Text) + yellowBox).ToString();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.Visible = false;

            lblToplam.Text = (Convert.ToInt32(lblToplam.Text) + yellowBox).ToString();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.Visible = false;

            lblToplam.Text = (Convert.ToInt32(lblToplam.Text) + yellowBox).ToString();
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.Visible = false;

            lblToplam.Text = (Convert.ToInt32(lblToplam.Text) + yellowBox).ToString();
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            button8.Visible = false;

            lblToplam.Text = (Convert.ToInt32(lblToplam.Text) + yellowBox).ToString();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.Visible = false;

            lblToplam.Text = (Convert.ToInt32(lblToplam.Text) + grayBox).ToString();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            lblUser.Text = txtUser.Text;

            game.Visible = false;
            txtUser.Visible = false;
            btnBaslat.Visible = false;
        }

    }
}
