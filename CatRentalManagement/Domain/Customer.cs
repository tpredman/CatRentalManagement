namespace CatRentalManagement.Domain
{
    public class Customer : BaseDomainModel
    {
        // Id already inherited from BaseDomainModel
        public string? DrivingLicense { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? EmailAddress { get; set; }

    }
}
