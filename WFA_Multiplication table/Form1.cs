using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_CarpimTablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i=1; i<=10; i++)
            {
                for(int z=1; z<=10; z++)
                {
                    string format = string.Format("{0}x{1}={2}", i, z, i * z);
                    listBox1.Items.Add(format);
                }
            }


        }
    }
}
