using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class Ship:WaterTransport
    {
        public Ship(string brand,string model):base(brand,model)
        {
            Console.WriteLine("Ship Page Created");
        }
        public Ship(string brand, string model, int productyear, string color, int count, bool engine) : base(brand, model, productyear, color, count, engine)
        {
            Console.WriteLine("Ship Page Created");
        }
        public void ShipInfo()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Brand Name: {Brand}\nModel Name: {Model}\nProduct Year: {ProductYear}\nColor: {Color}\nCount: {Count}\nEngine: {Engine}");
        }
    }
}
