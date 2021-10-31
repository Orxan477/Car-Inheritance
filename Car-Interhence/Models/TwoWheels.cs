using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class TwoWheels:Surface
    {
        
        public TwoWheels(string brand, string model) : base(brand, model)
        {
            
        }
        public TwoWheels(string brand, string model, int productyear, int walk, string color,bool engine) : base(brand, model, productyear, walk, color,engine) //Motorbike ucun ctor
        {
            
        }
        public TwoWheels(string brand, int productyear, int walk, string color,bool engine)  : base(brand,productyear,walk,color,engine) //Velobike ucun ctor
        {
            
        }

    }

}
