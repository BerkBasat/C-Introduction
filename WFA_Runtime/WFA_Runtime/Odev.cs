using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Runtime
{
    public partial class Odev : Form
    {
        public Odev()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Width = 90;
                    btn.Height = 23;
                    btn.Text = String.Format("{0}x{1}", i + 1, j + 1);                   
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
        }

    }
}
