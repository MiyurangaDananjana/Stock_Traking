using Stock_Traking.BLL;
using Stock_Traking.DAL.DTO;
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
    public partial class frmCustomer_list : Form
    {
        public frmCustomer_list()
        {
            InitializeComponent();
        }

        private void txtCotegory_TextChanged(object sender, EventArgs e)
        {
            List<CustomerDetailDTO> list = dto.Customer;
            list = list.Where(x => x.CustomerName.Contains(txtCotegory.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        CustomerBLL bll = new CustomerBLL();
        CustomerDTO dto = new CustomerDTO();
        private void frmCustomer_list_Load(object sender, EventArgs e)
        {
            dto = bll.select();
            dataGridView1.DataSource = dto.Customer;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Customer Name";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
