using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class Plane:Air
    {
        public Plane(string brand, string model) : base(brand, model)
        {
            Console.WriteLine("Plane Page Created");
        }
        public Plane(string brand, string model, int productyear, string color, int count) : base(brand, model, productyear, color, count)
        {
            Console.WriteLine("Plane Page Created");
        }
        public void PlaneInfo()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine($"Brand Name: {Brand}\nModel Name: {Model}\nProduct Year: {ProductYear}\nColor: {Color}Count: {Count}");
        }
    }
}
