using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VioPliroforikh.Models;

namespace VioPliroforikh.ViewModels
{
    public class AppointmentPatientExamView
    {

        public Patient Patient { get; set; }


        public Exam Exam { get; set; }


        public Appointment Appointment { get; set; }
    }
}