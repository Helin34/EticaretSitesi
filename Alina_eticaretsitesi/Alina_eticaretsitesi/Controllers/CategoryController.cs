using Alina_eticaretsitesi.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alina_eticaretsitesi.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            CategoryRepository categoryRepository = new CategoryRepository();

            return View(categoryRepository .TList ());
        }
    }
}
