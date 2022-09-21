using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context c = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }        
       
        [HttpPost]
        public ActionResult Index(Iletisim i)
        {
            c.Iletisims.Add(i);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}