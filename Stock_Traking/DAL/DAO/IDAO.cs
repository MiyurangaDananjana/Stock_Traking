using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Traking.DAL.DTO
{
    interface IDAO<T, K> where T : class where K : class
    {
        List<K> SELECT();
        bool Insert(T entity);
        bool Updat(T entity);
        bool Delete(T entity);
        bool GetBack(int ID);
         
    }
}
