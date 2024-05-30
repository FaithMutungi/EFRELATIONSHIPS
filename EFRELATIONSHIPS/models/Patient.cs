namespace EFRELATIONSHIPS.models
{
    public class Patient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //many to one
        public Doctor? Doctor { get; set; }
        public int DoctorId { get; set; }
    }
}
