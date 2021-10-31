using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class Truck:Vehicle
    {
        public int Length=0;
        public int Tonnage=0;
        public Truck(string brand, string model) : base(brand, model)
        {
            Console.WriteLine("Truck Page Created");
        }
        public Truck(string brand, string model, int productyear, int walk, string color, string gearbox,int length,int tonnage) :base(brand, model, productyear, walk, color, gearbox)
        {
            Console.WriteLine("Truck Page Created");
            Length = length;
            Tonnage = tonnage;
        }
        public void InfoTruck()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Brand name: {Brand}\nModel name: {Model}\nProoduct Year: {ProductYear}\nWalk: {Walk}\nColor: {Color}\nGear Box: {GearBox}\nLength: {Length}\nTonnage: {Tonnage}");
        }
    }
}
