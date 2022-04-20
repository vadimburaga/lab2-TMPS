using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    class Car : Vehicle
    {
        public override void startVehicle()
        {
            Console.WriteLine("Car started...");
        }
    }
}
