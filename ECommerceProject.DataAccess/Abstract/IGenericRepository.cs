using ECommerceProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ECommerceProject.DataAccess.Abstract
{
   public interface IGenericRepository<T> where T : class, IEntity, new()
    {

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        List<T> GetAll(Expression<Func<T, bool>> filter);

        T GetById(int id);

        T GetOne(Expression<Func<T, bool>> filter);
    }
}
