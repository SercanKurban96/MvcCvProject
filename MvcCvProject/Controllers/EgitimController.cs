using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCvProject.Controllers
{
    public class EgitimController : Controller
    {
        // GET: Egitim

        //Repository Çağırma
        GenericRepository<TblEgitimlerim> repo = new GenericRepository<TblEgitimlerim>();

        //Listeleme İşlemi
        public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }

        //Ekleme İşlemi
        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EgitimEkle(TblEgitimlerim p)
        {
            //Eğer model geçerliliği sağlamıyorsa (validation işlemini sağlamıyorsa) EgitimEkle sayfasında geri gidecektir.
            if (!ModelState.IsValid)
            {
                return View("EgitimEkle");
            }

            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        //Silme İşlemi
        public ActionResult EgitimSil(int id)
        {
            var egitim = repo.Find(x => x.ID == id);
            repo.TDelete(egitim);
            return RedirectToAction("Index");
        }

        //Düzenleme İşlemi
        [HttpGet]
        public ActionResult EgitimDuzenle(int id)
        {
            var egitim = repo.Find(x => x.ID == id);
            return View(egitim);
        }

        [HttpPost]
        public ActionResult EgitimDuzenle(TblEgitimlerim p)
        {
            //Eğer model geçerliliği sağlamıyorsa (validation işlemini sağlamıyorsa) EgitimDuzenle sayfasında geri gidecektir.
            if (!ModelState.IsValid)
            {
                return View("EgitimDuzenle");
            }
            var egitim = repo.Find(x => x.ID == p.ID);
            egitim.Baslik = p.Baslik;
            egitim.AltBaslik1 = p.AltBaslik1;
            egitim.AltBaslik2 = p.AltBaslik2;
            egitim.GNO = p.GNO;
            egitim.Tarih = p.Tarih;
            repo.TUpdate(egitim);
            return RedirectToAction("Index");
        }
    }
}