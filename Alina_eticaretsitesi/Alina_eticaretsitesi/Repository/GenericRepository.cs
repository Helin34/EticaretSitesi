using Alina_eticaretsitesi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alina_eticaretsitesi.Repository
{
    public class GenericRepository<T> where T : class, new()

    {
        Context c = new Context();


        public List<T> TList()
        {
            return c.Set <T>().ToList();

        }
        public void TAdd(T p)
        {
            c.Set <T>().Add(p);
            c.SaveChanges();

        }
        public void TDelete(T p)
        {
            c.Set<T>().Remove(p);
            c.SaveChanges();

        }
        public void TUpdate(T p)
        {
            c.Set<T>().Update(p);
            c.SaveChanges();

        }
        public void TGet(int id)
        {
            c.Set<T>().Find(id);

        }
    }
}
