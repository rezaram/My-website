using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mywebsite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mywebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<item> _items = new List<item>
        {
            new item
            {
                id = 1,title = "تیشرت مردانه سیاه", image="7a9fc279973941176c49f4ef84938cb137209e82_1670691560.jpg", price ="18$",link= "www.digikala.com"
            },
            new item
            {
                id = 1,title = "تیشرت مردانه سیاه", image="7a9fc279973941176c49f4ef84938cb137209e82_1670691560.jpg", price ="18$",link= "www.digikala.com"
            },
            new item
            {
                id = 1,title = "تیشرت مردانه سیاه", image="7a9fc279973941176c49f4ef84938cb137209e82_1670691560.jpg", price ="18$",link= "www.digikala.com"
            },
            new item
            {
                id = 1,title = "تیشرت مردانه سیاه", image="7a9fc279973941176c49f4ef84938cb137209e82_1670691560.jpg", price ="18$",link= "www.digikala.com"
            },
        };


        public IActionResult Index()
        {
            ViewData["headingTitle"] = "فروشگاه پارس آنلاین";
            ViewData["headingText"] = "فروشگاه آنلاین ما به شما اجازه می‌دهد تا از پیشنهادات بسیاری از محصولات با کیفیت در بازار مصرف کنید. ما در حال حاضر محصولات زیادی ارائه می‌دهیم، از جمله لباس، اکسسوارها، کالای دیجیتال، و ... همچنین، ما تلاش برای ارائه بهترین سرویس پس از فروش و بهبود تجربه خرید شما داریم";

            return View(_items);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public IActionResult Kala()
        {
            return View();
        }
        public IActionResult About()
        {
            var reza = new info()
            {
                phone = "0912345678",
                email = "rezaramezannejad8632@gmail.com",
                instagram = "reza.ram32",
            };
            return View(reza);
        }

    }
}
