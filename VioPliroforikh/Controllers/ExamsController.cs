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
    public class ExamsController : Controller
    {
        private ApplicationDbContext _context;


        public ExamsController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult ExamIndex(int? id)
        {
            var examsList = _context.Exams.ToList();
            if (id == null)
            {
                id = 1;
            }

            Exam exam = _context.Exams.SingleOrDefault(e => e.Id == id);
            ExamIndexViewClass examsIndex = new ExamIndexViewClass() { Exam = exam, Exams = examsList };
            return View(examsIndex);
        }



        public ActionResult ExamFilter(int? id,string filter)
        {
            if (filter == null)
            {
                filter = "";
            }
            var examsList = _context.Exams.Where(e => e.Name.Contains(filter)).ToList();
            Exam exam;
            if (examsList != null && examsList.Count()!=0)
            {
                if (id != null)
                {
                    exam = examsList.FirstOrDefault(e => e.Id == id);
                }
                else {
                    exam = examsList.FirstOrDefault();
                }
                
            }
            else
            {
                if (id != null)
                {
                    exam = _context.Exams.SingleOrDefault(e => e.Id == id);
                }

                else {
                    exam = _context.Exams.SingleOrDefault(e => e.Id == 1);
                }
                   
            }


            ExamIndexViewClass examsIndex = new ExamIndexViewClass() { Exam = exam, Exams = examsList, Filter=filter };
            return View("ExamIndex", examsIndex);

        }


        public ActionResult ExamSelected(int id)
        {
            Exam exam = _context.Exams.SingleOrDefault(e => e.Id == id);
            return View(exam);
        }


        public ActionResult ExamList()
        {
            return View();
        }

        [Authorize(Roles = "ApplicationAdmin")]
        public ActionResult ExamNew(int? id)
        {
            if (id!=null)
            {
                Exam exam = _context.Exams.SingleOrDefault(e => e.Id == id);
                return View(exam);
            }
            return View();
        }

        [Authorize(Roles = "ApplicationAdmin")]
        public ActionResult ExamSave(Exam exam)
        {
            if (!ModelState.IsValid)
            {

                return View("ExamNew",exam);
            }
            _context.Exams.AddOrUpdate(e => e.Name, exam);
            _context.SaveChanges();
            return RedirectToAction("ExamIndex", "Exams");
        }

        [Authorize(Roles = "ApplicationAdmin")]
        public ActionResult ExamDelete(int id)
        {
            Exam exam = _context.Exams.SingleOrDefault(e => e.Id == id);
            _context.Exams.Remove(exam);
            _context.SaveChanges();
            return RedirectToAction("ExamIndex", "Exams");

        }
        [Authorize(Roles = "ApplicationAdmin")]
        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }
    }

}