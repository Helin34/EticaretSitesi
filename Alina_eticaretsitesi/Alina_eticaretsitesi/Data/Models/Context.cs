using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alina_eticaretsitesi.Data.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-MFSA08GG\\MYDATABASESERVER; database=DbCoreDress;integrated security=true");

        }
        public DbSet <Dress> Dresses { get; set; }
        public DbSet <Category> Categories  { get; set; }

    }
}
