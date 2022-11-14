using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Traking.BLL
{
    interface IBLL<T, K> where T : class where K : class
    {
        bool Insert(T entity);
        bool Update(T entity);
        bool Dlete(T entity);
        K select();
        bool GetBack(T entity);
    }
}
