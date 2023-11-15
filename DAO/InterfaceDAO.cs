using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface InterfaceDAO<T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
        bool Add(T t);
        bool Update(T t);
        bool Delete(int id);

    }
}
