using System.Diagnostics;
using HealthCentreCare.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthCentreCare.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Appointment()
        {
            return View();
        }

        public IActionResult Bill()
        {
            return View();
        }


        public IActionResult Doctor()
        {
            return View();
        }

        public IActionResult New_Registration()
        {
            return View();
        }

        public IActionResult Patient()
        {
            return View();
        }
        public IActionResult Prescription_Doctor()
        {
            return View();
        }

        public IActionResult Prescription_Patient()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
     
  
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Cancel_Appointment()
        {
            return View();
        }
        public IActionResult View_Appointment()
        {
            return View();
        }
        public IActionResult OPD_Outpatient_Department()
        {
            return View();
        }

        public IActionResult OPD_Outpatient_Department2()
        {
            return View();
        }

        public IActionResult IPD_Inpatient_Department()
        {
            return View();
        }
        public IActionResult Accounting_Module()
        {
            return View();
        }


        public IActionResult Get_in_Touch()
        {
            return View();
        }

        public IActionResult department()
        {
            return View();
        }
        public IActionResult Vitals()
        {
            return View();
        }

        public IActionResult Cancel_Appointment_dashboard()
        {
            return View();
        }
        public IActionResult Medicine()
        {
            return View();
        }


        public IActionResult Blood_Donor_Reciever()
        {
            return View();
        }

        public IActionResult Ipd_Nurse()
        {
            return View();
        }

        public IActionResult Opd_Nurse()
        {
            return View();
        }
        public IActionResult Nurse()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
