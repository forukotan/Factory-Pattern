using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Thingamajig : IVehicle

    {
        public void drive()
        {
            Console.WriteLine("here is your new whip the thingamajig");
        }
    }
}
