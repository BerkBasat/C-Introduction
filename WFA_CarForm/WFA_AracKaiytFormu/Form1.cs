using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AracKaiytFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMarka.Items.Clear();

            cmbMarka.Items.Add("Alfa Romeo");
            cmbMarka.Items.Add("Renault");
            cmbMarka.Items.Add("Ferrari");
            cmbMarka.Items.Add("Porsche");
            cmbMarka.Items.Add("Tesla");


            cmbYakit.Items.Add("Dizel");
            cmbYakit.Items.Add("Benzin");
            cmbYakit.Items.Add("Elektrik");

            cmbVites.Items.Add("Otomatik");
            cmbVites.Items.Add("Manuel");



        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();

            switch (cmbMarka.Text)
            {
                case "Alfa Romeo":
                    cmbModel.Items.Add("Guiletta");
                    cmbModel.Items.Add("159");
                    break;

                case "Renault":
                    cmbModel.Items.Add("Megane");
                    cmbModel.Items.Add("Clio");
                    break;

                case "Ferrari":
                    cmbModel.Items.Add("143");
                    cmbModel.Items.Add("California");
                    break;

                case "Porsche":
                    cmbModel.Items.Add("Carrera");
                    cmbModel.Items.Add("Cayane");
                    break;

                case "Tesla":
                    cmbModel.Items.Add("Model s");
                    break;
            }


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = cmbMarka.Text; //0
            lvi.SubItems.Add(cmbModel.Text);//1
            lvi.SubItems.Add(cmbYakit.Text);//2
            lvi.SubItems.Add(cmbVites.Text);//3
            lvi.SubItems.Add("");//4
            lvi.SubItems[4].BackColor = btnRenk.BackColor;
            lvi.SubItems.Add(dateTimePicker1.Value.Year.ToString());

            listView1.Items.Add(lvi);

            lblAdet.Text = listView1.Items.Count.ToString();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnRenk.BackColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("Cancelled!");
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    lblAdet.Text = listView1.Items.Count.ToString();
                }
                else
                {
                    MessageBox.Show("Cancelled");
                }

            }
            else
            {
                MessageBox.Show("There is nothing to delete!");
            }

        }
    }
}
