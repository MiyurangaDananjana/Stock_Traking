using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock_Traking.BLL;
using Stock_Traking.DAL.DAO;
using Stock_Traking.DAL.DTO;

namespace Stock_Traking
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        CustomerBLL BLL = new CustomerBLL();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCotegory.Text.Trim() == "")
                MessageBox.Show("Customer Name is Empty");
            else
            {
                CustomerDetailDTO customer = new CustomerDetailDTO();
                customer.CustomerName = txtCotegory.Text;
                if (BLL.Insert(customer))
                {
                    MessageBox.Show("Customer Was addedd");
                    txtCotegory.Clear();
                }
            }
        }
    }
}
