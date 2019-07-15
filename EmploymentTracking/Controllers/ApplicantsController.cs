using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmploymentTracking.DAL;
using EmploymentTracking.Models;

namespace EmploymentTracking.Controllers
{
    public class ApplicantsController : Controller
    {
        private TrackingContext db = new TrackingContext();

        // GET: Applicants
       // [Authorize(Roles = "Manager")]
        public ActionResult Index()
        {
            var application = db.Application.Include(a => a.Location);
            return View(application.ToList());
        }

        // GET: Applicants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Application.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // GET: Applicants/Create
        public ActionResult Create()
        {
            ViewBag.LocationID = new SelectList(db.Location, "LocationID", "LocationName");
            return View();
        }

        // POST: Applicants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ApplicantID,FirstName,LastName,StudentNumber,Email,ScheduleAllowed,Hired,EPaf,I9,Training,DesiredHours,WorkSunday,WorkFootball,DateApplied,LocationID")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                db.Application.Add(applicant);
                applicant.DateApplied = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LocationID = new SelectList(db.Location, "LocationID", "LocationName", applicant.LocationID);
            return View(applicant);
        }

        // GET: Applicants/Create
        [Authorize]
        public ActionResult ApplicantCreate()
        {
            ViewBag.LocationID = new SelectList(db.Location, "LocationID", "LocationName");
            return View();
        }

        // POST: Applicants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ApplicantCreate([Bind(Include = "ApplicantID,FirstName,LastName,StudentNumber,Email,ScheduleAllowed,Hired,EPaf,I9,Training,DesiredHours,WorkSunday,WorkFootball,DateApplied,LocationID")] Applicant applicant)
        {
            string LinkID = System.Web.HttpContext.Current.Request.Url.AbsoluteUri;
            LinkID = LinkID.Substring(LinkID.Length - 23);

            if (ModelState.IsValid)
            {
                db.Application.Add(applicant);
                applicant.DateApplied = DateTime.Now;
                db.SaveChanges();
                return Redirect("https://byu.hirevue.com/signup/" + LinkID);
            }

            ViewBag.LocationID = new SelectList(db.Location, "LocationID", "LocationName", applicant.LocationID);
            return View(applicant);
        }


        // GET: Applicants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Application.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            ViewBag.LocationID = new SelectList(db.Location, "LocationID", "LocationName", applicant.LocationID);
            return View(applicant);
        }

        // POST: Applicants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ApplicantID,FirstName,LastName,StudentNumber,Email,ScheduleAllowed,Hired,EPaf,I9,Training,DesiredHours,WorkSunday,WorkFootball,DateApplied,LocationID")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LocationID = new SelectList(db.Location, "LocationID", "LocationName", applicant.LocationID);
            return View(applicant);
        }

        // GET: Applicants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Application.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // POST: Applicants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Applicant applicant = db.Application.Find(id);
            db.Application.Remove(applicant);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Schedule(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Application.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

    }
}
