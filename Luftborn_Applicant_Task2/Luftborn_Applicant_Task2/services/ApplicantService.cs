using Luftborn_Applicant_Task2.interfaces;
using Luftborn_Applicant_Task2.Models;
using Luftborn_Applicant_Task2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Luftborn_Applicant_Task2.services
{
    public class ApplicantService : Repository<ApplicantModel> , IApplicant
    {
      
        private readonly DB_Context _context;
        public ApplicantService(DB_Context context) : base(context)
        {
            _context = context;
        }

       public ApplicantData BindApplicantModel(ApplicantModel model)
        {
            return new ApplicantData()
            {
                ApplicantID = model.ApplicantID,
                Status = (Enums.StatsuEnum)model.Status,
                ApplicantNumber = model.ApplicantNumber,
                ApplicantTitle = model.ApplicantTitle,
                CreatedOn = model.CreatedOn,
                ApplicantName = model.ApplicantName
            };
        }

        public List<ApplicantData>  GetList()
        {
            var result = new List<ApplicantData>();
            var model = _context.ApplicantModel.Where(x=>!x.IsDeleted).ToList();
            foreach(var row in model)
            {
                result.Add(BindApplicantModel(row));
            }
            return result;
        }
    }
}