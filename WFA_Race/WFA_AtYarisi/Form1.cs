using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //RAM'in çalışması yapısını araştırın.
        Random rnd = new Random();

        //değişkenler
        string atBir = "şahbatur";
        string atIki = "gülbatur";
        string atUc = "şahin";

        //Metotlar
        void Kostur(int hiz)
        {
            if (hiz > 10 && hiz <= 100)
            {
                pbAt1.Left += rnd.Next(10, hiz);
                pbAt2.Left += rnd.Next(10, hiz);
                pbAt3.Left += rnd.Next(10, hiz);
            }
            else
            {
                timer1.Stop();
                MesajVer("hız limiti 10 ile 100 arasında olmalı!");
                
            }
        }

        void MesajVer(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        void KazanmaDurumu()
        {

            if (pbAt1.Right >= lblFinish.Left)
            {
                string format = string.Format("{0} kazandı ", atBir);
                timer1.Stop();
                DialogResult dr = MessageBox.Show(format+"\nTekrar Oynamak İster misin? :))", "Oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;

                }
                else
                {
                    Application.Exit();
                }
            }
            else if (pbAt2.Right >= lblFinish.Left)
            {

                string format = string.Format("{0} kazandı ", atIki);
                timer1.Stop();
                DialogResult dr = MessageBox.Show(format+"\nTekrar Oynamak İster misin? :))", "Oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;

                }
                else
                {
                    Application.Exit();
                }
            }
            else if (pbAt3.Right >= lblFinish.Left)
            {

                string format = string.Format("{0} kazandı ", atUc);
                timer1.Stop();
                DialogResult dr = MessageBox.Show(format+"!\nTekrar Oynamak İster misin? :))", "Oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;

                }
                else
                {
                    Application.Exit();
                }
            }
        }

        void Spiker()
        {
            if (pbAt1.Right > pbAt2.Right && pbAt1.Right > pbAt3.Right)
            {
                
                SpikerYazdir(atBir);
            }
            else if (pbAt2.Right > pbAt1.Right && pbAt2.Right > pbAt3.Right)
            {
                SpikerYazdir(atIki);
            }
            else
            {
                SpikerYazdir(atUc);
            }
        }

        void SpikerYazdir(string at)
        {
            lblSpiker.Text = at + " at önde gidiyor...";
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            // pbAt1.Right = 10; //bir tool'u  sadece  sol (left) ve alt (bottom) özelliklerine değer ataması gerçekleştirilir. sağ (right) ve üst (top) değerleri sadece okunabilir (read only)
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Atları koşturma
            Kostur(80);


            //Kazanma Durumu
            KazanmaDurumu();

            //Spiker
            Spiker();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
