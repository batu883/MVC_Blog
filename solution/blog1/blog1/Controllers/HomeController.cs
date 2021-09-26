using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blog1.Models;

namespace blog1.Controllers
{
    public class HomeController : Controller
    {
        Blog2Entities3 db = new Blog2Entities3();
        public ActionResult Anasayfa()
        {
            //var post = db.postlar.ToList();

            var postlar = db.postlar.ToList();
            var kategori = db.Kategori.ToList();
            return View(Tuple.Create(postlar, kategori));

            //return View(viewModel);
            //return View(post);
        }



        //public ActionResult Kategori()
        //{
        //    var kategori = db.Kategori.ToList();
        //    return View(kategori);
        //}


        public ActionResult katsıra(int id)
        {
            var ktsy = db.postlar.Where(x => x.KategoriID == id).ToList();
            return View(ktsy);
        }





    }
}