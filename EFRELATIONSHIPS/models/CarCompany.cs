namespace EFRELATIONSHIPS.models
{
    public class CarCompany
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //relationship 1 to 1
        public CarModel? CarModel { get; set; } //navigation prop
    }
}
