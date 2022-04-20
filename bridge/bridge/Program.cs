using bridge;
using System;

namespace BridgePattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vec = new Car();
            vec._bridge = new withButton();
            vec.startVehicle();
            vec._bridge.startBridge();

            vec = new Truck();
            vec._bridge = new withKey();
            vec.startVehicle();
            vec._bridge.startBridge();

            Console.ReadLine();
        }
    }
}