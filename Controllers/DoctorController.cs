using Clinics_Center.Data;
using Clinics_Center.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinics_Center.Controllers
{
    public class DoctorController : Controller
    {
        ApplicationDbContext context= new ApplicationDbContext();
        public IActionResult Bookappointment()
        {
            var result = context.Doctors.ToList();
            return View(result);
        }

        public IActionResult getBookappointment(int Id)
        {
            var result = context.Doctors.Find(Id);
            return View(result);
        }



    }
}
