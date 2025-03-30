using Booking_Doctors.Data;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Doctors.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _context = new();
        
        public IActionResult BookAppointment()
        {
            var doctors = _context.Doctors;
            return View(doctors.ToList());
        }
    }
}
