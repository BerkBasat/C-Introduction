using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SayilarinOkunusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            string[] birlerBasamagi = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onlarBasamagi = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

            try
            {
                int gelenSayi = Convert.ToInt32(textBox1.Text);//5
                int birler = gelenSayi % 10;
                int onlar = gelenSayi/ 10;

                string format = onlarBasamagi[onlar] + " " + birlerBasamagi[birler];
                lblResult.Text = format;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
