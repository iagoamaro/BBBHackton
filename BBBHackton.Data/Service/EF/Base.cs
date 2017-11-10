using BBBHackton.Data.Context;
using BBBHackton.Data.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBHackton.Data.Service.EF
{
    public abstract class Base<T> : IBase<T> where T : class
    {
        private DbContexto _db;
        public Base()
        {
            _db = new DbContexto();
        }

        public int Create(T entity)
        {
            _db.Set<T>().Add(entity);
            return _db.SaveChanges();
        }

        public void Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
            _db.SaveChanges();

        }

        public T Find(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _db.Set<T>();
        }

        public void Update(T entity)
        {
            _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
