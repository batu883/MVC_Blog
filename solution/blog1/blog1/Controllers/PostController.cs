using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blog1.Models;
namespace blog1.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        Blog2Entities3 db = new Blog2Entities3();
        public ActionResult Post(int id)
        {
            var dty = db.postlar.Find(id);
            return View(dty);
        }


        [HttpGet]
        public ActionResult Yorum()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Yorum(Yorum y)
        {
            db.Yorum.Add(y);
            db.SaveChanges();
            return View("Yorum");


        }








    }
}