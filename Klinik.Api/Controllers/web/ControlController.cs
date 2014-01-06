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
    public class ControlController : HackandCraftController
    {
        [AuthClient]
        public string all()
        {
            try
            {
                result = orm.execObject<Result>(null, "api.admin_control_get_all");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string index(Control control)
        {
            try
            {
                result = orm.execObject<Result>(control, "api.control_get");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        public string edit(Control control)
        {
            try
            {
                result = orm.execObject<Result>(control, "api.control_get_edit");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }
    }
}
