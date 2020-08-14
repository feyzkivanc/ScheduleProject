using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class NewEvent : Controller
    {
        private readonly ConnectionStringClass _cc;
        public NewEvent(ConnectionStringClass cc)
        {
            _cc = cc;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Empty e)

        {
            _cc.Add(e);

            _cc.SaveChanges();

            ViewBag.message = "The event " + e.EventID + " is saved";

            return View();
        }
    }
}
