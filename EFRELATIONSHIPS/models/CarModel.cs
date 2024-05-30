namespace EFRELATIONSHIPS.models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string? Model { get; set; }

        //relationship: one to one(car company should be there before we can add car model)

        public CarCompany? CarCompany { get; set; } //navigatio proprty
        public int CarCompanyId { get; set; }// fk
    }
}
