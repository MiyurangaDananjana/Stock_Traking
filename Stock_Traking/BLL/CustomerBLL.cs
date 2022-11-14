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
    class CustomerBLL : IBLL<CustomerDetailDTO, CustomerDTO>
    {
        CustomerDAO dao = new CustomerDAO();
        public bool Dlete(CustomerDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(CustomerDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CustomerDetailDTO entity)
        {
            CUSTOMER customer = new CUSTOMER();
            customer.CustomerName = entity.CustomerName;
            return dao.Insert(customer);
        }

        public CustomerDTO select()
        {
            CustomerDTO dto = new CustomerDTO();
            dto.Customer = dao.SELECT();
            return dto;
        }

        public bool Update(CustomerDetailDTO entity)
        {
            throw new NotImplementedException();
        }
    }
    {
    }
}
