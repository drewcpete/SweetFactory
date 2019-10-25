using Microsoft.AspNetCore.Mvc;
using SweetFactory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SweetFactory.Controllers
{
    public class FlavorsController : Controller
    {
        private readonly SweetFactoryContext _db;
        
        
        public FlavorsController(SweetFactoryContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Flavor> model = _db.Flavors.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Flavor flavor)
        {
            _db.Flavors.Add(flavor);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult Delete(int id)
        {
            var thisFlavor = _db.Flavors.FirstOrDefault(f => f.FlavorID == id);
            _db.Flavors.Remove(thisFlavor);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}