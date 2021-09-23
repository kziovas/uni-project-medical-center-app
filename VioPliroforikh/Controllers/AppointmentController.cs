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
    public class AppointmentController : Controller
    {
        private ApplicationDbContext _context;

        public AppointmentController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Appointment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AppointmentList()
        {
            var appointments = new AppointmentsList() { Appointments = _context.Appointments.ToList() };
            var appointmentPatientExamList = new AppointmentPatientExamList()
            {
                AppointmentPatientExams = new List<AppointmentPatientExamView> { }
            };

            foreach (var appointment in appointments.Appointments)
            {
                var exam = _context.Exams.SingleOrDefault(e => e.Id == appointment.ExamId);
                var patient = _context.Patients.SingleOrDefault(p => p.Id == appointment.PatientId);
                AppointmentPatientExamView appointmentPatientExam = new AppointmentPatientExamView { Exam = exam, Patient = patient, Appointment = appointment };
               

                appointmentPatientExamList.AppointmentPatientExams.Add(appointmentPatientExam);

            }
            return View(appointmentPatientExamList);
        }


        public ActionResult AppointmentForm(int? apId, int? examId)
        {
            if (apId != null)
            {
                Appointment appointment = _context.Appointments.SingleOrDefault(a => a.Id == apId);
                var exam = _context.Exams.SingleOrDefault(e => e.Id == appointment.ExamId);
                var patient = _context.Patients.SingleOrDefault(p => p.Id == appointment.PatientId);
                AppointmentPatientExamView appointmentPatientExam = new AppointmentPatientExamView { Exam = exam, Patient = patient, Appointment = appointment };
                return View(appointmentPatientExam);
            }
            else if(apId == null && examId != null) {
                Appointment appointment = new Appointment();
                appointment.Date = DateTime.Today;
                var exam = _context.Exams.SingleOrDefault(e => e.Id == examId);
                var patient = new Patient();
                AppointmentPatientExamView appointmentPatientExam = new AppointmentPatientExamView { Exam = exam, Patient = patient, Appointment = appointment };
                return View(appointmentPatientExam);
            }
            else 
            {
                Appointment appointment = new Appointment();
                appointment.Date = DateTime.Today;
                var exam = new Exam();
                var patient = new Patient();
                AppointmentPatientExamView appointmentPatientExam = new AppointmentPatientExamView { Exam = exam, Patient = patient, Appointment = appointment };
                return View(appointmentPatientExam);
            }

        }
        public ActionResult AppointmentSave(AppointmentPatientExamView ape)
        {
            if (ModelState["Patient.Email"].Errors.Count!=0)
            {

                return View("AppointmentForm", ape);
            }

        
            var exam = _context.Exams.SingleOrDefault(e => e.Name == ape.Exam.Name);
            var patient = _context.Patients.SingleOrDefault(p => p.Email == ape.Patient.Email);
            var appointment =  ape.Appointment;
            if (patient==null)
            {
                foreach (var modelValue in ModelState.Values)
                {
                    modelValue.Errors.Clear();
                }
                ModelState.AddModelError("Patient.Email", "Το Email δεν αντιστοιχεί σε κάποιον εγγεγραμμένο ασθενή");
                return View("AppointmentForm", ape);
            }

            appointment.UID = appointment.Date.ToString("dd MMM yyyy")+exam.Id+patient.Id;
            appointment.ExamId = exam.Id;
            appointment.PatientId = patient.Id;
            _context.Appointments.AddOrUpdate(a => a.UID , appointment);
            _context.SaveChanges();
            return RedirectToAction("AppointmentList");
        }


        public ActionResult AppointmentDelete(int id)
        {
            Appointment appointment = _context.Appointments.SingleOrDefault(a => a.Id == id);
            _context.Appointments.Remove(appointment);
            _context.SaveChanges();
            return RedirectToAction("AppointmentList", "Appointment");

        }
    }
}