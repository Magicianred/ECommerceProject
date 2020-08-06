using ECommerceProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceProject.Entities.Concrete
{
   public class ProductCategories:IEntity
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
