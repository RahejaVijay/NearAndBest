using NearAndBest.Models.Admin;
using NearAndBest.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NearAndBest.Web.Controllers.Admin
{
    public class RolesController : Controller
    {
        //
        // GET: /Roles/
        public ActionResult Index()
        {                      
            ResponseResult<RoleModel> response = ServiceHelper<RoleModel>.GetResource(Constants.Resources.Roles);

            
            return View(response.Data);
        }
	}
}