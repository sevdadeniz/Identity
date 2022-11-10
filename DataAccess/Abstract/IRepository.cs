using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        void ekle(T t);
        int Sil(T t);
        int guncelle(T t);
        List<T> Listele();
        T Get(int id);
    }
}
