using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace DataAccess.ApplicationContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
           
        }
   

        DbSet <Customer> Customers { get; set; }
        DbSet<Car> Cars { get; set; }
        DbSet<RentalRecord> RentalRecords { get; set;}
    }
}
