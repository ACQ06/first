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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            prgLoad.Value += 1;
            if (prgLoad.Value >= 100)
            {
                tmrLoad.Enabled = false;
                Form frm_Main = new frmMain();
                frm_Main.WindowState = FormWindowState.Maximized;
                frm_Main.ShowDialog();
                this.Hide();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            tmrLoad.Enabled = true;
        }
    }
}
