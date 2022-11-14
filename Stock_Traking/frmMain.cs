using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Traking
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomer_list frm = new frmCustomer_list();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSalesList frm = new frmSalesList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmProduct_List frm = new frmProduct_List();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAddStock frm = new frmAddStock();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCategory_List frm = new frmCategory_List();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDelete frm = new frmDelete();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
