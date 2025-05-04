using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCvProject.Controllers
{
    public class YetenekController : Controller
    {
        // GET: Yetenek

        //Repository Çağırma
        GenericRepository<TblYeteneklerim> repo = new GenericRepository<TblYeteneklerim>();

        //Listeleme İşlemi
        public ActionResult Index()
        {
            var yetenekler = repo.List();
            return View(yetenekler);
        }

        //Ekleme İşlemi
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(TblYeteneklerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        //Silme İşlemi
        public ActionResult YetenekSil(int id)
        {
            var yetenek = repo.Find(x => x.ID == id);
            repo.TDelete(yetenek);
            return RedirectToAction("Index");
        }

        //Düzenleme İşlemi
        [HttpGet]
        public ActionResult YetenekDuzenle(int id)
        {
            var yetenek = repo.Find(x => x.ID == id);
            return View(yetenek);
        }
        [HttpPost]
        public ActionResult YetenekDuzenle(TblYeteneklerim p)
        {
            var y = repo.Find(x => x.ID == p.ID);
            y.Yetenek = p.Yetenek;
            y.Oran = p.Oran;
            repo.TUpdate(y);
            return RedirectToAction("Index");
        }
    }
}