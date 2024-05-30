using EFRELATIONSHIPS.data;
using EFRELATIONSHIPS.models;
using Microsoft.EntityFrameworkCore;

namespace EFRELATIONSHIPS.repo
{
    public class Repository
    {

        private readonly AppDbContext appDbContext;

        public Repository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        // one to one

        public async Task AddCarCompany(CarCompany carCompany)
        {
            appDbContext.CarCompanies.Add(carCompany);
            await appDbContext.SaveChangesAsync();

        }

        public async Task<List<CarCompany>> GetCarCompanies() => await appDbContext.CarCompanies.ToListAsync();
        public async Task<List<CarModel>> GetCarModels() => await appDbContext.CarModels.ToListAsync();

        public async Task AddCarModel(CarModel carModel)
        {
            appDbContext.CarModels.Add(carModel);
            await appDbContext.SaveChangesAsync();

        }

        //one to many


        public async Task AddDoctor(Doctor doctor)
        {
            appDbContext.Doctors.Add(doctor);
            await appDbContext.SaveChangesAsync();

        }

        public async Task<List<Doctor>> GetDoctors() => await appDbContext.Doctors.Include(p=>p.Patients).ToListAsync();
        public async Task<List<Patient>> GetPatients() => await appDbContext.Patients.Include(d => d.Doctor).ToListAsync();

        public async Task AddPatient(Patient patient)
        {
            appDbContext.Patients.Add(patient);
            await appDbContext.SaveChangesAsync();

        }

        //many to many


        public async Task AddStudent(Student student)
        {
            appDbContext.Students.Add(student);
            await appDbContext.SaveChangesAsync();

        }

        public async Task<List<Student>> GetStudents() => await appDbContext.Students.Include(p => p.subjects).ToListAsync();
        public async Task<List<Subject>> GetSubjects() => await appDbContext.Subjects.Include(d => d.students).ToListAsync();

        public async Task AddSubject(Subject subject)
        {
            appDbContext.Subjects.Add(subject);
            await appDbContext.SaveChangesAsync();

        }
    }
}
