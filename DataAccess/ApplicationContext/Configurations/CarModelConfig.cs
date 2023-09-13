using Domain.Entities;
using Domain.ObjectValues;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ApplicationContext.Configurations
{
    internal class CarModelConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(c=>c.Label).IsRequired().HasMaxLength(200).HasColumnType("varchar");
            builder.Property(c => c.Model).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            builder.Property(c => c.PotoUrl).HasMaxLength(300).HasColumnType("varchar");
            builder.Property(c => c.DailyRate).HasPrecision(4, 2);
            builder.Property(x => x.Model).HasConversion(
                model => model.Value,
                str => new CarModel(str)
            );
        }
    }
 }

