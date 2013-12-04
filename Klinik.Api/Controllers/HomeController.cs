using HackandCraft.Api;
using HackandCraft.Auth;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Klinik.Api.Controllers
{
    public class HomeController : HackandCraftController
    {
        [AuthClient]
        public string Index()
        {
            return "hello world";
        }
    }
}
