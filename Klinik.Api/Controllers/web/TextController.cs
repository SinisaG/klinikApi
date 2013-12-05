using HackandCraft.Api;
using HackandCraft.Auth;
using Klinik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Klinik.Api.Controllers.web
{
    public class TextController : HackandCraftController
    {
        //
        // GET: /Text/

        [AuthClient]
        public string all()
        {
            try
            {
                result = orm.execObject<Result>(null, "api.admin_text_get_all");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string index(Text text)
        {
            try
            {
                result = orm.execObject<Result>(text, "api.admin_text_get");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string delete(Text text)
        {
            try
            {
                result = orm.execObject<Result>(text, "api.admin_text_delete");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string edit(Text text)
        {
            try
            {
                result = orm.execObject<Result>(text, "api.admin_text_edit");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string add(Text text)
        {
            try
            {
                result = orm.execObject<Result>(text, "api.admin_text_add");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

    }
}
