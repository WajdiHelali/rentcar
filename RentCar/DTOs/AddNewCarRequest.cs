using Domain.Entities;
using Domain.ObjectValues;

namespace RentCar.DTOs
{
    public record AddNewCarRequest
    {
        public string Label { get; set; } = null!;
        public string Model { get; set; } = null!;
        public decimal DailyRate { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
