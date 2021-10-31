using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class Velobike:TwoWheels
    {
        public string Type = "Null";
        public Velobike(string brand,  int productyear, int walk, string color, bool engine,string type) : base(brand, productyear, walk, color, engine)
        {      
            Console.WriteLine("Velobike Page Created");
            Type = type;
        }
        public void VeloInfo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Brand Name: {Brand}\nType: {Type}\nProduct Year: {ProductYear}\nWalk: {Walk}\nColor: {Color}\nEngine: {Engine}");
        }
    }
}
