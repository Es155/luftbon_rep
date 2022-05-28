using Luftborn_Applicant_Task2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Luftborn_Applicant_Task2.ViewModel
{
    public class ApplicantData
    {
        public int ApplicantID { set; get; }
        public string ApplicantName { set; get; }

        public string ApplicantTitle { set; get; }
        public string ApplicantNumber { set; get; }
        public StatsuEnum Status { set; get; }
        public DateTime CreatedOn { set; get; }
        public bool IsDeleted { set; get; }
    }
}
