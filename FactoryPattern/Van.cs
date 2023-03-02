using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Van : IVehicle
    {
        public void drive()
        {
            Console.WriteLine($"Building a new car");
        }

        public bool HasCargo { get; set; }
    }
}
