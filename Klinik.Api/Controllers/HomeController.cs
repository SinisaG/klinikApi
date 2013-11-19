using HackandCraft.Api;
using HackandCraft.Auth;
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
        [AuthClient]
        public string Index()
        {
            return "hello world";
        }

    }
}
