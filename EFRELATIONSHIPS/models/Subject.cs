using System.Text.Json.Serialization;

namespace EFRELATIONSHIPS.models
{
    public class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //manay to many
        [JsonIgnore]
        public List<Student>? students { get; set; }
    }

    

}
