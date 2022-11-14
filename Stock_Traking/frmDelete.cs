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
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }

        private void frmDelete_Load(object sender, EventArgs e)
        {
            cmbDelete.Items.Add("Category");
            cmbDelete.Items.Add("Product");
            cmbDelete.Items.Add("Customer");
            cmbDelete.Items.Add("Sales");
        }
    }
}
