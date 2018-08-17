using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Patterns
{
    abstract class Workshop
    {
        public string Name { get; set; }

        public Workshop(string n)
        {
            Name = n;
        }
        abstract public Car Create();
    }
 
    class Factory : Workshop
    {
        public Factory(string n) : base(n)
        { }

        public override Car Create()
        {
            return new RegularConveyorCar();
        }
    }

    class WestCoastCustoms : Workshop
    {
        public WestCoastCustoms(string n) : base(n)
        { }

        public override Car Create()
        {
            return new PimpMyRide();
        }
    }

    abstract class Car
    { }

    class RegularConveyorCar : Car
    {
        public RegularConveyorCar()
        {
            Console.WriteLine("Here is your ordinary car.");
        }
    }
    class PimpMyRide : Car
    {
        public PimpMyRide()
        {
            Console.WriteLine("We put a monitor in your monitor so you can...");
        }
    }
}
