using MvcCvProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MvcCvProject.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        DbCvEntities db = new DbCvEntities();

        //Listeleme İşlemi
        public List<T> List()
        {
            return db.Set<T>().ToList();
        }

        //Ekleme İşlemi
        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }

        //Silme İşlemi
        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }

        //ID'ye Göre Getirme İşlemi
        public T Get(int id)
        {
            return db.Set<T>().Find(id);
        }

        //Güncelleme İşlemi
        public void TUpdate(T p)
        {
            db.SaveChanges();
        }

        //Silme İşleminden Önce Silinecek Olan Değeri Bulan Metot
        public T Find(Expression<Func<T,bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }
    }
}