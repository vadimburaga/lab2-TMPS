using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    class withKey : IBridge
    {
        public void startBridge()
        {
            Console.WriteLine("started with Key");
        }
    }
}
