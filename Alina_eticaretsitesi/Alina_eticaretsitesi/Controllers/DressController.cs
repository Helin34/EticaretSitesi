using Alina_eticaretsitesi.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alina_eticaretsitesi.Controllers
{
    public class DressController : Controller
    {
        public IActionResult Index()
        {
            DressRepository dressRepository = new DressRepository();

            return View(dressRepository .TList ());
        }
    }
}
