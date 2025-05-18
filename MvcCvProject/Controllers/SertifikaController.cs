using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCvProject.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika

        //Repository Çağırma
        GenericRepository<TblSertifikalarim> repo = new GenericRepository<TblSertifikalarim>();

        //Listeleme İşlemi
        public ActionResult Index()
        {
            var sertifika = repo.List();
            return View(sertifika);
        }

        //Ekleme İşlemi
        [HttpGet]
        public ActionResult YeniSertifika()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSertifika(TblSertifikalarim p)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniSertifika");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        //Silme İşlemi
        public ActionResult SertifikaSil(int id)
        {
            var sertifika = repo.Find(x => x.ID == id);
            repo.TDelete(sertifika);
            return RedirectToAction("Index");
        }

        //Düzenleme İşlemi
        [HttpGet]
        public ActionResult SertifikaGetir(int id)
        {
            var sertifika = repo.Find(x => x.ID == id);
            ViewBag.d = id;
            return View(sertifika);
        }

        [HttpPost]
        public ActionResult SertifikaGetir(TblSertifikalarim p)
        {
            if (!ModelState.IsValid)
            {
                return View("SertifikaGetir");
            }
            var sertifika = repo.Find(x => x.ID == p.ID);
            sertifika.Aciklama = p.Aciklama;
            sertifika.Tarih = p.Tarih;
            repo.TUpdate(sertifika);
            return RedirectToAction("Index");
        }
    }
}