using HackandCraft.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Klinik.Api.Controllers
{
    public class HomeController : HackandCraftController 
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
