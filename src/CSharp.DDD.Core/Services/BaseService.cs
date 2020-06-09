using CSharp.DDD.Domain.Interfaces.Repositories;
using CSharp.DDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace CSharp.DDD.Core.Services
{
    public abstract class BaseService<T> : IDisposable, IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _repository;

        protected BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual void Add(T obj)
        {
            _repository.Add(obj);
        }
        public virtual T GetById(int id)
        {
            return _repository.GetById(id);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }
        public virtual void Update(T obj)
        {
            _repository.Update(obj);
        }
        public virtual void Remove(T obj)
        {
            _repository.Remove(obj);
        }

        public virtual void Dispose()
        {
            _repository.Dispose();
        }
    }
}