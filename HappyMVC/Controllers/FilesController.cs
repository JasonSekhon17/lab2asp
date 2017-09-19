using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace HappyMVC.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/TextFiles"));
            ViewBag.files = files;
            return View();
        }

        public ActionResult Contents(int id) {
            var file = Directory.GetFiles(Server.MapPath("~/TextFiles"))[id];
            string fileContent = System.IO.File.ReadAllText(file);
            ViewBag.fileContent = fileContent;
            return View();
        }
    }
}