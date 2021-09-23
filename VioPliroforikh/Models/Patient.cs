using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VioPliroforikh.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Όνομα Ασθενή")]
        [Required(ErrorMessage = "Το πεδίο 'Όνομα Ασθενή' είναι υποχρεωτικό")]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Επώνυμο Ασθενή")]
        [Required(ErrorMessage = "Το πεδίο 'Επώνυμο Ασθενή' είναι υποχρεωτικό")]
        [StringLength(255)]
        public string LastName { get; set; }

        [Display(Name = "Ημερομηνία Γέννησης")]
        [Required(ErrorMessage = "Το πεδίο 'Ημερομηνία Γέννησης' είναι υποχρεωτικό")]
        [RegularExpression(@"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$", ErrorMessage = "Το πεδίο 'Ημερομηνία Γέννησης' είναι της μορφής dd/mm/yyyy")]
        public string DoB { get; set; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Φύλλο")]
        public string Gender { get; set; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Παθήσεις")]
        public string Conditions { get; set; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Θεραπευτικές Αγωγές")]
        public string Treatments { get; set; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Τηλέφωνο Επικοινωνίας")]
        [Required(ErrorMessage = "Το πεδίο 'Τηλέφωνο Επικοινωνίας' είναι υποχρεωτικό")]
        [StringLength(255)]
        public string Phone{ get; set; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Το πεδίο 'Email' είναι υποχρεωτικό")]
        public string Email { get; set; }
    }
}