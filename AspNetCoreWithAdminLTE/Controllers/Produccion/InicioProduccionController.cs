using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWithAdminLTE.Controllers.Produccion
{
    public class InicioProduccionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
