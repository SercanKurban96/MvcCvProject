using MvcCvProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcCvProject.Controllers
{
    [AllowAnonymous] //Tüm sayfalara erişmesine izin verir.
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblAdmin p)
        {
            DbCvEntities db = new DbCvEntities(); //Entity oluşturuyoruz.
            var bilgi = db.TblAdmin.FirstOrDefault(x => x.KullaniciAdi == p.KullaniciAdi && x.Sifre == p.Sifre); //Buradaki ifade TblAdmin tablosuna ait kullanıcı adı ve şifrenin birbirine eşit olup olmadığı anlamına gelir.

            if (bilgi != null) //Eğer bilgi değeri null değerinden farklıysa anlamına gelir.
            {
                FormsAuthentication.SetAuthCookie(bilgi.KullaniciAdi, false); //Form yetkilendirme işlemi yapılır.
                Session["KullaniciAdi"] = bilgi.KullaniciAdi.ToString(); //Oturum yönetimindeki kullanıcı adımız
                return RedirectToAction("Index", "Deneyim"); //Bilgiler doğruysa Deneyim sayfasına yönlendir.
            }
            else
            {
                return RedirectToAction("Index", "Login"); //Bilgiler hatalıysa tekrardan Login sayfasına yönlendir.
            }
        }

        //Çıkış İşlemi
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}