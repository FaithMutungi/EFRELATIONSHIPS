using System.Text.Json.Serialization;

namespace EFRELATIONSHIPS.models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string? Name { get; set; }


        //rel- one to many. one doc, many patients
        [JsonIgnore]
        public List<Patient>? Patients { get; set; }
    }
}
