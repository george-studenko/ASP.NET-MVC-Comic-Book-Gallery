using ASP.NET_MVC_Comic_Book_Gallery.Data;
using ASP.NET_MVC_Comic_Book_Gallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Comic_Book_Gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository repository = null;

        public ComicBooksController()
        {
            repository = new ComicBookRepository(); 
        }
        public ActionResult Detail(int? id) {     
            if(id == null)
            {
                return HttpNotFound();
            }
            var comicBook = repository.GetComicBook(id.Value);
            return View(comicBook);
        }

    }
}