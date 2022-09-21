﻿using Students.Application.DTOs.Base;
using Students.Application.Services.Base.Contract;
using Students.DataAccess.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Students.Application.Services.Base
{
    public class ServicesBase<T> : IServicesBase<T> where T : BaseDto, new()
    {
        protected readonly IBaseRepository<T> _repository;
        public ServicesBase(IBaseRepository<T> repository)
        {
            _repository = repository;
        }
        public virtual int Create(T entity)
        {
            try
            {
                return _repository.Create(entity);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }
        public virtual void CreateRange(List<T> entity)
        {
            try
            {
                _repository.CreateRange(entity);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }
        public virtual void Delete(int Id)
        {
            try
            {
                _repository.Delete(Id);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }
        public virtual IQueryable<T> FindAll()
        {
            try
            {
                return _repository.FindAll();
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }
        public virtual IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            try
            {
                return _repository.FindByCondition(expression);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }
        public virtual T GetOne(int Id)
        {
            try
            {
                return _repository.GetOne(Id);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }
        public virtual T Update(T entity)
        {
            try
            {
                return _repository.Update(entity);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }
        public bool Exist(Expression<Func<T, bool>> expression)
        {
            try
            {
                return _repository.Exist(expression);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public T LastOne()
        {
            try
            {
                return _repository.LastOne();
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public void UpdateRange(List<T> entity)
        {
            try
            {
                _repository.UpdateRange(entity);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }
    }
}
