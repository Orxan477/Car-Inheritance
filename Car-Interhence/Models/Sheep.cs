using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class Sheep:WaterTransport
    {
        public Sheep(string brand,string model):base(brand,model)
        {
            Console.WriteLine("Sheep Page Created");
        }
        public Sheep(string brand, string model, int productyear, string color, int count, bool engine) : base(brand, model, productyear, color, count, engine)
        {
            Console.WriteLine("Sheep Page Created");
        }
        public void SheepInfo()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Brand Name: {Brand}\nModel Name: {Model}\nProduct Year: {ProductYear}\nColor: {Color}\nCount: {Count}\nEngine: {Engine}");
        }
    }
}
