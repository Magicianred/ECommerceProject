using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceProject.Business.Abstract;
using ECommerceProject.Entities.Concrete;
using ECommerceProject.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ECommerceProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {

            List<ProductListViewModel> models = new List<ProductListViewModel>();
            List<Product> products = _productService.GetAll(null);
            foreach (var item in products.ToList())
            {
                ProductListViewModel model = new ProductListViewModel();
                model.Name = item.Name;
                model.ImageUrl = item.ImageUrl;
                model.Price = item.Price;
                models.Add(model);
            }
            return View(models);
        }
    }
}
