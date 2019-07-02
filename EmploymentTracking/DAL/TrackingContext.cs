using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EmploymentTracking.Models;


namespace EmploymentTracking.DAL
{
    public class TrackingContext : DbContext
    {
        public TrackingContext() : base("TrackingContext")
        {

        }

        public DbSet<Location> Location { get; set; }
        public DbSet<Applicant> Application { get; set; }

    }
}