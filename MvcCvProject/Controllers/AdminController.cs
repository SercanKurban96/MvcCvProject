using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCvProject.Controllers
{
    [AllowAnonymous]
    public class AdminController : Controller
    {
        // GET: Admin
        GenericRepository<TblAdmin> repo = new GenericRepository<TblAdmin>();
        public ActionResult Index()
        {
            var liste = repo.List();
            return View(liste);
        }

        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminEkle(TblAdmin p)
        {
            if (!ModelState.IsValid)
            {
                return View("AdminEkle");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult AdminSil(int id)
        {
            var admin = repo.Find(x => x.ID == id);
            repo.TDelete(admin);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AdminDuzenle(int id)
        {
            var admin = repo.Find(x => x.ID == id);
            return View(admin);
        }

        [HttpPost]
        public ActionResult AdminDuzenle(TblAdmin p)
        {
            if (!ModelState.IsValid)
            {
                return View("AdminDuzenle");
            }
            var admin = repo.Find(x => x.ID == p.ID);
            admin.KullaniciAdi = p.KullaniciAdi;
            admin.Sifre = p.Sifre;
            repo.TUpdate(admin);
            return RedirectToAction("Index");
        }
    }
}