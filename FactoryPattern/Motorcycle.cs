using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle

    {
        public void drive()
        {
            Console.WriteLine("We are building you a new motorcycle");
        }
        public int Wheels { get; set; }
    }

}
