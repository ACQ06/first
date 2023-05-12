using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Clear();
            lvwRecord.Columns.Add("name", 100);
            lvwRecord.Columns.Add("birthdate", 200);
            lvwRecord.View = View.Details;
            lvwRecord.FullRowSelect = true;
            lvwRecord.GridLines = true;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            ListViewItem itm = new ListViewItem();
            itm.Text = txtName.Text;
            ListViewItem.ListViewSubItem sbItem1 = new ListViewItem.ListViewSubItem();
            sbItem1.Text = Convert.ToString(dtpBdate.Text);
            itm.SubItems.Add(sbItem1);
            lvwRecord.Items.Add(itm);
            txtName.Clear();
            txtName.Focus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete the selected record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lvwRecord.SelectedItems[0].Remove();
            }
        }
    }
}
