using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Comic_Book_Gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail() {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }

            return Content ("Hello from the details page");
        }

    }
}