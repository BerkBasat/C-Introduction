using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string menu = "";
        decimal price = 0;
        string boyut = "";
        string extras = "";
        int adet = 0;
        decimal orderTotal = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMenu.Items.Add("Whooper");
            cmbMenu.Items.Add("Steakhouse");
            cmbMenu.Items.Add("McChicken");
        }

        void Hesapla()
        {

            if (cmbMenu.SelectedIndex == 0)
            {
                price += 25;
                menu += "Whooper Menu";
                cmbMenu.SelectedIndex = -1;
            }
            else if (cmbMenu.SelectedIndex == 1)
            {
                price += 35;
                menu += "Steakhouse Menu";
                cmbMenu.SelectedIndex = -1;
            }
            else if (cmbMenu.SelectedIndex == 2)
            {
                price += 20;
                menu += "McChicken Menu";
                cmbMenu.SelectedIndex = -1;
            }

            foreach(Control ctrl in this.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctrl;
                    if (rb.Checked && rb.Name == "rbKucuk")
                    {
                        boyut += "Küçük";
                        rb.Checked = false;
                    }
                    else if (rb.Checked && rb.Name == "rbOrta")
                    {
                        price += 3;
                        boyut += "Orta";
                        rb.Checked = false;
                    }
                    else if (rb.Checked && rb.Name == "rbBuyuk")
                    {
                        price += 5;
                        boyut += "Büyük";
                        rb.Checked = false;
                    }
                }
            }

            if (chkKetcap.Checked)
            {
                price += 2;
                extras += "Ketçap" + " ";
                chkKetcap.Checked = false;
            }
            if (chkMayonez.Checked)
            {
                price += 2;
                extras += "Mayonez" + " ";
                chkMayonez.Checked = false;
            }
            if (chkRanch.Checked)
            {
                price += 2;
                extras += "Ranch," + " ";
                chkRanch.Checked = false;
            }
            if (chkBuffalo.Checked)
            {
                price += 2;
                extras += "Buffalo" + " ";
                chkBuffalo.Checked = false;
            }
            if (chkChaddar.Checked)
            {
                price += 2;
                extras += "Cheddar" + " ";
                chkChaddar.Checked = false;
            }
            if (chkSMayonez.Checked)
            {
                price += 2;
                extras += "S. Mayonez";
                chkSMayonez.Checked=false;
            }


            if (nudAdet.Value > 0)
            {
                adet++;
                price *= Convert.ToInt32(nudAdet.Value);
            }

            string format = $"{menu} {boyut} ({extras}) {adet} Adet {price.ToString("C2")}";
            listBox1.Items.Add(format);
            orderTotal += price;
            lblSiparisToplam.Text = orderTotal.ToString();


        }

        void Order()
        {

            if (listBox1.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to finish your order?", "Order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = menu;
                    lvi.SubItems.Add(boyut);
                    lvi.SubItems.Add(extras);
                    lvi.SubItems.Add(adet.ToString());
                    lvi.SubItems.Add(price.ToString());
                    listView1.Items.Add(lvi);

                    listBox1.Items.Clear();

                }
            }
            else
            {
                MessageBox.Show("You didn't ordered anything!");
            }
            menu = "";
            price = 0;
            boyut = "";
            extras = "";
            nudAdet.Value = 0;
            adet = 0;
            orderTotal = 0;
            lblSiparisToplam.Text = "0";
        }



        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            Order();
        }

    }
}
