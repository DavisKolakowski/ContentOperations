namespace ContentOperations.MediaLibrary.Data.Repositories
{
    using ContentOperations.MediaLibrary.Domain.Entities;
    using ContentOperations.MediaLibrary.Domain.Interfaces;
    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private MediaLibraryContext _dbContext;

        private DbSet<T> _dbSet;

        public RepositoryBase()
        {
            this._dbContext = new MediaLibraryContext();
            this._dbSet = _dbContext.Set<T>();
        }

        public RepositoryBase(MediaLibraryContext dbContext)
        {
            this._dbContext = dbContext;
            this._dbSet = _dbContext.Set<T>();
        }

        public IQueryable<T> FindAll()
        {
            var elements = this._dbSet;

            return elements;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> expression)
        {
            var element = this._dbSet.Where(expression);

            return element;
        }

        public void Create(T entity)
        {
            this._dbSet.Add(entity);
        }
        public void Update(T entity)
        {
            this._dbSet.Update(entity);
        }
        public void Delete(T entity)
        {
            this._dbSet.Remove(entity);
        }
    }
}
