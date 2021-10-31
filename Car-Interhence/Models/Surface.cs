﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class Surface:Vehicle
    {
        
        public Surface(string brand, string model):base(brand,model)
        {
                
        }
        public Surface(string brand, string model, int productyear, int walk, string color, string gearbox,int count) : base(brand, model,productyear,walk,color,gearbox,count)
        {
            
        }
        public Surface(string brand, string model, int productyear, int walk, string color,bool engine) : base(brand, model, productyear, walk, color,engine)
        {
            
        }
        public Surface(string brand, int productyear, int walk, string color,bool engine) : base(brand, productyear, walk, color,engine)
        {
            
        }
    }
}
