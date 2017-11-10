using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBHackton.Data.Service.Interface
{
    public interface IBase<T> where T : class
    {
        int Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Find(int id);
        IQueryable<T> GetAll();
    }
}
