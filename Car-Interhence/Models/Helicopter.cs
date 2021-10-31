using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class Helicopter:Air
    {
        public Helicopter(string brand, string model) : base(brand, model)
        {
            Console.WriteLine("Helicopter Page Created");
        }
        public Helicopter(string brand, string model, int productyear, string color, int count) : base(brand, model, productyear, color, count)
        {
            Console.WriteLine("Helicopter Page Created");
        }
        public void HelicopterInfo()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine($"Brand Name: {Brand}\nModel Name: {Model}\nProduct Year: {ProductYear}\nColor: {Color}Count: {Count}");
        }
    }
}

