using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10_BangCuuC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            lsbTinh.Items.Clear();
            int so = Convert.ToInt32(txtSo.Text);
            for (int i = 1; i <= 10; i++)
            {
                lsbTinh.Items.Add(so + " * " + i + " = " + so * i);
            }
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                lsbTinh.Items.Add(i + " * " + j + " = " + i * j);
            }
        }
    }
}
