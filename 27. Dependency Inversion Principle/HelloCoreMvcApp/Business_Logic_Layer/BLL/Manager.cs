using ProjectRepositorys.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer.BLL
{
    public abstract class Manager<T> where T : class
    {
        private readonly Repository<T> _repository;

        public Manager(Repository<T> repository)
        {
            _repository = repository;
        }

        public virtual T GetById(int? id)
        {
            return _repository.GetById(id);
        }

        public virtual ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }

        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }

        public virtual bool Remove(T entity)
        {
            return _repository.Remove(entity);
        }
    }
}
