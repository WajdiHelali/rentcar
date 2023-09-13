using Domain.ObjectValues;

namespace RentCar.DTOs
{
    public class AddCarResponse
    {
        public string Label { get; set; } = null!;
        public CarModel Model { get; set; } = null!;
        public string? PotoUrl { get; set; }
        public bool IsAvailable { get; set; } = true;
        public decimal DailyRate { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
