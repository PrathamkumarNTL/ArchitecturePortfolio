namespace Application.DTOs.Booking
{
    public class CreateBookingDto
    {
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime BookingDate { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
