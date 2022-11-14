using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock_Traking.DAL.DTO;
using Stock_Traking.DAL;
using Stock_Traking.DAL.DAO;

namespace Stock_Traking.BLL
{
    public class CategoryBLL : IBLL<CategoryDetailDTO, CategoryDTO>
    {
        CategoryDAO dao = new CategoryDAO();
        public bool Dlete(CategoryDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(CategoryDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CategoryDetailDTO entity)
        {
            CATEGORY category = new CATEGORY();
            category.CategoryName = entity.CategoryName;
            return dao.Insert(category);
        }

        public CategoryDTO select()
        {
            CategoryDTO dto = new CategoryDTO();
            dto.Categories = dao.SELECT();
            return dto;
        }

        public bool Update(CategoryDetailDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
