using Microsoft.AspNetCore.Mvc;

namespace mywebsite.Controllers
{
    public class testController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //public JsonResult index()
        //{
        //    return Json(new {
        //        id = 1,
        //        name = "reza",
        //        job ="programmer"
        //    } 
        //    );
        //}

        //--------------------------------------------------------------------------------

        //public RedirectResult index()
        //{
        //    return Redirect("https://www.digikala.com");
        //}

        //--------------------------------------------------------------------------------
        
        public RedirectToActionResult index()
        {
            return RedirectToAction("MyProduct", "Home");
        }

    }
}
