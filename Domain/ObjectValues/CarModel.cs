using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ObjectValues
{
    public enum Models
    {
        MERCEDES,
        BMW,
        RENAULT,
        CITROENE
    }
    public record CarModel
    {
        private readonly Models Value;

        public CarModel(Models model)
        {
            Value = model;
        }
    }
}
