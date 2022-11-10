namespace ContentOperations.MediaLibrary.Domain.Interfaces
{
    using ContentOperations.MediaLibrary.Domain.Entities;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> FindAll();

        IQueryable<T> FindBy(Expression<Func<T, bool>> expression);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
