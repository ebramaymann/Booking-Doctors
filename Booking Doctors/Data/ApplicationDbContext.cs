using Booking_Doctors.Models;
using Microsoft.EntityFrameworkCore;

namespace Booking_Doctors.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-JUIUM6J\\SQLEXPRESS;Initial Catalog=BookingDoctors;Integrated Security=True;TrustServerCertificate=True"); 

        }
        
    }
}
