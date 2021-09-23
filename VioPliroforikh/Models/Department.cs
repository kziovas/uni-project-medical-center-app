using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VioPliroforikh.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Details { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Logo { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Image1 { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Image2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required]
        [StringLength(255)]
        public string Phone { get; set; }


        [Column(TypeName = "nvarchar")]
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
    }
}