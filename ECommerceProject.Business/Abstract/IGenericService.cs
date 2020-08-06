using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ECommerceProject.Business.Abstract
{
   public interface IGenericService<T>
    {
        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        List<T> GetAll(Expression<Func<T, bool>> filter);

        T GetById(int id);

        T GetOne(Expression<Func<T, bool>> filter);
    }
}
