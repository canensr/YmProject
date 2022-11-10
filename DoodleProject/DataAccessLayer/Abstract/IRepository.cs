using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        int Insert(T P);
        int Update(T P);
        int Delete(T P);
        T GetByID(int id);

        List<T> List(Expression<Func<T, bool>> filter);

        T Find(Expression<Func<T, bool>> where);
    }
}
