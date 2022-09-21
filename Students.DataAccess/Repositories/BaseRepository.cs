using Microsoft.EntityFrameworkCore;
using Students.DataAccess.DBContexts;
using Students.DataAccess.Repositories.Contract;
using Students.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Students.DataAccess.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity, new()
    {
        protected StudentsContext RepositoryContext { get; set; }
        protected readonly DbSet<T> entities;
        public BaseRepository(StudentsContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
            entities = RepositoryContext.Set<T>();
        }
        public virtual int Create(T entity)
        {
            var result = entities.Add(entity);
            this.RepositoryContext.SaveChanges();
            return Convert.ToInt32(result.Property("Id").CurrentValue.ToString());
        }
        public virtual void CreateRange(List<T> entitys)
        {
            entities.AddRange(entitys);
            this.RepositoryContext.SaveChanges();
        }

        public virtual void Delete(int Id)
        {
            var entity = this.GetOne(Id);
            this.Update(entity);
        }

        public virtual IQueryable<T> FindAll()
        {
            var result = this.entities.OrderByDescending(c => c.Id).AsNoTracking();
            return result;
        }

        public virtual IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public virtual T FirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().FirstOrDefault(expression);
        }

        public virtual T GetOne(int Id)
        {
            return this.RepositoryContext.Set<T>().Find(Id);
        }

        public virtual T LastOne()
        {
            return this.RepositoryContext.Set<T>().OrderByDescending(c => c.Id).FirstOrDefault();
        }

        public virtual T Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
            this.RepositoryContext.SaveChanges();
            return entity;
        }

        public virtual void UpdateRange(List<T> entity)
        {
            entities.UpdateRange(entity);
            this.RepositoryContext.SaveChanges();
        }

        public bool Exist(Expression<Func<T, bool>> expression) => (this.RepositoryContext.Set<T>().Any(expression));
    }
}
