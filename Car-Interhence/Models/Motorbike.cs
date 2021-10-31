using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class Motorbike:TwoWheels
    {
        public Motorbike(string brand, string model) : base(brand, model)
        {
            Console.WriteLine("Motorbike Page Created");
        }
        public Motorbike(string brand, string model, int productyear, int walk, string color, bool engine) : base(brand, model, productyear, walk, color,engine)
        {
            Console.WriteLine("Motorbike Page Created");
        }
        public void MotoInfo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Brand Name: {Brand}\nModel Name: {Model}\nProduct Year: {ProductYear}\nWalk: {Walk}\nColor: {Color}\nEngine: {Engine}");
        }
    }
}
