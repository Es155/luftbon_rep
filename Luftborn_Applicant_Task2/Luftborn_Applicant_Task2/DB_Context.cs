using Luftborn_Applicant_Task2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Luftborn_Applicant_Task2
{
    public class DB_Context : DbContext
    {
        public DB_Context(DbContextOptions<DB_Context> options)
           : base(options)
        {
        }

        public DbSet<ApplicantModel> ApplicantModel { get; set; }
    }

}

