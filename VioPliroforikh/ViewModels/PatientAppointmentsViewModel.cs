using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VioPliroforikh.Models;

namespace VioPliroforikh.ViewModels
{
    public class PatientAppointmentsViewModel
    {
        public Patient Patient { get; set; }

        public  AppointmentsList Appointments { get; set; }
    }
}