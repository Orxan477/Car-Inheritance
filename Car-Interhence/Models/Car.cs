using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class Car:Surface
    {
        
        public Car(string brand, string model):base(brand,model)
        {
            Console.WriteLine("Car Page Created");
        }
        public Car(string brand, string model, int productyear, int walk, string color, string gearbox,int count) : base(brand, model, productyear, walk, color, gearbox,count)
        {
            Console.WriteLine("Car Page Created");
        }
        public void InfoCar()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Brand name: {Brand}\nModel name: {Model}\nProoduct Year: {ProductYear}\nWalk: {Walk}\nColor: {Color}\nGear Box: {GearBox}\nCount: {Count}");
        }
    }
}
