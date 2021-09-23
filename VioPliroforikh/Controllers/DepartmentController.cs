using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using VioPliroforikh.Models;
using VioPliroforikh.ViewModels;

namespace VioPliroforikh.Controllers
{
   
    public class DepartmentController : Controller
    {
        private ApplicationDbContext _context;

        public DepartmentController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Department
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DepartmentList()
        {

            var departments = new DepartmentsList() { Departments = _context.Departments.ToList() };
           // var department1 = new Department() { Id = 1, Title="Βιοπαθολογικό",Logo= "fa fa-stethoscope", Description= "Μικροβιολογικό, Ορμονολογικό, Βιοχημικό, Αιματολογικό, Ανοσολογικό, Αλλεργιολογικό, Νεοπλασματικοί δείκτες, Επίπεδα Φαρμάκων, Ανίχνευση τοξικών ουσιών, Προγεννητικός Έλεγχος, Μοριακή Βιολογία(PCR)", Phone="210-30313233",Email="viopath@vioexam.com"};
           // var department2 = new Department() { Id = 2, Title = "Κυτταρολογικό", Logo = "fa fa-flask", Description = "Παρακέντηση και Βιοψία όζων Θυρεοειδούς FNA, ειδικό τμήμα για PAP TEST (απλό και υγρής φάσης Thin Prep)", Phone = "210-30313234", Email = "kittaro@vioexam.com" };
           // var department3 = new Department() { Id = 3, Title = "Οφθαλμολογικό ", Logo = "fa fa-eye", Description = "Μέτρηση της οπτικής οξύτητας, Διάθλαστικός έλεγχος, Τονομέτρηση, Εξέταση στη σχισμοειδή λυχνία,Εξέταση με το οφθαλμοσκόπιο", Phone = "210-30313236", Email = "opto@vioexam.com" };
           // var department4 = new Department() { Id = 4, Title = "Καρδιολογικό", Logo = "fa fa-heartbeat", Description = "Triplex Καρδιάς, Ηλεκτροκαρδιογράφημα, Test Κοπώσεως, Holter Ρυθμού – Holter Πιέσεως", Phone = "210-30313235", Email = "cardio@vioexam.com" };
            
          //  var departments = new DepartmentsList()
           // {
          //      Departments = new List<Department> { department1, department2, department3, department4 }

          //  };

            return View(departments);
   
        }

        public ActionResult DepartmentSelected(int id)
        {
            Department department = _context.Departments.SingleOrDefault(d => d.Id == id);
            return View(department);

        }
    }
}