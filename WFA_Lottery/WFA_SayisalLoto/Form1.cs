using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is ListBox)
                {
                    ListBox lst = (ListBox)ctrl;
                    lst.Items.Clear();
                    int counter = 0;
                    while (counter < 6)
                    {
                        int rastgele = rnd.Next(1, 50);
                        if (!lst.Items.Contains(rastgele))
                        {
                            lst.Items.Add(rastgele);
                            counter++;
                        }
                    }
                }
            }
        }
    }
}
