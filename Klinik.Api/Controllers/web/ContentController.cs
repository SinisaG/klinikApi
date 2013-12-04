using HackandCraft.Api;
using HackandCraft.Auth;
using Klinik.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Klinik.Api.Controllers.web
{
    public class ContentController : HackandCraftController
    {
        [AuthClient]
        public string index()
        {
            try
            {
                result = orm.execObject<Result>(null, "api.admin_static_get");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string set(Content content)
        {
            try
            {
                result = orm.execObject<Result>(content, "api.admin_static_set");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }
    }
}
