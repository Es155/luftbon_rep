using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Luftborn_Applicant_Task2.Models
{
    [Table("Applicant_Tbl")]
    public class ApplicantModel
    {
        [Key]
        public int ApplicantID { set; get; }
        public string ApplicantName { set; get; }

        public string ApplicantTitle { set; get; }
        public string ApplicantNumber { set; get; }
        public int Status { set; get; }
        public DateTime CreatedOn { set; get; }
        public bool IsDeleted { set; get; }
        

    }
}
