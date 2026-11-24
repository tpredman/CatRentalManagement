namespace CatRentalManagement.Domain
{
    public class Booking : BaseDomainModel
    {
        // Id already inherited from BaseDomainModel
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }

    }
}
