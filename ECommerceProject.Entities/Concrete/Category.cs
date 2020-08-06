using ECommerceProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceProject.Entities.Concrete
{
   public class Category:IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<ProductCategories> ProductCategories { get; set; }
    }
}
