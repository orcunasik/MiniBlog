using MiniBlog.Business.Abstractions;
using MiniBlog.DataAccess.Abstractions;
using MiniBlog.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MiniBlog.Business.Concretes
{
    public class Service<T> : IService<T> where T : class, IEntity, new()
    {
        private IGenericRepositoryDal<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IGenericRepositoryDal<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public T Add(T entity)
        {
            _repository = _unitOfWork.GetRepository<T>();
            _repository.Add(entity);
            _unitOfWork.Commit();
            return entity;
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(T entity)
        {
            _repository = _unitOfWork.GetRepository<T>();
            _repository.Remove(entity);
            _unitOfWork.Commit();
        }

        public void Update(T entity)
        {
            _repository = _unitOfWork.GetRepository<T>();
            _repository.Update(entity);
            _unitOfWork.Commit();
        }

        public IEnumerable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }
}
