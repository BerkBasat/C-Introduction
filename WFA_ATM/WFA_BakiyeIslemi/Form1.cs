using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BakiyeIslemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Bakiye değişkenleri
        decimal bakiye = 500;
        decimal cekilenTutar = 0;
        decimal yatirilanTutar = 0;
        string hataMesaj = "bakiyeniz yetersiz lütfen bakiye yükleyin...";

        //Alişveriş listesi değişkenleri

        //todo:fiyatlar isteğe bağlı güncellenebilir olsun.


        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            lblBakiye.Text = bakiye.ToString("C2");
            //ToString("C2") => currency anlamında kullanılmaktadır. İşletim sisteminin dilini baz alarak para brimini string olarak gösterir.
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            //cekilenTutar = nudParaCek.Value;
            //bakiye = bakiye - cekilenTutar;
            //lblBakiye.Text = bakiye.ToString("C2");
            //if (bakiye > 0 &&bakiye>=cekilenTutar)
            //{
            //    listBox1.Items.Add(cekilenTutar.ToString("C2"));
            //}

            if (bakiye >= nudParaCek.Value)
            {
                if (nudParaCek.Value > 0)
                {
                    bakiye -= nudParaCek.Value;
                    lblBakiye.Text = bakiye.ToString("C2");
                    cekilenTutar = nudParaCek.Value;
                    listBox1.Items.Add("Para Çekme: " + cekilenTutar.ToString("C2"));
                }
                

            }
            else
            {
                MessageBox.Show(hataMesaj);
            }
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            if (nudParaYatir.Value > 0)
            {
                bakiye += nudParaYatir.Value;
                lblBakiye.Text = bakiye.ToString("C2");
                yatirilanTutar = nudParaYatir.Value;
                listBox1.Items.Add("Para Yatırma :" + yatirilanTutar.ToString("C2"));
            }
            else
            {
                MessageBox.Show("en az 1 TL yükleyin...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //alışveriş sepetini
            decimal toplamTutar = 0;
            string siparis = "";

            if (bakiye > 0)
            {
                if (chkEkmek.Checked)
                {
                    toplamTutar += 4;
                    siparis += " Ekmek ";

                }
                if (chkYumurta.Checked)
                {
                    toplamTutar += 20;
                    siparis += " Yumurta ";
                }
                if (chkCay.Checked)
                {
                    toplamTutar += 35;
                    siparis += " Çay ";
                }
                if (chkCikoloata.Checked)
                {
                    toplamTutar += 30;
                    siparis += " Cikolata ";
                }
                if (chkPeynir.Checked)
                {
                    toplamTutar += 45;
                    siparis += " Peynir ";
                }

                

                if (toplamTutar <= bakiye)
                {
                    lblToplam.Text = toplamTutar.ToString("C2");
                    listBox2.Items.Add(siparis + " Toplam :" + toplamTutar.ToString("C2"));
                    bakiye -= toplamTutar;
                    lblBakiye.Text = bakiye.ToString("C2");
                    lblToplam.ForeColor = Color.Green;
                }
                else
                {
                    lblToplam.ForeColor = Color.Red;
                    MessageBox.Show(hataMesaj);
                }
            }
            else
            {
                MessageBox.Show(hataMesaj);
            }
        }
    }
}
