using MVCMailService.DesignPatterns.SingletonPattern;
using MVCMailService.Models.Context;
using MVCMailService.Models.Entities;
using MVCMailService.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMailService.Controllers
{
    public class MailSendController : Controller
    {
        MyContext _db;
        public MailSendController()
        {
            _db = DBTool.DBInstance;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AppUser appUser)
        {
            MailService.Send(appUser.Email, body: "Hello World!!", subject: ":)");
            ViewBag.Message = "Mail başarılı bir şekilde gönderildi";
            return View();
        }
    }
}