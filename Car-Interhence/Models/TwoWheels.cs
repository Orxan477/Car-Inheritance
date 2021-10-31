using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class TwoWheels:Surface
    {
        public bool Engine=false;
        public TwoWheels(string brand, string model) : base(brand, model)
        {
            
        }
        public TwoWheels(string brand, string model, int productyear, int walk, string color,bool engine) : base(brand, model, productyear, walk, color) //Mtorbike ucun ctor
        {
            Engine = engine;
        }
        public TwoWheels(string brand, int productyear, int walk, string color,bool engine)  : base(brand,productyear,walk,color) //Velobike ucun ctor
        {
            Engine = engine;
        }

    }

}
