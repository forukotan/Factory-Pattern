using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    { 
        public static IVehicle GetVehicle(int wheels)
        {
            switch(wheels)
            {
                case 2:
                    return new Motorcycle();
                case 3:
                    return new Tricycle();
                case 4:
                    return new Van();
                default:
                    return new Van();
            }

        }
    }
}
