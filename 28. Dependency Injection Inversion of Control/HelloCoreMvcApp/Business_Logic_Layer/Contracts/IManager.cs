using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer.Contracts
{
    public interface IManager<T> where T : class
    {
        T GetById(int? Id);  
        ICollection<T> GetAll();
        bool Add(T entity);     
        bool Update(T entity);  
        bool Remove(T entity);
    }
}
