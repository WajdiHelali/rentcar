using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer:Entity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } =null!;
        public string Email { get; set; } =null!;
        public string  Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City  { get; set; } = null!;
        public ICollection<RentalRecord> RentalRecords { get; set; } = new List<RentalRecord>();
    }
}
