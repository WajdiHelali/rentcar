using Domain.Entities.Base;
using Domain.ObjectValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class Car:Entity
    {
        public string Label { get; set; } = null!;
        public CarModel Model { get; set; }=null!;
        public string? PotoUrl { get; set; }
        public bool IsAvailable { get; set; } = true;
        public decimal DailyRate { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
