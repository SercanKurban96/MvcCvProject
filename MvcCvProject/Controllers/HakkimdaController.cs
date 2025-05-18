using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCvProject.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        GenericRepository<TblHakkimda> repo = new GenericRepository<TblHakkimda>();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(TblHakkimda p)
        {
            var hakkimda = repo.Find(x => x.ID == 1);
            hakkimda.Ad = p.Ad;
            hakkimda.Soyad = p.Soyad;
            hakkimda.Adres = p.Adres;
            hakkimda.Mail = p.Mail;
            hakkimda.Telefon = p.Telefon;
            hakkimda.Aciklama = p.Aciklama;
            hakkimda.Resim = p.Resim;
            repo.TUpdate(hakkimda);
            return RedirectToAction("Index");
        }
    }
}