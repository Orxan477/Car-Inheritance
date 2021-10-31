using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class Boat:WaterTransport
    {
        public Boat(string brand, string color) : base(brand, color)
        {
            Console.WriteLine("Boat Page Created");
        }
        public Boat(string brand, string model, int productyear, string color, int count, bool engine) : base(brand, model, productyear, color, count, engine)
        {
            Console.WriteLine("Boat Page Created");
        }
        public void BoatInfo()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Brand Name: {Brand}\nModel Name: {Model}\nProduct Year: {ProductYear}\nColor: {Color}\nCount: {Count}\nEngine: {Engine}");
        }
    }
}
