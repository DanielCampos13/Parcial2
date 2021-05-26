using Microsoft.EntityFrameworkCore;
using Parcial02.Entities.Reservations;
using Parcial02.Entities.SecurityQuestions;
using Parcial02.Entities.Specialties;
using Parcial02.Entities.Users;

namespace Parcial02.Context
{
    public class UserContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Server=UFG\\SQLEXPRESS;Database=Parcial2;Trusted_Connection=True;");
        
        
        public DbSet<User> Users { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Specialty> Specialties { get; set; }


    }   
    
}