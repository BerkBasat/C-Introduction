using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BonusOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKategori.Items.Add("Kategori 1");
            cmbKategori.Items.Add("Kategori 2");
            cmbKategori.Items.Add("Kategori 3");
            cmbKategori.Items.Add("Kategori 4");
            cmbKategori.Items.Add("Kategori 5");
        }

        string urunAdi;
        decimal urunFiyati;
        string kategori;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            urunAdi = txtUrunAdi.Text;
            urunFiyati = nudFiyat.Value;
            kategori = cmbKategori.Text;

            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = urunAdi;
            lvi.SubItems.Add(kategori);
            lvi.SubItems.Add(urunFiyati.ToString());


            if (chkBeyaz.Checked)
            {
                lvi.SubItems.Add("Beyaz");
                chkBeyaz.Checked = false;
            }

            if (chkKirmizi.Checked)
            {
                lvi.SubItems.Add("Kırmızı");
                chkKirmizi.Checked = false;
            }

            if (chkMavi.Checked)
            {
                lvi.SubItems.Add("Mavi");
                chkMavi.Checked = false;
            }

            if (chkTitanBeyazi.Checked)
            {
                lvi.SubItems.Add("Titan Beyazı");
                chkTitanBeyazi.Checked = false;
            }

            if (chkYavruAgzi.Checked)
            {
                lvi.SubItems.Add("Yavruağzı");
                chkYavruAgzi.Checked = false;
            }

            if (chkSiyah.Checked)
            {
                lvi.SubItems.Add("Siyah");
                chkBeyaz.Checked = false;
            }

            if (chkSari.Checked)
            {
                lvi.SubItems.Add("Sarı");
                chkSiyah.Checked = false;
            }

            if (chkYeşil.Checked)
            {
                lvi.SubItems.Add("Yeşil");
                chkYeşil.Checked = false;
            }

            if (chkToricelliMavisi.Checked)
            {
                lvi.SubItems.Add("Toricelli Mavisi");
                chkToricelliMavisi.Checked = false;
            }

            if (chkFusya.Checked)
            {
                lvi.SubItems.Add("Fuşya");
                chkFusya.Checked = false;
            }

            listView1.Items.Add(lvi);

            txtUrunAdi.Text = "";
            nudFiyat.Value = 0;
            cmbKategori.Text = "";

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            lblSeciliUrunAd.Text = listView1.SelectedItems[0].SubItems[0].Text;
            lblSeciliKategori.Text = listView1.SelectedItems[0].SubItems[1].Text;
            lblSeciliFiyat.Text = listView1.SelectedItems[0].SubItems[2].Text;
            lblRenk.Text = listView1.SelectedItems[0].SubItems[3].Text;

        }
    }
}
