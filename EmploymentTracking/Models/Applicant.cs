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
        public string Email { get; set; }
        public bool Hired { get; set; }
        public bool EPaf { get; set; }
        public bool I9 { get; set; }
        public bool Training { get; set; }

        [ForeignKey("Location")]
        public virtual int? LocationID { get; set; }
        public virtual Location Location { get; set; }


    }
}