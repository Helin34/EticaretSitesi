using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alina_eticaretsitesi.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string  CategoryName { get; set; }
        public string  CategoryDescription { get; set; }
        public List<Dress> Dresses { get; set; }



    }
}
