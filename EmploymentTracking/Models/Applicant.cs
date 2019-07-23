using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmploymentTracking.Models
{
    [Table("Applicant")]
    public class Applicant { 
    
        [Key]
        public int ApplicantID { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Student ID")]
        public int StudentNumber { get; set; }
        public string Email { get; set; }
        [DisplayName("US Citizen")]
        public bool International { get; set; }
        public bool ScheduleAllowed { get; set; }
        public bool Hired { get; set; }
        public bool EForms { get; set; }
        public bool I9 { get; set; }
        public bool Orientation { get; set; }
        public bool OnSchedule { get; set; }
        public int DesiredHours { get; set; }
        public bool WorkSunday { get; set; }
        public bool WorkFootball { get; set; }
        public bool Archive { get; set; }
        public DateTime? DateArchived { get; set; }
        public DateTime DateApplied { get; set; }
        

        [ForeignKey("Location")]
        public virtual int? LocationID { get; set; }
        public virtual Location Location { get; set; }


    }
}