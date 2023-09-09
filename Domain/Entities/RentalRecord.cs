using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class RentalRecord:Entity
    {
        public Car Car { get; set; } = null!;
        public Guid CarId { get; set; }
        public Customer Customer { get; set; }=null!;
        public Guid CustomerId { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public decimal TotalCost { get; set; }
        public int Rate { get; set; }

    }
}
