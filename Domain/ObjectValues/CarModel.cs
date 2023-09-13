using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ObjectValues
{
 
    public record CarModel
    {
        private readonly string _value;

        public CarModel(string model)
        {
            _value = model;
        }

        public string Value => _value;
    }
}
