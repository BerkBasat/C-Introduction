using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TopSektirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hizYatay = 10;
        int hizDikey = 10;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("aktif");
            //MessageBox.Show(e.ToString());
            //MessageBox.Show(e.KeyCode.ToString());

            //bool isA = e.KeyCode == Keys.A;
            //if (isA)
            //{
            //    MessageBox.Show("A tuşu aktif");
            //}

            //if (e.KeyCode == Keys.Left)
            //{
            //    pbTop.Left -= 5;
            //}

            switch (e.KeyCode)
            {
                case Keys.Left:
                    pbTop.Left -= hizYatay;
                    break;
                case Keys.Right:
                    pbTop.Left += hizYatay;
                    break;
                   
                case Keys.Up:
                    pbTop.Top -= hizDikey;
                    break;

                case Keys.Down:
                    pbTop.Top += hizDikey;
                    break;

                case Keys.D:
                    timer1.Start();
                    break;

                case Keys.S:
                    timer1.Stop();
                    timer2.Stop();
                    break;

                case Keys.T:
                    timer2.Start();
                    break;
                    
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbTop.Left += hizYatay;

            if (pbTop.Right >= this.Width)
            {
                hizYatay -= 10;
            }
            else if (pbTop.Left <= 0)
            {
                hizYatay += 10;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pbTop.Top += hizDikey;

            if (pbTop.Bottom >= this.Height)
            {
                hizDikey -= 10;
            }
            else if (pbTop.Top <= 0)
            {
                hizDikey += 10;
            }
        }
    }
}
