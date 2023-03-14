using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOrganikSebzeler.Models.Entity;

namespace MvcOrganikSebzeler.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        ProjeTarimEntities db= new ProjeTarimEntities();
        public ActionResult Index()
        {
            var degerler = db.TblUrunler.ToList();
            return View(degerler);
        }
    }
}