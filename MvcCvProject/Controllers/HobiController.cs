using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCvProject.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi

        GenericRepository<TblHobilerim> repo = new GenericRepository<TblHobilerim>();
        public ActionResult Index()
        {
            var hobi = repo.List();
            return View(hobi);
        }

        [HttpGet]
        public ActionResult YeniHobi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniHobi(TblHobilerim p)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniHobi");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult HobiSil(int id)
        {
            var hobi = repo.Find(x => x.ID == id);
            repo.TDelete(hobi);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult HobiDuzenle(int id)
        {
            var hobi = repo.Find(x => x.ID == id);
            return View(hobi);
        }

        [HttpPost]
        public ActionResult HobiDuzenle(TblHobilerim p)
        {
            if (!ModelState.IsValid)
            {
                return View("HobiDuzenle");
            }
            var hobi = repo.Find(x => x.ID == p.ID);
            hobi.Aciklama1 = p.Aciklama1;
            hobi.Aciklama2 = p.Aciklama2;
            repo.TUpdate(hobi);
            return RedirectToAction("Index");
        }
    }
}