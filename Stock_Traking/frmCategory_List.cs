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
    public partial class frmCategory_List : Form
    {
        public frmCategory_List()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

        }

        CategoryDTO dto = new CategoryDTO();
        CategoryBLL bll = new CategoryBLL();
        private void frmCategory_List_Load(object sender, EventArgs e)
        {
            dto = bll.select();
            dataGridView1.DataSource = dto.Categories;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Category Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /// serch cxategory
            List<CategoryDetailDTO> list = dto.Categories;
            list = list.Where(x => x.CategoryName.Contains(textBox1.Text)).ToList();
            dataGridView1.DataSource = list;
        }
    }
}
