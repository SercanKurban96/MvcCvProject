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
    }
}