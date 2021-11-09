using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code_Web.Models;
namespace Code_Web.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        QLBDSEntities model = new QLBDSEntities();
        public ActionResult Index()
        {
            return View();
        }
    }
}