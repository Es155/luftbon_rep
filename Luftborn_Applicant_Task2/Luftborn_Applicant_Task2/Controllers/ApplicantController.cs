using Luftborn_Applicant_Task2.interfaces;
using Luftborn_Applicant_Task2.Models;
using Luftborn_Applicant_Task2.ViewModel;
using Luftborn_Applicant_Task2.services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Luftborn_Applicant_Task2.Controllers
{
    public class ApplicantController : Controller
    {
        private readonly DB_Context dB_Context;
        private readonly IApplicant _applicant;
        public ApplicantController(DB_Context _db)
        {
            dB_Context = _db;
            _applicant = new ApplicantService(dB_Context);
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new ApplicantViewModel()
            {
                ListOfApplicant = _applicant.GetList(),
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Create(ApplicantViewModel model)
        {
            model.ApptModel.CreatedOn = DateTime.Now;
            if(ModelState.IsValid)
            {
                _applicant.Add(model.ApptModel);

                TempData["message"] = "inserted Successfully";
            }
            else
                TempData["message"] = "inserted Successfully";
            model.ListOfApplicant = _applicant.GetList();
            return View(model);

        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = _applicant.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(ApplicantModel model)
        {
            if (ModelState.IsValid)
            {
                _applicant.Update(model);
                TempData["message"] = "Updated Successfully";
            }
            else
                TempData["message"] = "Updated Successfully";
            return RedirectToAction("Create");
        }

        public IActionResult Delete(int id)
        {
            var model = _applicant.GetById(id);
            model.IsDeleted = true;
            _applicant.Delete(model);
            return RedirectToAction("Create");

        }
            
    }
}
