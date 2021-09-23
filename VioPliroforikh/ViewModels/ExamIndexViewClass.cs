using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VioPliroforikh.Models;

namespace VioPliroforikh.ViewModels
{
    public class ExamIndexViewClass
    {
        public List<Exam> Exams { get; set; }
        public Exam Exam;
        public string Filter;
    }
}