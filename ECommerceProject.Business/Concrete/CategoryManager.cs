using ECommerceProject.Business.Abstract;
using ECommerceProject.DataAccess.Abstract;
using ECommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ECommerceProject.Business.Concrete
{
   public class CategoryManager:ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Create(Category entity)
        {
            _categoryDal.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter)
        {
            if (filter == null)
            {
                return _categoryDal.GetAll(null);
            }
            else
            {
                return _categoryDal.GetAll(filter);
            }
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public Category GetOne(Expression<Func<Category, bool>> filter)
        {
            if (filter == null)
            {
                return null;
            }
            else
            {
                return _categoryDal.GetOne(filter);
            }
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
