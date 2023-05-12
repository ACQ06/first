using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace first
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }
        int sw = 0;
        int holdnum = 0;
        private void frmCalc_Load(object sender, EventArgs e)
        {
            txtNum.Text = "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtNum.Text != "0")
            {
                txtNum.Text = txtNum.Text + "1";
            }
            else
            {
                txtNum.Text = "1";
            }
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            sw = 1;
            holdnum = Int32.Parse(txtNum.Text);
            txtNum.Text = "0";
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (sw == 1)
            {
                txtNum.Text = Convert.ToString(holdnum + Int32.Parse(txtNum.Text));
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtNum.Text != "0")
            {
                txtNum.Text = txtNum.Text + "0";
            }
        }
    }
}