using Luftborn_Applicant_Task2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Luftborn_Applicant_Task2.ViewModel
{
    public class ApplicantViewModel
    {
        public ApplicantViewModel()
        {
            ListOfApplicant = new List<ApplicantData>();
            ApptModel = new ApplicantModel();
        }

        public ApplicantModel ApptModel { set; get; }

        public IEnumerable<ApplicantData> ListOfApplicant { set; get; }
    }
}
