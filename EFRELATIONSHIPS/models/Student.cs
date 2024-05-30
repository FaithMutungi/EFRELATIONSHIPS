namespace EFRELATIONSHIPS.models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //many to many

        public List<Subject>? subjects { get; set; }
    }

    
}
