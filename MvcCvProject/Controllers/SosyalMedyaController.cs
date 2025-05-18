using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCvProject.Controllers
{
    public class SosyalMedyaController : Controller
    {
        // GET: SosyalMedya

        GenericRepository<TblSosyalMedya> repo = new GenericRepository<TblSosyalMedya>();
        public ActionResult Index()
        {
            var sosyalmedya = repo.List();
            return View(sosyalmedya);
        }

        [HttpGet]
        public ActionResult YeniSosyalMedya()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSosyalMedya(TblSosyalMedya p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult SosyalMedyaSil(int id)
        {
            var sosyalmedya = repo.Find(x => x.ID == id);
            sosyalmedya.Durum = false;
            repo.TUpdate(sosyalmedya);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SosyalMedyaDuzenle(int id)
        {
            var sosyalmedya = repo.Find(x => x.ID == id);
            return View(sosyalmedya);
        }

        [HttpPost]
        public ActionResult SosyalMedyaDuzenle(TblSosyalMedya p)
        {
            var sosyalmedya = repo.Find(x => x.ID == p.ID);
            sosyalmedya.Durum = true;
            sosyalmedya.Ad = p.Ad;
            sosyalmedya.Link = p.Link;
            sosyalmedya.Ikon = p.Ikon;
            repo.TUpdate(sosyalmedya);
            return RedirectToAction("Index");
        }
    }
}