using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class Vehicle
    {
        public string Brand;
        public string Model;
        public int ProductYear;
        public int Walk;
        public string Color="Null";
        public string GearBox="Null";
        public int Count;
        public Vehicle(string brand,string model)
        {
            Brand = brand;
            Model = model;
        } 
        public Vehicle(string brand, string model, int productyear, int walk, string color) : this(brand, model)
        {
            ProductYear = productyear;
            Walk = walk;
            Color = color;     
        }
        public Vehicle(string brand, string model, int productyear, string color, int count) : this(brand, model)
        {
            ProductYear = productyear;
            Color = color;
            Count = count;
        }
        public Vehicle(string brand, int productyear, int walk, string color)  // : this(brand, productyear, walk, color)
        {
            Brand = brand;
            ProductYear = productyear;
            Walk = walk;
            Color = color;

        }
        public Vehicle(string brand, string model, int productyear, int walk, string color, string gearbox) : this(brand, model, productyear, walk, color)
        {
            GearBox = gearbox;
            
        }
        public Vehicle(string brand, string model, int productyear, int walk, string color, string gearbox,int count) : this(brand, model,productyear,walk,color)
        {
            GearBox = gearbox;
            Count = count;
        }

        
        //public Vehicle(string brand, string model, int productyear, int walk, string color, string gearbox) : this(brand, model, productyear, walk, color, gearbox)
        //{

        //}
    }
}
