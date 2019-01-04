using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniHealthWebSite.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Net.Mail;

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
        public ActionResult medicawellPremium()
        {
            return View();
        }
        public ActionResult blogGrid()
        {
            return View();
        }
        public ActionResult ourProducts()
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
        public ActionResult Faq()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Faq(FormCollection form)
        {
            CMSEntities db = new CMSEntities();
            FaqQuestions model = new FaqQuestions();
            model.UserName = form["txtname"].Trim();
            model.UserMail = form["txtemail"].Trim();
            model.Subject = form["txtsubject"].Trim();
            model.Questions = form["txtmessage"].Trim();
            db.FaqQuestions.Add(model);
            db.SaveChanges();

            return View();
        }
        public ActionResult project1()
        {
            return View();
        }
        public ActionResult dealership()
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
        public ActionResult freeContact()
        {
            return View();
        }

        //[HttpGet]
        //public ActionResult FreeContact()
        //{
        //    CMSEntitiesDBContext db = new CMSEntitiesDBContext();
        //    List<SelectListItem> ListSelectListItem = new List<SelectListItem>();
        //    foreach (CityName cityNameText in db.Cities)
        //    {
        //        SelectListItem selectListItem = new SelectListItem()
        //        {
        //            Text = cityNameText.CityNameText,
        //            Value = cityNameText.CityId.ToString()

        //        };
        //        ListSelectListItem.Add(selectListItem);
        //    }
        //    CitiesViewModel citiesViewModel = new CitiesViewModel();
        //    citiesViewModel.Cities = ListSelectListItem;
        //    return View(citiesViewModel);
        //}


        //    return View();
        //}

        //[HttpPost]
        //public ActionResult About(FormCollection form)
        //{
        //    CMSEntities db = new CMSEntities();
        //    FreeTrial mdl = new FreeTrial();
        //    mdl.NameSurname = form["txtbxYetkiliKisi"].Trim();
        //    mdl.EMail = form["txtbxMail"].Trim();
        //    mdl.Phone = Convert.ToString(form["txtbxTelefon"].Trim()); ;
        //    mdl.CompanyName = form["txtbxFirmaAdi"].Trim();
        //    db.FreeTrial.Add(mdl);
        //    db.SaveChanges();


        //    return View();
        //}
        [HttpPost]
        public ActionResult FreeContact(FormCollection form)
        {
            CMSEntities db = new CMSEntities();
            Register model = new Register();
            model.UserName = form["txtbxYetkiliKisi"].Trim();
            model.UserPhone = Convert.ToDecimal(form["txtbxTelefon"].Trim());
            model.Mail = form["txtbxMail"].Trim();
            model.UserMessage = form["txtbxMesaj"].Trim();
            db.Register.Add(model);
            db.SaveChanges();


            sendMail(model.Mail, "Kaydınız Alınmıştır", "Kaydettik");


            return View();
        }
        public void sendMail(String tomail, String subject = "", String message = "")
        {

            MailMessage eposta = new MailMessage();
            eposta.From = new MailAddress("beritansamyeli@yandex.com");
            eposta.To.Add(tomail);
            eposta.Subject = subject;
            eposta.Body = message;
            eposta.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            smtp.Credentials = new NetworkCredential("beritansamyeli@yandex.com", "21ast73");
            //smtp.Port = 587;
            smtp.EnableSsl = true;
            //smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            //smtp.UseDefaultCredentials = false;
           // smtp.Host = "smtp.gmail.com";
            smtp.Send(eposta);

        }

    }

}

