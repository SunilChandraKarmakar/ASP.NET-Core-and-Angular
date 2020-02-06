using Db_Context.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectRepositorys.Base
{
    public class Repository<T> where T : class
    {
        private readonly CoreDb _coreDb;

        public Repository()
        {
            _coreDb = new CoreDb();
        }

        private DbSet<T> Table 
        { 
            get 
            { 
                return _coreDb.Set<T>(); 
            }
            set { }
        }

        public virtual T GetById(int? id)
        {
            return Table.Find(id);
        }

        public virtual ICollection<T> GetAll()
        {
            return Table.ToList();
        }

        public virtual bool Add(T entity)
        {
            Table.Add(entity);
            return _coreDb.SaveChanges() > 0;
        }

        public virtual bool Update(T entity)
        {
            _coreDb.Entry(entity).State = EntityState.Modified;
            return _coreDb.SaveChanges() > 0;
        }

        public virtual bool Remove(T entity)
        {
            Table.Remove(entity);
            return _coreDb.SaveChanges() > 0;
        }
    }
}
