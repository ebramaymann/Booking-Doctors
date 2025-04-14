using Booking_Doctors.Data;
using Booking_Doctors.Models;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Doctors.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _context = new();
        
        public IActionResult BookAppointment(string? Specialization, string? doctorName)
        {
            IQueryable<Doctor> doctors = _context.Doctors;

           
            if (Specialization is not null)
            {
                doctors = doctors.Where(d => d.Specialization == (Specialization));
            }

            if (doctorName is not null)
            {
                doctors = doctors.Where(d => d.Name.Contains(doctorName));

            }



            // Prepare specialization list for dropdown
            var specializationData = _context.Doctors
                .Select(d => d.Specialization)
                .Distinct()
                .ToList();

            ViewData["spicializations"] = specializationData;



            return View(doctors.ToList());
        }

        public IActionResult Booking(int id)
        {
            var doctor = _context.Doctors.Find(id);
            if (doctor == null)
            {
                return NotFound();
            }
            return View(doctor);
        }
    }
}
