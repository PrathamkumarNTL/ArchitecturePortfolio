namespace Domain.Entities
{
    public class Booking : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime BookingDate { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
