using ECommerceProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceProject.Entities.Concrete
{
   public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<ProductCategories> ProductCategories { get; set; }
        public string ImageUrl { get; set; }
    }
}
