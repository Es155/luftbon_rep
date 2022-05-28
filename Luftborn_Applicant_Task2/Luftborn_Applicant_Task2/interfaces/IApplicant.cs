using Luftborn_Applicant_Task2.Models;
using Luftborn_Applicant_Task2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luftborn_Applicant_Task2.interfaces
{
   public  interface IApplicant : IRepository<ApplicantModel>
    {
        public ApplicantData BindApplicantModel(ApplicantModel model);
        public List<ApplicantData> GetList();
      
    }
}
