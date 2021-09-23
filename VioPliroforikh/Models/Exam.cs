using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace VioPliroforikh.Models
{
    public class Exam
    {
        public int Id { get; set; }

        
        [Column(TypeName = "nvarchar")]
        [Display(Name ="Όνομα Εξέτασης")]
        [Required(ErrorMessage = "Το πεδίο 'Όνομα Εξέτασης' είναι υποχρεωτικό")]
        [StringLength(255)]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Περιγραφή")]
        public string Description{ get; set; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Προετοιμασία")]
        public string Preparation { get; set; }

        [Display(Name = "Κόστος")]
        [Required(ErrorMessage = "Το πεδίο 'Κόστος' είναι υποχρεωτικό")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Το πεδίο 'Κόστος' είναι θετικός ακέραιος αριθμός")]
        public string Price { get; set; }

        [Display(Name = "Διάρκεια")]
        public int Duration { get; set; }

    }
}