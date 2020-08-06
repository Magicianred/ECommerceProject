using ECommerceProject.Business.Abstract;
using ECommerceProject.DataAccess.Abstract;
using ECommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading;

namespace ECommerceProject.Business.Concrete
{
   public class ProductManager:IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Create(Product entity)
        {
            _productDal.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            if (filter == null)
            {
                return _productDal.GetAll(null);
            }
            else
            {
                return _productDal.GetAll(filter);
            }
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
           if(filter == null)
            {
                return null;
            }
            else
            {
                return _productDal.GetOne(filter);
            }
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
