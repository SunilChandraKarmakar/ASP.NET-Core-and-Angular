using Business_Logic_Layer.Contracts;
using ProjectRepositorys.Base;
using ProjectRepositorys.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer.BLL
{
    public abstract class Manager<T> : IManager<T> where T : class
    {
        private readonly IRepository<T> _iRepository;

        public Manager(IRepository<T> iRepository)
        {
            _iRepository = iRepository;
        }

        public virtual T GetById(int? id)
        {
            return _iRepository.GetById(id);
        }

        public virtual ICollection<T> GetAll()
        {
            return _iRepository.GetAll();
        }

        public virtual bool Add(T entity)
        {
            return _iRepository.Add(entity);
        }

        public virtual bool Update(T entity)
        {
            return _iRepository.Update(entity);
        }

        public virtual bool Remove(T entity)
        {
            return _iRepository.Remove(entity);
        }
    }
}
