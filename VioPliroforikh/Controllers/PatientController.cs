using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VioPliroforikh.Models;
using VioPliroforikh.ViewModels;

namespace VioPliroforikh.Controllers
{
    [Authorize]
    public class PatientController : Controller
    {
        private ApplicationDbContext _context;


        public PatientController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Patient
        public ActionResult PatientSelected()
        {
            return View();

        }


        public ActionResult PatientList() {

            var patients = new PatientsList { Patients = _context.Patients.ToList() };
            return View(patients);
        }

        public ActionResult PatientForm(int? id)
        {
            if (id != null)
            {
                Patient patient = _context.Patients.SingleOrDefault(p => p.Id == id);
                return View(patient);
            }
            return View();

        }
        [Authorize(Roles = "ApplicationAdmin")]
        public ActionResult PatientSave(Patient Patient)
        {
            if (!ModelState.IsValid)
            {

                return View("PatientForm", Patient);
            }
            _context.Patients.AddOrUpdate(p =>p.Phone , Patient);
            _context.SaveChanges();
            return RedirectToAction("PatientList", "Patient");
        }

        [Authorize(Roles = "ApplicationAdmin")]
        public ActionResult PatientDelete(int id)
        {
            Patient Patient = _context.Patients.SingleOrDefault(p => p.Id == id);
            _context.Patients.Remove(Patient);
            _context.SaveChanges();
            return RedirectToAction("PatientList", "Patient");

        }
    }
}