using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baitapc4
{
    public partial class Form1 : Form
    {
        double toanhang1, toanhang2;
        string toantu= "";

        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn1.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains("."))
            {
                MessageBox.Show(" ban khong duoc nhap 2 dau .cung 1 luc");
                return;
            }
            else
            {

                txtResult.Text = txtResult.Text + btn3.Text;
            }
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            double toanhang1 = Convert.ToDouble(txtResult.Text);
            toantu = "+";
            txtResult.Text = "";

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            toanhang2 = Convert.ToDouble(txtResult.Text);
            if (toantu != "")
            {
                if (toantu == "=")
                {
                    txtResult.Text = (toanhang1 + toanhang2).ToString();
                }
            }
        }
    }
}
