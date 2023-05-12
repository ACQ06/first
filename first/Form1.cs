using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
namespace first
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int tryCount = 0;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "COPRO3" && txtPass.Text == "JBP-JOMARISS")
            {
                MessageBox.Show("Successfully Logged-in");
                Form frm_1 = new frmSplash();
                frm_1.ShowDialog();
                Console.WriteLine("CREDENTIALS OKAY");
                this.Hide();
            }
            else
            {
                tryCount += 1;
                if (tryCount == 3)
                {
                    MessageBox.Show("The program will close immediately!, BYE!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid user name and / or password!");
                    txtPass.Clear();
                    txtUser.Clear();
                    txtUser.Focus();
                }
            }
        }
    }
}