using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class Bus:Vehicle
    {
        public double Length;
        public Bus(string brand, string model) : base(brand, model)
        {
            Console.WriteLine("Bus Page Created");
        }
        public Bus(string brand, string model, int productyear, int walk, string color, string gearbox, int count) : base(brand, model, productyear, walk, color, gearbox, count)
        {
            Console.WriteLine("Bus Page Created");
        }
        public Bus(string brand, string model, int productyear, int walk, string color, string gearbox, int count,double length) : base(brand, model, productyear, walk, color, gearbox, count)
        {
            Console.WriteLine("Bus Page Created");
            Length = length;
        }
        public void InfoBus()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Brand name: {Brand}\nModel name: {Model}\nProoduct Year: {ProductYear}\nWalk: {Walk}\nColor: {Color}\nGear Box: {GearBox}\nCount: {Count}\nLength: {Length}");
        }
    }
}
