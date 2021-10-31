using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class WaterTransport:Vehicle
    {
        public WaterTransport(string brand,string color):base(brand,color)
        {

        }
        public WaterTransport(string brand, string model, int productyear, string color, int count,bool engine) : base(brand, model,productyear,color,count,engine)
        {
            
        }
    }
}
