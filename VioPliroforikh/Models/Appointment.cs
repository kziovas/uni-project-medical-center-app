using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VioPliroforikh.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Display(Name = "Ημμερομηνία")]
        [Required(ErrorMessage = "Το πεδίο 'Ημμερομηνία' είναι υποχρεωτικό")]
        public DateTime Date { get; set; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Σχόλια-Παρατηρήσεις")]
        public string Comments { get; set; }
        
        public string UID { get; set; }

        public int ExamId { get; set; }

        public int PatientId { get; set; }

        public Boolean Confirmed { get; set; }

        public Boolean Paid { get; set; }
    }
}