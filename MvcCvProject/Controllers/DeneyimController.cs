using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCvProject.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim

        //Oluşturduğumuz DeneyimRepository'i buraya çağırıyoruz.
        DeneyimRepository repo = new DeneyimRepository();

        //Listeleme İşlemi
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }

        //Ekleme İşlemi
        [HttpGet]
        public ActionResult DeneyimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeneyimEkle(TblDeneyimlerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        //Silme İşlemi
        public ActionResult DeneyimSil(int id)
        {
            TblDeneyimlerim t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

        //Deneyim Getirme İşlemi
        [HttpGet]
        public ActionResult DeneyimGetir(int id)
        {
            TblDeneyimlerim t = repo.Find(x => x.ID == id);
            return View(t);
        }
        //Deneyim Güncelleme İşlemi
        [HttpPost]
        public ActionResult DeneyimGetir(TblDeneyimlerim p)
        {
            TblDeneyimlerim t = repo.Find(x => x.ID == p.ID);
            t.Baslik = p.Baslik;
            t.AltBaslik = p.AltBaslik;
            t.Tarih = p.Tarih;
            t.Aciklama = p.Aciklama;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}