using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock_Traking.DAL.DAO;
using Stock_Traking.DAL;
using Stock_Traking.DAL.DTO;

namespace Stock_Traking.DAL.DAO
{
    class CustomerDAO : Stock_Context, IDAO<CUSTOMER, CustomerDetailDTO>
    {
        public bool Delete(CUSTOMER entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CUSTOMER entity)
        {
            try
            {
                db.CUSTOMERs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<CustomerDetailDTO> SELECT()
        {
            try
            {
                List<CustomerDetailDTO> customers = new List<CustomerDetailDTO>();
                var list = db.CUSTOMERs;
                foreach (var item in list)
                {
                    CustomerDetailDTO dto = new CustomerDetailDTO();
                    dto.CustomerName = item.CustomerName;
                    dto.ID = item.ID;
                    customers.Add(dto);
                }
                return customers;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Updat(CUSTOMER entity)
        {
            throw new NotImplementedException();
        }
    }
}
