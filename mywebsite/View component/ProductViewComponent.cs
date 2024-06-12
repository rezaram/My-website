using Microsoft.AspNetCore.Mvc;
using mywebsite.Models;
using System.Collections.Generic;

namespace mywebsite.View_component
{
    public class ProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Products = new List<Product>
            {
                new Product (1 ,"محصول مورد نظر","ahura-theme-1.jpg",119),
                new Product (2 ,"محصول مورد نظر","ahura-theme-1.jpg",119),
                new Product (3 ,"محصول مورد نظر","ahura-theme-1.jpg",119),
            };

            return View("_Product" , Products);
        }
    }
}
