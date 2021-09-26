using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blog1.Models;

namespace blog1.Controllers
{
    public class AdminController : Controller
    {

        Blog2Entities3 db = new Blog2Entities3();



        public ActionResult Admin()
        {
            var listele = db.postlar.ToList();
            return View(listele);
        }



        public ActionResult Sil(int id)
        {

            var hst2 = db.Yorum.Find(id);
            var hst = db.postlar.Find(id);
            db.postlar.Remove(hst);
            db.Yorum.Remove(hst2);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }



        [HttpGet]
        public ActionResult PostEkle()
        {

            return View();
        }

        [HttpPost]
        public ActionResult PostEkle(postlar p)
        {
            db.postlar.Add(p);
            db.SaveChanges();
            return RedirectToAction("PostEkle");

        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {

            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(Kategori k)
        {
            db.Kategori.Add(k);
            db.SaveChanges();
            return RedirectToAction("KategoriEkle");

        }

        [HttpGet]
        public ActionResult KategoriSil()
        {
            var listele = db.Kategori.ToList();
            return View(listele);
        }


        
        public ActionResult KSil(int id)
        {
            var hst = db.Kategori.Find(id);

            db.Kategori.Remove(hst);
            db.SaveChanges();
            return RedirectToAction("KategoriSil");
        }



    }




}