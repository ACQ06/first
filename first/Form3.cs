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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_Calc = new frmCalc();
            frm_Calc.ShowDialog();
        }
    }
}