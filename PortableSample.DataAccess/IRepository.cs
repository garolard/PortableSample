using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PortableSample.DataAccess
{
    public interface IRepository<T>
    {
        Task<T> SaveAsync(T value);
        Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task<int> DeleteAsync(T value);
    }
}
