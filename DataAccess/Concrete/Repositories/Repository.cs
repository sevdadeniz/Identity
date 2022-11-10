using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();

        public void ekle(T t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public T Get(int id)
        {
            return c.Set<T>().Find(id);
        }

        public int guncelle(T t)
        {
            c.Update(t);
            return c.SaveChanges();
        }

        public List<T> Listele()
        {
            return c.Set<T>().ToList();
        }

        public int Sil(T t)
        {
            c.Remove(t);
            return c.SaveChanges();
        }
    }
}
