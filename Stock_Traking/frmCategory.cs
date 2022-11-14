using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock_Traking.DAL.DTO;
using Stock_Traking.DAL;
using Stock_Traking.BLL;

namespace Stock_Traking
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {

        }

        CategoryBLL bll = new CategoryBLL();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCotegory.Text.Trim() == "")
                MessageBox.Show("Category Name is emnpty");
            else
            {
                CategoryDetailDTO cetegory = new CategoryDetailDTO();
                cetegory.CategoryName = txtCotegory.Text;

                if (bll.Insert(cetegory))
                {
                    MessageBox.Show("Category was added");
                    txtCotegory.Clear();
                }
            }
        }
    }
}
