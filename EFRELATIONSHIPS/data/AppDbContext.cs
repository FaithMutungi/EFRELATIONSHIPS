using EFRELATIONSHIPS.models;
using Microsoft.EntityFrameworkCore;

namespace EFRELATIONSHIPS.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<CarCompany> CarCompanies { get; set; }
        public  DbSet<CarModel> CarModels { get; set; }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects{ get; set; }
    }
}
