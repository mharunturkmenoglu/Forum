using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();

        [AllowAnonymous]
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);
            return View(contactvalues);
        }
        [AllowAnonymous]
        public PartialViewResult ContactPartial()
        {
            var values = cm.GetList();
            return PartialView(values);
        }
    }
}