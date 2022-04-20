using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public abstract class Vehicle
    {
        public IBridge _bridge;
        public abstract void startVehicle();
    }
}
