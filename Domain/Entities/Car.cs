using Domain.Entities.Base;
using Domain.ObjectValues;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Car:Entity
    {
        [MaxLength(200)]
        public string Label { get; set; } = null!;
        public CarModel Model { get; set; }=null!;
        public string? PotoUrl { get; set; }
        public bool IsAvailable { get; set; } = true;
        public decimal DailyRate { get; set; }
        public decimal PricePerDay { get; set; }
        public ICollection<RentalRecord> RentalRecords  { get; set; }=new List<RentalRecord>();
    }
}
