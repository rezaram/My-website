using Microsoft.AspNetCore.Mvc;
using mywebsite.Models;
using System.Collections.Generic;

namespace mywebsite.View_component
{
    public class DiscountViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Discounts = new List<Discount>
            {
                new Discount (1 ,"محصول مورد نظر","83af811f2b8fd43529a00c8d4bdd35a86f59346f_1647152703.jpg",119,"20%"),
                new Discount (2 ,"محصول مورد نظر","83af811f2b8fd43529a00c8d4bdd35a86f59346f_1647152703.jpg",119, "15%"),
                new Discount (3 ,"محصول مورد نظر","83af811f2b8fd43529a00c8d4bdd35a86f59346f_1647152703.jpg",119,"45%"),
            };

            return View("_Discount", Discounts);
        }
    }
}
