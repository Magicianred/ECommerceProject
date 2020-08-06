using ECommerceProject.DataAccess.Abstract;
using ECommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceProject.DataAccess.Concrete.EfCore
{
   public class EfProductDal:EfGenericRepository<Product>,IProductDal
    {
    }
}
