using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniHealthWebSite.Models;

namespace UniHealthWebSite.Controllers
{
    public class HomeController : Controller
    {

        
        // GET: Home
        public ActionResult index()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
        public ActionResult blogDetails()
        {
            return View();
        }
        public ActionResult blogGrid()
        {
            return View();
        }
        public ActionResult blogLarge()
        {
            return View();
        }
        public ActionResult ckeckout()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
        public ActionResult faq()
        {
            return View();
        }
        public ActionResult project1()
        {
            return View();
        }
        public ActionResult project2()
        {
            return View();
        }
        public ActionResult project3()
        {
            return View();
        }
        public ActionResult project4()
        {
            return View();
        }
        public ActionResult projectSingle()
        {
            return View();
        }
        public ActionResult service1()
        {
            return View();
        }
        public ActionResult service2()
        {
            return View();
        }
        public ActionResult service3()
        {
            return View();
        }
        public ActionResult freeContact => View();
        public ActionResult service4()
        {
            return View();
        }
        public ActionResult service5()
        {
            return View();
        }
        public ActionResult service6()
        {
            return View();
        }
        public ActionResult team()
        {
            return View();
        }
        public ActionResult testimonials()
        {
            return View();
        }
        public ActionResult FreeContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FreeContact(FormCollection form)
        {
            CMSEntities db = new CMSEntities();
            Register model = new Register();
            model.UserName = form["txtbxYetkiliKisi"].Trim();
            model.UserPhone = Convert.ToDecimal( form["txtbxTelefon"].Trim());
            model.UserCity = form["ddlSehir"].Trim();
            model.Mail = form["txtbxMail"].Trim();
            model.UserMessage = form["txtbxMesaj"].Trim();

            db.Register.Add(model);
            db.SaveChanges();
            

            return View();
        }
    }
}