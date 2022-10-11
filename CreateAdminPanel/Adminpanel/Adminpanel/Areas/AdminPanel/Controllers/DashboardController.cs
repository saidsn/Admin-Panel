using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adminpanel.Areas.AdminPanel.Controllers
{
    public class DashboardController : Controller
    {

        [Area("AdminPanel")]
        public ActionResult Index()
        {
            return View();
        }

   
    
     
    }
}
