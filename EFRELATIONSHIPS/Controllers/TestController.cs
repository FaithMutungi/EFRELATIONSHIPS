using EFRELATIONSHIPS.models;
using EFRELATIONSHIPS.repo;
using Microsoft.AspNetCore.Mvc;

namespace EFRELATIONSHIPS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly Repository repository;
        public TestController(Repository repository)
        {
            this.repository = repository;

        }
        [HttpPost("company")]
        public async Task<IActionResult> AddCarCompany(CarCompany carCompany)
        {
             await repository.AddCarCompany(carCompany);
            return Ok("Company Saved");

        }

        [HttpPost("model")]
        public async Task<IActionResult> AddCarModel(CarModel carModel)
        {
            await repository.AddCarModel(carModel);
            return Ok("Car Model Saved");

        }

        [HttpGet("Company")]
        public async Task<IActionResult> GetCarCompanies() => Ok(await repository.GetCarCompanies());

        [HttpGet("Model")]
        public async Task<IActionResult> GetCarModels() => Ok(await repository.GetCarModels());

        //one to many

        [HttpPost("doctor")]
        public async Task<IActionResult> AddDoctor(Doctor doctor)
        {
            await repository.AddDoctor(doctor);
            return Ok("doctor Saved");

        }

        [HttpGet("doctor")]
        public async Task<IActionResult> GetDoctors() => Ok(await repository.GetDoctors());


        [HttpGet("patient")]
        public async Task<IActionResult> GetPatients() => Ok(await repository.GetPatients());

        [HttpPost("patient")]
        public async Task<IActionResult> AddPatient(Patient patient)
        {
            await repository.AddPatient(patient);
            return Ok("patient Saved");

        }

        //many to many


        [HttpPost("student")]
        public async Task<IActionResult> AddStudent(Student student)
        {
            await repository.AddStudent(student);
            return Ok("student Saved");

        }

        [HttpGet("student")]
        public async Task<IActionResult> GetStudents() => Ok(await repository.GetStudents());


        [HttpGet("subject")]
        public async Task<IActionResult> GetSubjects() => Ok(await repository.GetSubjects());

        [HttpPost("subject")]
        public async Task<IActionResult> AddSubject(Subject subject)
        {
            await repository.AddSubject(subject);
            return Ok("subjet Saved");

        }










    }
}
