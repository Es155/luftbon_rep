using Luftborn_Applicant_Task2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Luftborn_Applicant_Task2.Controllers
{
    public class HomeController : Controller
    {
        public readonly DB_Context dB_Context;
        public HomeController(DB_Context dB_)
        {
            dB_Context = dB_;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Create(ApplicantModel model)
        {
            model.CreatedOn = DateTime.Now;
            
            if(ModelState.IsValid)
            {
                dB_Context.ApplicantModel.Add(model);
                dB_Context.SaveChanges();
            }
                return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new ApplicantModel();
            return View(model);
        }
    }
}
