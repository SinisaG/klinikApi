﻿using HackandCraft.Api;
using HackandCraft.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Klinik.Api.Controllers.web
{
    public class ImageController : HackandCraftController
    {
        //
        // GET: /Image/

        [AuthClient]
        public string all()
        {
            try
            {
                result = orm.execObject<Result>(null, "api.admin_image_get_all");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }
    }
}
